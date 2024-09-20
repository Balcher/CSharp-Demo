using halconCSharp2.VControl;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halconCSharp2.VFrame
{
    public partial class modelMatch : Form
    {
        private HWindow hv_Handle;
        private object myHw;
        private FlowNode previousControl;
        private FlowNode flowControl;
        private HTuple modelId;
        private HObject modelXld;
        private List<HObject> hImgs = new List<HObject>();
        private bool isMulti;
        private HImage himage;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();     // 定时器

        public modelMatch(FlowNode previousControl, FlowNode flowControl)
        {
            InitializeComponent();
            this.previousControl = previousControl;
            this.flowControl = flowControl;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 创建一个对话框
            var dialog = new OpenFileDialog();
            dialog.Filter = "模板及轮廓 | *.shm;*.hobj";
            dialog.RestoreDirectory = true;
            dialog.Multiselect = true;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的轮廓和模板路径
                var urls = dialog.FileNames;
                // 使用linq语句
                var modelUrl = urls.Where(url => url.Contains(".shm")).FirstOrDefault();
                var xldUrl = urls.Where(url => url.Contains(".hobj")).FirstOrDefault();
                // 把轮廓及模板加载到内存中
                HOperatorSet.ReadShapeModel(modelUrl, out modelId);
                HOperatorSet.ReadObject(out modelXld, xldUrl);

            }
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modelMatch_Load(object sender, EventArgs e)
        {
            //// 获取窗口对象
            hv_Handle = myHalconControl1.halconWindow;

        }

        /// <summary>
        /// 单图加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // 创建一个对话框
            var dialog = new OpenFileDialog();
            dialog.Filter = "图片 | *.jpg;*.bmp;*.png";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var url = dialog.FileName;
                himage = new HImage(url);
                myHalconControl1.DisplayImage(himage);
                isMulti = false;
            }
        }
        /// <summary>
        /// 多图加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // 创建一个对话框
            var dialog = new OpenFileDialog();
            dialog.Filter = "图片 | *.jpg;*.bmp;*.png";
            dialog.RestoreDirectory = true;
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var urls = dialog.FileNames;
                foreach (var url in urls)
                {
                    var hImg = new HImage(url);
                    // 存储到图像集合中
                    hImgs.Add(hImg);
                }
                myHalconControl1.DisplayImage(hImgs[0]);
                isMulti = true;
            }
        }
        /// <summary>
        /// 测试创建的模板是否匹配选择的测试图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if(!isMulti)
            {
                // 单图匹配
                ModelMatch(himage);
            }
            else
            {
                // 多图匹配
                timer.Start();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;    // 绑定定时器事件
            }
        }

        int index = 0;
        /// <summary>
        /// 使用定时器来轮询校验多张图像匹配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hImgs.Count > 0)
            {
                // 获取一张图像
                var img = hImgs[index++];
                // 执行图像匹配
                ModelMatch(img);
                // 判断模板匹配是否完成
                if (index == hImgs.Count)
                {
                    timer.Stop();
                    index = 0;
                    hv_Handle.ClearWindow();
                }
            }
        }

        private void ModelMatch(HObject L_Image)
        {
            HTuple hv_Score = new HTuple();
            // 通过模板ID定位模板图像位置及角度
            // L_Image 输入图像
            // modelID 形状模型ID
            // 0(最小角度)
            // (new HTuple(360)).TupleRad() 最大角度
            // 0.5 最小缩小比例
            // 1   最大缩放比例
            // 0.5 最小分数
            // least_square 优化方法
            // 0   金字塔等级
            // 0.7 最大角度误差
            // hv_Row1  输出的行坐标
            // hv_Column1 输出的列坐标
            // hv_Angle  输出的角度
            // hv_Score  输出的匹配得分
            HOperatorSet.FindShapeModel(L_Image, modelId, 0, (new HTuple(360)).TupleRad()
            , 0.5, 1, 0.5, "least_squares", 0, 0.7, out HTuple hv_Row1, out HTuple hv_Column1,
            out HTuple hv_Angle, out hv_Score);
            if (hv_Score.Type == HTupleType.EMPTY)
            {
                HOperatorSet.DispText(hv_Handle, "配置失败",
                "window", 12, 12, "red", new HTuple(), new HTuple());
                return;
            }
            // 这边的主要作用就是通过模板匹配得到的匹配结果进行旋转和平移操作，
            // 然后将这个变换应用到模板轮廓上，以便在图像中正确地显示出匹配到的轮廓

            // 创建一个齐次矩阵，创建一个2D单位矩阵
            HOperatorSet.HomMat2dIdentity(out HTuple hv_HomMat2DIdentity);
            //模板仿射变换，hv_Row1 Y方向平移量，hv_Column1 X方向平移量，输出2D仿射变换矩阵
            HOperatorSet.HomMat2dTranslate(hv_HomMat2DIdentity, hv_Row1, hv_Column1,
                out HTuple hv_HomMat2DTranslate);
            // 旋转
            HOperatorSet.HomMat2dRotate(hv_HomMat2DTranslate, hv_Angle, hv_Row1, hv_Column1,
                out HTuple hv_HomMat2DRotate);
            // 仿射变换轮廓
            HOperatorSet.AffineTransContourXld(modelXld, out HObject ho_ContoursAffineTrans,
                hv_HomMat2DRotate);
            // 显示结果
            HOperatorSet.SetColor(hv_Handle, "red");
            HOperatorSet.SetLineWidth(hv_Handle, 2);
            HOperatorSet.DispObj(L_Image, hv_Handle);
            HOperatorSet.DispObj(ho_ContoursAffineTrans, hv_Handle);
            // 获取轮廓中心
            HOperatorSet.AreaCenterXld(ho_ContoursAffineTrans, out HTuple Area, out HTuple xldRow, out HTuple xldColumn, out HTuple _);
            HOperatorSet.SetColor(hv_Handle, "green");
            HOperatorSet.SetLineWidth(hv_Handle, 1);
            // 绘制十字准星
            HOperatorSet.DispCross(hv_Handle, xldRow, xldColumn, 60, 0);
            HOperatorSet.DispText(hv_Handle, "匹配坐标：(row=" + hv_Row1.TupleString(".2f") + ",column=" + hv_Column1.TupleString(".2f"),
                "window", 12, 12, "red", new HTuple(), new HTuple());

            // 给父类的静态变量传值
            Form1.centerX = hv_Row1;
            Form1.centerY = hv_Column1;
        }
    }
}
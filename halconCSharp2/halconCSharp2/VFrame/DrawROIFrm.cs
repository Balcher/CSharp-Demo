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
    public partial class DrawROIFrm : Form
    {
        private FlowNode currentNode;
        private FlowNode preNode;
        public HWindow hv_Handle;
        private double row1;
        private double column1;
        private double row2;
        private double column2;

        public DrawROIFrm(FlowNode preNode, FlowNode currentNode)
        {
            InitializeComponent();
            this.currentNode = currentNode;
            this.preNode = preNode;
        }

        private void DrawROIFrm_Load(object sender, EventArgs e)
        {
            hv_Handle = mhc.halconWindow;
            hv_Handle.SetColor("green");
            hv_Handle.SetDraw("margin");

            // 获取输出的图像
            mhc.DisplayImage(preNode.output);

        }

        /// <summary>
        /// 绘制矩形ROI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 首先让其控件获取焦点
            mhc.Focus();

            // 绘制矩形ROI
            hv_Handle.DrawRectangle1(out row1, out column1, out row2, out column2);  // 显示图像的控件
            // 显示绘制矩形
            hv_Handle.DispRectangle1(row1, column1, row2, column2);
        }

        /// <summary>
        /// 修改ROI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // 清空窗口显示数据
            hv_Handle.ClearWindow();
            // 重新显示图片
            mhc.DisplayImage(preNode.output);
            // 绘制交互式的矩形
            hv_Handle.DrawRectangle1Mod(row1, column1, row2, column2, out row1, out column1, out row2, out column2);
            // 显示绘制矩形
            hv_Handle.DispRectangle1(row1, column1, row2, column2);

        }
        /// <summary>
        /// 截取模板区域并显示到对应视图窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // 清空窗口显示数据
            hv_Handle.ClearWindow();
            // 根据绘制矩形坐标生成对应矩形对象
            HOperatorSet.GenRectangle1(out HObject rect, row1, column1, row2, column2);
            // 获取模板区域显示图像
            HOperatorSet.ReduceDomain(preNode.output, rect, out HObject ImageReduced);
            // 获取模板图像
            HOperatorSet.CropDomain(ImageReduced, out HObject ImagePart);
            // 重新显示图像
            mhc.DisplayImage(ImagePart);
            // 设置当前节点的输入与输出
            currentNode.input = preNode.output;
            currentNode.output = ImagePart;
            currentNode.RoiOutput = new HTuple[] { row1, column1, row2, column2 };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

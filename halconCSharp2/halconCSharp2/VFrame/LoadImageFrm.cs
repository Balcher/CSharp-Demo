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
    public partial class LoadImageFrm : Form
    {
        private FlowNode flowNode;

        public LoadImageFrm(FlowNode flowNode)
        {
            InitializeComponent();
            this.flowNode = flowNode;    // 方便后面设置节点
        }

        /// <summary>
        /// 对象输入图像进行对应设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "选择图像类型 | *.png;*.jpg;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // 获取用户选择图像路径
                var imgUrl = dialog.FileName;
                // 根据获取图像路径创建Halcon图像对象
                var himg = new HImage();     // 图像
                himg.ReadImage(imgUrl);
                System.Diagnostics.Debug.WriteLine(imgUrl);
                // 设置当前节点输出结果
                flowNode.output = himg;
                Form1.RawImage = himg;
            }
        }

        private void btn_closewindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

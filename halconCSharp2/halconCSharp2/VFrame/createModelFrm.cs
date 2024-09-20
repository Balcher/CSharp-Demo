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
    public partial class createModelFrm : Form
    {
        private FlowNode previousNode;
        private FlowNode currentNode;
        private HWindow windowHandle;
        public HTuple hv_ModelID;
        public HObject modelContours;

        public createModelFrm(FlowNode previousNode, FlowNode currentNode)
        {
            InitializeComponent();
            this.previousNode = previousNode;
            this.currentNode = currentNode;
        }

        /// <summary>
        /// 根据设置参数创建模板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createTemplate_Click(object sender, EventArgs e)
        {
            hv_ModelID = null;
            // 获取模板参数
            var m_txtMincontrast = new HTuple(txtMincontrast.Text);                                // 金字塔层数
            var m_txtStartAngle = new HTuple(Convert.ToInt32(txtStartAngle.Text));                 // 起始角度
            var m_txtAngleRange = new HTuple(Convert.ToInt32(txtAngleRange.Text));                 // 角度范围
            var m_txtAngularStep = new HTuple(txtAngularStep.Text);                                // 角度步长
            var m_txtOptimizationType = txtOptimizationType.Text;                                  // 优化类型
            var m_txtMatchingIndex = txtMatchingIndex.Text;                                        // 匹配指标
            var m_txtContrastThreshold = new HTuple(Convert.ToInt32(txtContrastThreshold.Text));   // 对比度阈值
            var m_txtMinimumContrast = new HTuple(Convert.ToInt32(txtMinimumContrast.Text));       // 最小对比度

            // 获取创建模板的图像
            var modelImg = previousNode.output;

            // 调用HalconAPI中创建模板的方法[确定方法的参数类型]
            HOperatorSet.CreateShapeModel(modelImg, m_txtMincontrast, m_txtStartAngle.TupleRad(), 
                m_txtAngleRange.TupleRad(), m_txtAngularStep, m_txtOptimizationType, m_txtMatchingIndex, 
                m_txtContrastThreshold, m_txtMinimumContrast, out hv_ModelID);
            // 获取模板轮廓
            HOperatorSet.GetShapeModelContours(out modelContours, hv_ModelID, 1);
            // 持久化模板及对应轮廓到文件中
            HOperatorSet.WriteShapeModel(hv_ModelID, "model.shm");    // 将形状模型保存到指定文件夹，包含目标图像中的形状特征，如轮廓、方向、比例等信息
            HOperatorSet.WriteObject(modelContours, "model_xld");    // 将形状模型的轮廓保存为 XLD文件
            // 设置输入与输出
            currentNode.output = previousNode.output;
            MessageBox.Show("创建模板成功");

            // 变量给父类的静态变量
            Form1.hv_ModelID = hv_ModelID;
            Form1.modelContours = modelContours;
        }

        /// <summary>
        /// 创建完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_createFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createModelFrm_Load(object sender, EventArgs e)
        {
            // 获取halcon窗口对象
            windowHandle = myhc.halconWindow;
            // 把模板图像显示到当前窗口中
            myhc.DisplayImage(previousNode.output);
        }
    }
}

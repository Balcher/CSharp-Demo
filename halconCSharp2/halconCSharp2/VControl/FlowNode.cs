using halconCSharp2.VFrame;
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

namespace halconCSharp2.VControl
{
    public partial class FlowNode : UserControl
    {
        // 保存上一个处理完成的节点
        private static FlowNode preNode;

        public string NodeID { get; set; } // 节点编号
        public string preNodeID { get; set; } // 前一个节点ID
        public string nextNodeID { get; set; } // 下一个节点ID

        // 定义输入与输出字段
        public HObject input;
        public HObject output;
        public HTuple[] InputTuple;
        public HTuple[] OutputTuple;

        // 定义一个字段用于记录上一个节点数据
        private static FlowNode previousNode;
        private createModelFrm mycreateModelFrm;

        // 创建控件的自定义属性
        [Category("流程控件属性")]
        public string NodeName { get => title.Text; set => title.Text = value; }
        [Category("流程控件属性")]
        public Color LightColor { get => label_LED.ForeColor; set => label_LED.ForeColor = value; }
        public HObject[] Outputs { get; internal set; }
        public HTuple[] RoiOutput { get; internal set; }


        #region 定义委托申明和事件
        public delegate void myNodeSendMatchParam(HTuple hv_ModelID, HObject modelContours);
        public event myNodeSendMatchParam myNodeSendMatchParamEvent;
        #endregion

        public FlowNode()
        {
            InitializeComponent();
            NodeID = Guid.NewGuid().ToString().Replace("-", " ");
        }

        /// <summary>
        /// 双击流程控件需要执行的逻辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlowNode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 获取当前双击的流程节点的标题
            var title = this.NodeName;
            // 根据标题选择执行的流程逻辑
            switch (title)
            {
                case "加载图像":
                    // 打开加载图像设置的对话框
                    new LoadImageFrm(this).ShowDialog();
                    previousNode = this;
                    break;

                case "绘制矩形ROI":
                    new DrawROIFrm(previousNode, this).ShowDialog();
                    previousNode = this;
                    break;
                case "创建模板":
                    mycreateModelFrm = new createModelFrm(previousNode, this);
                    mycreateModelFrm.ShowDialog();
                    previousNode = this;
                    break;
                case "模板匹配":
                    new modelMatch(previousNode, this).ShowDialog();
                    previousNode = this;

                    break;

            }
        }

        public void myReceivedAndSendParam(HTuple hv_ModelID, HObject modelContours)
        {
            myNodeSendMatchParamEvent(hv_ModelID, modelContours);
        }
    }
}

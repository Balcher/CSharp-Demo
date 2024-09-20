using halconCSharp2.VControl;
using halconCSharp2.VHelper;
using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halconCSharp2
{
    public partial class Form1 : Form
    {
        private Label lbl;
        private bool isMoving;
        private Point startPoint;
        private DrawState drawState;
        private FlowNode node1;
        private int nodeNum;
        private FlowNode node2;
        private List<FlowNode> nodeList = new List<FlowNode>();         // 存储所有FlowNode的数组
        private List<FlowNode> orderNodeList = new List<FlowNode>();    // 按顺序存放所有FlowNode到数组(目前这个还只是单列顺序)
        private FlowNode beginNode;
        private HWindow form1_WinHandle;


        // 模板的一些参数
        public static HTuple hv_ModelID;
        public static HObject modelContours;
        // 模板匹配计算得到的中心点的位置
        public static double centerX;
        public static double centerY;
        public static HObject RawImage;
        public HObject detectImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_visionTool_Click(object sender, EventArgs e)
        {
            panel_image.Visible = false;
            panel_template.Visible = false;
        }

        private void btn_imageProcess_Click(object sender, EventArgs e)
        {
            panel_image.Visible = !panel_image.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_template.Visible = !panel_template.Visible;
        }


        #region 中间界面的流程控件拖动方法

        /// <summary>
        /// 所有菜单对应鼠标左键按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Tool_MouseDown(object sender, MouseEventArgs e)
        {
            // 判断是否按下了鼠标左键
            if (e.Button == MouseButtons.Left)
            {
                // 这个参数通常代表启动拖动操作的对象，在此情况下，传递给 DoDragDrop 作为拖动的数据对象
                // sender 通常是在事件触发时的对象，比如你拖动的控件或元素，这个数据会被传递到目标控件的DrawEnter或DragDrop中
                lbl = sender as Label;

                // 设置当前被点击的工具上的鼠标样式
                // DragDropEffects.Copy：表示拖放操作应该复制数据，也就是说，拖放完成后，
                // 原始数据保留在源控件中，同时将数据复制到目标控件中。
                // DragDropEffects.Move：表示拖放操作应该移动数据，完成拖放后，数据会从源控件中删除，并放到目标控件中。
                lbl.DoDragDrop(sender, DragDropEffects.Copy | DragDropEffects.Move);    // DoDragDrop 启动拖放操作
            }
        }

        /// <summary>
        /// 工具拖拽到流程编辑区时显示拖拽的鼠标样式效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PL_FlowProcess_DrawEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                // Copy：在拖放结束后，源控件的内容保持不变，数据被复制到目标控件。
                // Move：在拖放结束后，源控件的内容将被移除，数据移动到目标控件。
                e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
            }
        }

        /// <summary>
        /// 把工具拖放到编辑区域完成后方式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("panel1_DragDrop");
            var container = sender as Control;
            // 创建自定义流程对象
            FlowNode flownode = new FlowNode();
            nodeList.Add(flownode);

            // 给生成的新自定义控件对象注册对应鼠标事件
            MouseEventHelper.RegistryMouseEvent(flownode, NodeMouseDown, MouseEventName.MouseDown);  // 鼠标按下
            MouseEventHelper.RegistryMouseEvent(flownode, NodeMouseMove, MouseEventName.MouseMove);  // 鼠标移动
            MouseEventHelper.RegistryMouseEvent(flownode, NodeMouseUp, MouseEventName.MouseUp);  // 鼠标松开
            MouseEventHelper.RegistryMouseEvent(flownode, NodeMouseClick, MouseEventName.MouseDown);  // 鼠标点击

            //flownode.myNodeSendMatchParamEvent += new FlowNode.myNodeSendMatchParam(modelParam);

            // 设置流程节点文本
            flownode.NodeName = lbl.Text;

            // 设置控件的位置
            flownode.Location = container.PointToClient(new Point(e.X, e.Y));

            // 把按钮添加到对应位置
            container.Controls.Add(flownode);

        }

        // 接收模板的相关消息
        //public void modelParam(HTuple hv_ModelID, HObject modelContours)
        //{
        //    this.hv_ModelID = hv_ModelID;
        //    this.modelContours = modelContours;
        //}

        /// <summary>
        /// 在流程节点上按下鼠标左键处理事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NodeMouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            startPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// 鼠标在流程节点上松开的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NodeMouseUp(object sender, MouseEventArgs e)
        {
            // 鼠标移动结束
            if (isMoving == true)
            {
                isMoving = false;
            }
        }

        /// <summary>
        /// 鼠标按下在控件上移动过程进行的设置操作事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NodeMouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                if (e.Button == MouseButtons.Left)
                {
                    // sender是触发事件的控件，as control将它转换为 control 类型的对象
                    var control = sender as Control;
                    control.Cursor = Cursors.Hand;
                    // .parent 用于获取父级控件或容器，
                    // 如果control是一个按钮，而这个按钮位于一个panel容器中，
                    // control.Parent就会返回这个Panel对象
                    var node = control.Parent;
                    // 获取控件的偏移量
                    int left = node.Left + (e.X - startPoint.X);
                    int top = node.Top + (e.Y - startPoint.Y);
                    // 获取控件本身的宽和高
                    int width = node.Width;
                    int height = node.Height;
                    // 动态获取流程编辑区域的大小
                    var rect = node.Parent.ClientRectangle;
                    // 判断拖拽的过程中不能超出边界
                    left = left < 0 ? 0 : ((left + width > rect.Width) ? rect.Width - width : left);
                    top = top < 0 ? 0 : ((top + height > rect.Height) ? rect.Height - height : top);

                    // 设置控件新的偏移量
                    node.Left = left;
                    node.Top = top;

                    // 强制刷新流程控件
                    // Invalidate() 是control类的一个方法，用于通知系统该控件的显示区域无效，并且需要重新绘制或刷新
                    panel1.Invalidate();
                }
            }
        }


        /// <summary>
        /// 点击流程控件的事件,用来连线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NodeMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 判断是否为连线状态
                if (drawState == DrawState.DrawLine)
                {
                    var control = sender as Control;
                    if (nodeNum == 0) // 开始节点
                    {
                        if (control.Parent != null)
                        {
                            // 获取连接点的一个节点
                            node1 = (FlowNode)control.Parent;
                            nodeNum = 1;
                        }
                        else
                        {
                            MessageBox.Show("请选择一个流程节点");
                        }

                    }
                    else if (nodeNum == 1)
                    {
                        // 绘制两个节点连线操作
                        if (control.Parent != null)
                        {
                            node2 = (FlowNode)control.Parent;
                            // 判断点击是否为同一个节点
                            if (!node2.Equals(node1))
                            {
                                // 设置从属关系
                                node1.nextNodeID = node2.NodeID;
                                node2.preNodeID = node1.NodeID;

                                // 找到了第二个节点，需要把nodeNum重置为0，为下一次连线做准备
                                nodeNum = 0;
                                // 绘制连线
                                DrawPointToPointLine(node1, node2);
                                // 恢复正常绘制状态
                                drawState = DrawState.Normal;
                            }
                        }
                        else
                        {
                            MessageBox.Show("请选择需要连线目标节点");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 连接线的实现方式
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void DrawPointToPointLine(FlowNode ctl1, FlowNode ctl2)
        {
            // 定义两个点对象变量
            Point p1, p2;
            // 从左到右连线
            if (Math.Abs(ctl2.Location.X - ctl1.Location.X) > Math.Abs(ctl2.Location.Y - ctl1.Location.Y) && ctl2.Location.X >= ctl1.Location.X)
            {
                p1 = new Point(ctl1.Location.X + ctl1.Width + 1, ctl1.Location.Y + ctl1.Height / 2);
                p2 = new Point(ctl2.Location.X - 1, ctl2.Location.Y + ctl2.Height / 2);
                DrawJoinLine(p1, p2, LineForward.L_R);
            }
            // 从右到左
            else if (Math.Abs(ctl2.Location.X - ctl1.Location.X) > Math.Abs(ctl2.Location.Y - ctl1.Location.Y) && ctl2.Location.X < ctl1.Location.X)
            {
                p1 = new Point(ctl1.Location.X - 1, ctl1.Location.Y + ctl1.Height / 2);
                p2 = new Point(ctl2.Location.X + ctl2.Width + 1, ctl2.Location.Y + ctl2.Height / 2);
                DrawJoinLine(p1, p2, LineForward.R_L);
            }
            // 从上到下
            else if (Math.Abs(ctl2.Location.X - ctl1.Location.X) <= Math.Abs(ctl2.Location.Y - ctl1.Location.Y) && ctl2.Location.Y >= ctl1.Location.Y)
            {
                p1 = new Point(ctl1.Location.X + ctl1.Width / 2, ctl1.Location.Y + ctl1.Height + 1);
                p2 = new Point(ctl2.Location.X + ctl2.Width / 2, ctl2.Location.Y - 1);
                DrawJoinLine(p1, p2, LineForward.U_D);
            }
            // 从下到上
            else if (Math.Abs(ctl2.Location.X - ctl1.Location.X) < Math.Abs(ctl2.Location.Y - ctl1.Location.Y) && ctl2.Location.Y < ctl1.Location.Y)
            {
                p1 = new Point(ctl1.Location.X + ctl1.Width / 2, ctl1.Location.Y - 1);
                p2 = new Point(ctl2.Location.X + ctl2.Width / 2, ctl2.Location.Y + ctl2.Height + 1);
                DrawJoinLine(p1, p2, LineForward.D_U);
            }
        }

        /// <summary>
        /// 绘制两点之间的连线
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="l_R"></param>
        private void DrawJoinLine(Point p1, Point p2, LineForward forward)
        {
            // 绘制图形的面板应该
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;

            // 绘制图形的线
            Color color = Color.DarkRed;    // 创建一个color对象
            Pen p = new Pen(color, 3);    // pen对象
            p.DashStyle = DashStyle.Solid;    // 实线
            p.StartCap = LineCap.Round;    // 起点端帽样式  圆形
            p.EndCap = LineCap.ArrowAnchor;    // 终点端帽样式  箭头形状
            p.LineJoin = LineJoin.Round; // 连接处样式 圆角

           // 连线中间的两个点
            Point inflectPoint1;
            Point inflectPoint2;
            if (forward == LineForward.L_R || forward == LineForward.R_L)
            {
                inflectPoint1 = new Point((p1.X + p2.X) / 2, p1.Y);
                inflectPoint2 = new Point((p1.X + p2.X) / 2, p2.Y);
            }
            else
            {
                inflectPoint1 = new Point(p1.X, (p1.Y + p2.Y) / 2);
                inflectPoint2 = new Point(p2.X, (p1.Y + p2.Y) / 2);
            }

            // 从点p1到中间两个点到p2
            Point[] points = new Point[] { p1, inflectPoint1, inflectPoint2, p2 };
            g.DrawLines(p, points);
        }

        #endregion 中间界面的流程控件拖动方法


        #region 连线处理

        enum DrawState
        {
            Normal,    // 正常状态
            DrawLine   // 连线状态
        }

        /// <summary>
        /// 定义绘制线的方向枚举
        /// </summary>
        enum LineForward
        {
            L_R,
            R_L,
            U_D,
            D_U
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("ToolStripMenuItem_Click");
            drawState = DrawState.DrawLine;
        }

        #endregion  连线处理

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var control = sender as Control;
            DrawAllLines(control);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="control"></param>
        private void DrawAllLines(Control control)
        {
            // 找出流程编辑器上所有流程控件
            foreach (var ctl1 in control.Controls)
            {
                if (ctl1 is FlowNode)
                {
                    var fn1 = (FlowNode)ctl1;
                    foreach (var ctl2 in control.Controls)
                    {
                        if (ctl2 is FlowNode)
                        {
                            // 判断两个控件之间是否存在关系
                            var fn2 = (FlowNode)ctl2;
                            // 判断节点之间是否存在从属关系
                            if (fn1.nextNodeID != null && fn1.nextNodeID == fn2.NodeID)
                            {
                                DrawPointToPointLine(fn1, fn2);
                            }
                        }
                    }

                }
            }
        }


        static int ClickNum = 0;
        /// <summary>
        /// 单步执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // 第一次点击的时候
            if (ClickNum == 0)
            {
                System.Diagnostics.Debug.WriteLine(nodeList.Count());
                foreach (var nodelist in nodeList)
                {
                    if (nodelist.preNodeID == null)
                    {
                        beginNode = nodelist;
                    }
                    if(nodelist.NodeName == "加载图像")
                    {
                        RawImage = nodelist.output;
                        myWinForm.DisplayImage(RawImage);
                    }
                }

                orderNodeList.Add(beginNode);
                var currentNode = beginNode;
                while (currentNode.nextNodeID != null)
                {
                    foreach (var node in nodeList)
                    {
                        if(node.NodeID == currentNode.nextNodeID)
                        {
                            orderNodeList.Add(node);
                            currentNode = node;
                        }
                    }
                }

                beginNode.LightColor = Color.Blue;
                ClickNum++;
            }
            else
            {
                if (ClickNum == orderNodeList.Count)
                {
                    ClickNum = 0;
                    foreach (var node in orderNodeList)
                    {
                        node.LightColor = Color.Red;
                    }
                    currentStep.Text = orderNodeList[ClickNum].NodeName;
                    myWinForm.DisplayImage(RawImage);
                }

                orderNodeList[ClickNum].LightColor = Color.Blue;                       // 流程编辑上面颜色置为蓝色
                System.Diagnostics.Debug.WriteLine(orderNodeList[ClickNum].NodeName);  // 打印输出

                if (orderNodeList[ClickNum].NodeName == "绘制矩形ROI")
                {
                    currentStep.Text = "绘制矩形ROI";
                }
                else if(orderNodeList[ClickNum].NodeName == "创建模板")
                {
                    currentStep.Text = "创建模板";

                    // 当前节点的输出参数图像
                    HObject image = orderNodeList[ClickNum].output;
                    myWinForm.DisplayImage(image);
                }
                else if(orderNodeList[ClickNum].NodeName == "模板匹配")
                {
                    currentStep.Text = "模板匹配";

                    adjustImage(RawImage);
                    ModelMatch(RawImage);

                    // 显示模板center位置
                    CenterX.Text = centerX.ToString();
                    CenterY.Text = centerY.ToString();
                }
                ClickNum++;
            } 
        }

        /// <summary>
        /// 单次执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // 清空所有按钮为蓝色
            foreach (var node in orderNodeList)
            {
                node.LightColor = Color.Blue;
            }

            // 找到头节点
            foreach (var nodelist in nodeList)
            {
                if (nodelist.preNodeID == null)
                {
                    beginNode = nodelist;
                }
                if (nodelist.NodeName == "加载图像")
                {
                    RawImage = nodelist.output;
                    myWinForm.DisplayImage(RawImage);
                }
            }


            adjustImage(RawImage);
            ModelMatch(RawImage);

            // 显示模板center位置
            CenterX.Text = centerX.ToString();
            CenterY.Text = centerY.ToString();
            currentStep.Text = "运行完毕";


            // 将单步执行的序号置为1
            ClickNum = 1;


        }


        /// <summary>
        /// form1上面的控件启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myWinForm_Load(object sender, EventArgs e)
        {
            form1_WinHandle = myWinForm.halconWindow;
        }

        public void adjustImage(HObject image)
        {
            HOperatorSet.ClearWindow(myWinForm.halconWindow);
            HOperatorSet.GetImageSize(image, out var width, out var height);
            HOperatorSet.GetWindowExtents(myWinForm.halconWindow, out var _, out var _, out var width2, out var height2);
            HTuple hTuple = 1.0 * height2 / width2 * width;
            if (hTuple > height)
            {
                hTuple = 1.0 * (hTuple - height) / 2;
                HOperatorSet.SetPart(myWinForm.halconWindow, -hTuple, 0, hTuple + height, width);
            }
            else
            {
                HTuple hTuple2 = 1.0 * width2 / height2 * height;
                hTuple2 = 1.0 * (hTuple2 - width) / 2;
                HOperatorSet.SetPart(myWinForm.halconWindow, 0, -hTuple2, height, hTuple2 + width);
                System.Diagnostics.Debug.WriteLine($"SetPart: (0, -{hTuple2}, {height}, {hTuple2 + width})");
            }

            HOperatorSet.DispObj(image, myWinForm.halconWindow);
        }

        private void ModelMatch(HObject img)
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
            HOperatorSet.FindShapeModel(img, hv_ModelID, 0, (new HTuple(360)).TupleRad()
            , 0.5, 1, 0.5, "least_squares", 0, 0.7, out HTuple hv_Row1, out HTuple hv_Column1,
            out HTuple hv_Angle, out hv_Score);

            if (hv_Score.Type == HTupleType.EMPTY)
            {
                HOperatorSet.DispText(myWinForm.halconWindow, "配置失败",
                "window", 12, 12, "red", new HTuple(), new HTuple());
                return;
            }
            // 创建一个齐次矩阵，创建一个2D单位矩阵
            HOperatorSet.HomMat2dIdentity(out HTuple hv_HomMat2DIdentity);
            //模板仿射变换，hv_Row1 Y方向平移量，hv_Column1 X方向平移量，输出2D仿射变换矩阵
            HOperatorSet.HomMat2dTranslate(hv_HomMat2DIdentity, hv_Row1, hv_Column1,
                out HTuple hv_HomMat2DTranslate);
            // 旋转
            HOperatorSet.HomMat2dRotate(hv_HomMat2DTranslate, hv_Angle, hv_Row1, hv_Column1,
                out HTuple hv_HomMat2DRotate);
            // 仿射变换轮廓
            HOperatorSet.AffineTransContourXld(modelContours, out HObject ho_ContoursAffineTrans,
                hv_HomMat2DRotate);
            // 显示结果
            HOperatorSet.SetColor(myWinForm.halconWindow, "red");
            HOperatorSet.SetLineWidth(myWinForm.halconWindow, 2);
            HOperatorSet.DispObj(img, myWinForm.halconWindow);
            HOperatorSet.DispObj(ho_ContoursAffineTrans, myWinForm.halconWindow);
            // 获取轮廓中心
            HOperatorSet.AreaCenterXld(ho_ContoursAffineTrans, out HTuple Area, out HTuple xldRow, out HTuple xldColumn, out HTuple _);
            HOperatorSet.SetColor(myWinForm.halconWindow, "green");
            HOperatorSet.SetLineWidth(myWinForm.halconWindow, 1);
            // 绘制十字准星
            HOperatorSet.DispCross(myWinForm.halconWindow, xldRow, xldColumn, 60, 0);
            HOperatorSet.DispText(myWinForm.halconWindow, "匹配坐标：(row=" + hv_Row1.TupleString(".2f") + ",column=" + hv_Column1.TupleString(".2f"),
                "window", 12, 12, "red", new HTuple(), new HTuple());

            centerX = hv_Row1;
            centerY = hv_Column1;
            
        }


    }
}

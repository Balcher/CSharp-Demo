
namespace halconCSharp2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_template = new System.Windows.Forms.Panel();
            this.label_match = new System.Windows.Forms.Label();
            this.label_template = new System.Windows.Forms.Label();
            this.label_rectangleROI = new System.Windows.Forms.Label();
            this.label_circleROI = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_image = new System.Windows.Forms.Panel();
            this.label_morphology = new System.Windows.Forms.Label();
            this.label_binary = new System.Windows.Forms.Label();
            this.label_grayImage = new System.Windows.Forms.Label();
            this.label_loadImage = new System.Windows.Forms.Label();
            this.btn_imageProcess = new System.Windows.Forms.Button();
            this.btn_visionTool = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cm_drawJointLine = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.myWinForm = new halconCSharp2.VControl.MyHalconControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentStep = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel_template.SuspendLayout();
            this.panel_image.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cm_drawJointLine.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_template);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel_image);
            this.groupBox1.Controls.Add(this.btn_imageProcess);
            this.groupBox1.Controls.Add(this.btn_visionTool);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 603);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "视觉工具箱";
            // 
            // panel_template
            // 
            this.panel_template.Controls.Add(this.label_match);
            this.panel_template.Controls.Add(this.label_template);
            this.panel_template.Controls.Add(this.label_rectangleROI);
            this.panel_template.Controls.Add(this.label_circleROI);
            this.panel_template.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_template.Location = new System.Drawing.Point(3, 280);
            this.panel_template.Name = "panel_template";
            this.panel_template.Size = new System.Drawing.Size(269, 171);
            this.panel_template.TabIndex = 4;
            // 
            // label_match
            // 
            this.label_match.AllowDrop = true;
            this.label_match.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_match.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_match.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_match.Location = new System.Drawing.Point(42, 134);
            this.label_match.Name = "label_match";
            this.label_match.Size = new System.Drawing.Size(177, 27);
            this.label_match.TabIndex = 1;
            this.label_match.Text = "模板匹配";
            this.label_match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_match.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // label_template
            // 
            this.label_template.AllowDrop = true;
            this.label_template.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_template.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_template.Location = new System.Drawing.Point(42, 92);
            this.label_template.Name = "label_template";
            this.label_template.Size = new System.Drawing.Size(177, 27);
            this.label_template.TabIndex = 2;
            this.label_template.Text = "创建模板";
            this.label_template.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_template.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // label_rectangleROI
            // 
            this.label_rectangleROI.AllowDrop = true;
            this.label_rectangleROI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_rectangleROI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_rectangleROI.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_rectangleROI.Location = new System.Drawing.Point(42, 8);
            this.label_rectangleROI.Name = "label_rectangleROI";
            this.label_rectangleROI.Size = new System.Drawing.Size(177, 27);
            this.label_rectangleROI.TabIndex = 4;
            this.label_rectangleROI.Text = "绘制矩形ROI";
            this.label_rectangleROI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_rectangleROI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // label_circleROI
            // 
            this.label_circleROI.AllowDrop = true;
            this.label_circleROI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_circleROI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_circleROI.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_circleROI.Location = new System.Drawing.Point(42, 50);
            this.label_circleROI.Name = "label_circleROI";
            this.label_circleROI.Size = new System.Drawing.Size(177, 27);
            this.label_circleROI.TabIndex = 3;
            this.label_circleROI.Text = "绘制圆形ROI";
            this.label_circleROI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_circleROI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "模板匹配工具";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_image
            // 
            this.panel_image.Controls.Add(this.label_morphology);
            this.panel_image.Controls.Add(this.label_binary);
            this.panel_image.Controls.Add(this.label_grayImage);
            this.panel_image.Controls.Add(this.label_loadImage);
            this.panel_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_image.Location = new System.Drawing.Point(3, 88);
            this.panel_image.Name = "panel_image";
            this.panel_image.Size = new System.Drawing.Size(269, 161);
            this.panel_image.TabIndex = 2;
            // 
            // label_morphology
            // 
            this.label_morphology.AllowDrop = true;
            this.label_morphology.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_morphology.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_morphology.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_morphology.Location = new System.Drawing.Point(42, 121);
            this.label_morphology.Name = "label_morphology";
            this.label_morphology.Size = new System.Drawing.Size(177, 27);
            this.label_morphology.TabIndex = 0;
            this.label_morphology.Text = "形态学图像";
            this.label_morphology.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_morphology.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // label_binary
            // 
            this.label_binary.AllowDrop = true;
            this.label_binary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_binary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_binary.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_binary.Location = new System.Drawing.Point(42, 85);
            this.label_binary.Name = "label_binary";
            this.label_binary.Size = new System.Drawing.Size(177, 27);
            this.label_binary.TabIndex = 0;
            this.label_binary.Text = "二值化图像";
            this.label_binary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_binary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // label_grayImage
            // 
            this.label_grayImage.AllowDrop = true;
            this.label_grayImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_grayImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_grayImage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_grayImage.Location = new System.Drawing.Point(42, 49);
            this.label_grayImage.Name = "label_grayImage";
            this.label_grayImage.Size = new System.Drawing.Size(177, 27);
            this.label_grayImage.TabIndex = 0;
            this.label_grayImage.Text = "灰度图像";
            this.label_grayImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_grayImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // label_loadImage
            // 
            this.label_loadImage.AllowDrop = true;
            this.label_loadImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_loadImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_loadImage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_loadImage.Location = new System.Drawing.Point(42, 13);
            this.label_loadImage.Name = "label_loadImage";
            this.label_loadImage.Size = new System.Drawing.Size(177, 27);
            this.label_loadImage.TabIndex = 0;
            this.label_loadImage.Text = "加载图像";
            this.label_loadImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_loadImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Tool_MouseDown);
            // 
            // btn_imageProcess
            // 
            this.btn_imageProcess.BackColor = System.Drawing.SystemColors.Info;
            this.btn_imageProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_imageProcess.Location = new System.Drawing.Point(3, 57);
            this.btn_imageProcess.Name = "btn_imageProcess";
            this.btn_imageProcess.Size = new System.Drawing.Size(269, 31);
            this.btn_imageProcess.TabIndex = 1;
            this.btn_imageProcess.Text = "图像处理工具";
            this.btn_imageProcess.UseVisualStyleBackColor = false;
            this.btn_imageProcess.Click += new System.EventHandler(this.btn_imageProcess_Click);
            // 
            // btn_visionTool
            // 
            this.btn_visionTool.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_visionTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_visionTool.Location = new System.Drawing.Point(3, 17);
            this.btn_visionTool.Name = "btn_visionTool";
            this.btn_visionTool.Size = new System.Drawing.Size(269, 40);
            this.btn_visionTool.TabIndex = 0;
            this.btn_visionTool.Text = "视觉处理工具箱";
            this.btn_visionTool.UseVisualStyleBackColor = false;
            this.btn_visionTool.Click += new System.EventHandler(this.btn_visionTool_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(284, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 603);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "流程编辑";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(201, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "单次执行";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "单步执行";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.cm_drawJointLine;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 548);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PL_FlowProcess_DrawEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cm_drawJointLine
            // 
            this.cm_drawJointLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.cm_drawJointLine.Name = "contextMenuStrip1";
            this.cm_drawJointLine.Size = new System.Drawing.Size(101, 26);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem.Text = "连线";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.myWinForm);
            this.groupBox3.Location = new System.Drawing.Point(650, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 320);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "可视化流程窗口";
            // 
            // myWinForm
            // 
            this.myWinForm.Location = new System.Drawing.Point(6, 20);
            this.myWinForm.Name = "myWinForm";
            this.myWinForm.Size = new System.Drawing.Size(347, 294);
            this.myWinForm.TabIndex = 0;
            this.myWinForm.Load += new System.EventHandler(this.myWinForm_Load);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.currentStep);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.CenterY);
            this.groupBox4.Controls.Add(this.CenterX);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(650, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 277);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "执行现状以及结果判断输出";
            // 
            // CenterY
            // 
            this.CenterY.Location = new System.Drawing.Point(134, 158);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(100, 21);
            this.CenterY.TabIndex = 1;
            // 
            // CenterX
            // 
            this.CenterX.Location = new System.Drawing.Point(134, 126);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(100, 21);
            this.CenterX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "轮廓的中心点Y";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "轮廓的中心点X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前进行流程：";
            // 
            // currentStep
            // 
            this.currentStep.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentStep.Location = new System.Drawing.Point(133, 41);
            this.currentStep.Name = "currentStep";
            this.currentStep.Size = new System.Drawing.Size(100, 26);
            this.currentStep.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 618);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel_template.ResumeLayout(false);
            this.panel_image.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.cm_drawJointLine.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_visionTool;
        private System.Windows.Forms.Button btn_imageProcess;
        private System.Windows.Forms.Panel panel_image;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_template;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_loadImage;
        private System.Windows.Forms.Label label_match;
        private System.Windows.Forms.Label label_template;
        private System.Windows.Forms.Label label_rectangleROI;
        private System.Windows.Forms.Label label_circleROI;
        private System.Windows.Forms.Label label_morphology;
        private System.Windows.Forms.Label label_binary;
        private System.Windows.Forms.Label label_grayImage;
        private System.Windows.Forms.ContextMenuStrip cm_drawJointLine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private VControl.MyHalconControl myWinForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CenterY;
        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.TextBox currentStep;
        private System.Windows.Forms.Label label3;
    }
}



namespace halconCSharp2.VFrame
{
    partial class DrawROIFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_drawROI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mhc = new halconCSharp2.VControl.MyHalconControl();
            this.SuspendLayout();
            // 
            // btn_drawROI
            // 
            this.btn_drawROI.Location = new System.Drawing.Point(12, 501);
            this.btn_drawROI.Name = "btn_drawROI";
            this.btn_drawROI.Size = new System.Drawing.Size(145, 39);
            this.btn_drawROI.TabIndex = 1;
            this.btn_drawROI.Text = "选择图像上模板区域";
            this.btn_drawROI.UseVisualStyleBackColor = true;
            this.btn_drawROI.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改选择模板区域";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 39);
            this.button3.TabIndex = 1;
            this.button3.Text = "截取模板区域";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(492, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "选择完成";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mhc
            // 
            this.mhc.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.mhc.Location = new System.Drawing.Point(30, 12);
            this.mhc.Name = "mhc";
            this.mhc.Size = new System.Drawing.Size(640, 480);
            this.mhc.TabIndex = 0;
            // 
            // DrawROIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 557);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_drawROI);
            this.Controls.Add(this.mhc);
            this.Name = "DrawROIFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DrawROIFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VControl.MyHalconControl mhc;
        private System.Windows.Forms.Button btn_drawROI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
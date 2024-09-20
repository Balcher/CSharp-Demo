
namespace halconCSharp2.VFrame
{
    partial class createModelFrm
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
            this.myhc = new halconCSharp2.VControl.MyHalconControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMincontrast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngleRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAngularStep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOptimizationType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatchingIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContrastThreshold = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinimumContrast = new System.Windows.Forms.TextBox();
            this.btn_createTemplate = new System.Windows.Forms.Button();
            this.btn_createFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myhc
            // 
            this.myhc.Location = new System.Drawing.Point(12, 12);
            this.myhc.Name = "myhc";
            this.myhc.Size = new System.Drawing.Size(398, 334);
            this.myhc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(427, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "金字塔数";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMincontrast
            // 
            this.txtMincontrast.Location = new System.Drawing.Point(510, 19);
            this.txtMincontrast.Name = "txtMincontrast";
            this.txtMincontrast.Size = new System.Drawing.Size(100, 21);
            this.txtMincontrast.TabIndex = 2;
            this.txtMincontrast.Text = "auto";
            this.txtMincontrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(427, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "起始角度";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.Location = new System.Drawing.Point(510, 57);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(100, 21);
            this.txtStartAngle.TabIndex = 2;
            this.txtStartAngle.Text = "0";
            this.txtStartAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(427, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "角度范围";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAngleRange
            // 
            this.txtAngleRange.Location = new System.Drawing.Point(510, 95);
            this.txtAngleRange.Name = "txtAngleRange";
            this.txtAngleRange.Size = new System.Drawing.Size(100, 21);
            this.txtAngleRange.TabIndex = 2;
            this.txtAngleRange.Text = "360";
            this.txtAngleRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(427, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "角度步长";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAngularStep
            // 
            this.txtAngularStep.Location = new System.Drawing.Point(510, 133);
            this.txtAngularStep.Name = "txtAngularStep";
            this.txtAngularStep.Size = new System.Drawing.Size(100, 21);
            this.txtAngularStep.TabIndex = 2;
            this.txtAngularStep.Text = "auto";
            this.txtAngularStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(427, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "优化类型";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOptimizationType
            // 
            this.txtOptimizationType.Location = new System.Drawing.Point(510, 171);
            this.txtOptimizationType.Name = "txtOptimizationType";
            this.txtOptimizationType.Size = new System.Drawing.Size(100, 21);
            this.txtOptimizationType.TabIndex = 2;
            this.txtOptimizationType.Text = "auto";
            this.txtOptimizationType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(427, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "匹配指标";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMatchingIndex
            // 
            this.txtMatchingIndex.Location = new System.Drawing.Point(510, 209);
            this.txtMatchingIndex.Name = "txtMatchingIndex";
            this.txtMatchingIndex.Size = new System.Drawing.Size(100, 21);
            this.txtMatchingIndex.TabIndex = 2;
            this.txtMatchingIndex.Text = "use_polarity";
            this.txtMatchingIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(427, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "对比度阈值";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContrastThreshold
            // 
            this.txtContrastThreshold.Location = new System.Drawing.Point(510, 247);
            this.txtContrastThreshold.Name = "txtContrastThreshold";
            this.txtContrastThreshold.Size = new System.Drawing.Size(100, 21);
            this.txtContrastThreshold.TabIndex = 2;
            this.txtContrastThreshold.Text = "25";
            this.txtContrastThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(427, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "最小对比度";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMinimumContrast
            // 
            this.txtMinimumContrast.Location = new System.Drawing.Point(510, 285);
            this.txtMinimumContrast.Name = "txtMinimumContrast";
            this.txtMinimumContrast.Size = new System.Drawing.Size(100, 21);
            this.txtMinimumContrast.TabIndex = 2;
            this.txtMinimumContrast.Text = "40";
            this.txtMinimumContrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_createTemplate
            // 
            this.btn_createTemplate.Location = new System.Drawing.Point(420, 317);
            this.btn_createTemplate.Name = "btn_createTemplate";
            this.btn_createTemplate.Size = new System.Drawing.Size(91, 24);
            this.btn_createTemplate.TabIndex = 3;
            this.btn_createTemplate.Text = "创建模板";
            this.btn_createTemplate.UseVisualStyleBackColor = true;
            this.btn_createTemplate.Click += new System.EventHandler(this.btn_createTemplate_Click);
            // 
            // btn_createFinish
            // 
            this.btn_createFinish.Location = new System.Drawing.Point(517, 317);
            this.btn_createFinish.Name = "btn_createFinish";
            this.btn_createFinish.Size = new System.Drawing.Size(91, 24);
            this.btn_createFinish.TabIndex = 3;
            this.btn_createFinish.Text = "创建完成";
            this.btn_createFinish.UseVisualStyleBackColor = true;
            this.btn_createFinish.Click += new System.EventHandler(this.btn_createFinish_Click);
            // 
            // createModelFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 353);
            this.Controls.Add(this.btn_createFinish);
            this.Controls.Add(this.btn_createTemplate);
            this.Controls.Add(this.txtMinimumContrast);
            this.Controls.Add(this.txtContrastThreshold);
            this.Controls.Add(this.txtMatchingIndex);
            this.Controls.Add(this.txtOptimizationType);
            this.Controls.Add(this.txtAngularStep);
            this.Controls.Add(this.txtAngleRange);
            this.Controls.Add(this.txtStartAngle);
            this.Controls.Add(this.txtMincontrast);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myhc);
            this.Name = "createModelFrm";
            this.Text = "创建模板窗口";
            this.Load += new System.EventHandler(this.createModelFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VControl.MyHalconControl myhc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMincontrast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartAngle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAngleRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAngularStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOptimizationType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatchingIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContrastThreshold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinimumContrast;
        private System.Windows.Forms.Button btn_createTemplate;
        private System.Windows.Forms.Button btn_createFinish;
    }
}
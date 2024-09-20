
namespace halconCSharp2.VFrame
{
    partial class LoadImageFrm
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
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.btn_closewindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.Location = new System.Drawing.Point(12, 12);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(98, 31);
            this.btn_loadImage.TabIndex = 0;
            this.btn_loadImage.Text = "加载图片";
            this.btn_loadImage.UseVisualStyleBackColor = true;
            this.btn_loadImage.Click += new System.EventHandler(this.btn_loadImage_Click);
            // 
            // btn_closewindow
            // 
            this.btn_closewindow.Location = new System.Drawing.Point(129, 12);
            this.btn_closewindow.Name = "btn_closewindow";
            this.btn_closewindow.Size = new System.Drawing.Size(98, 31);
            this.btn_closewindow.TabIndex = 0;
            this.btn_closewindow.Text = "关闭窗口";
            this.btn_closewindow.UseVisualStyleBackColor = true;
            this.btn_closewindow.Click += new System.EventHandler(this.btn_closewindow_Click);
            // 
            // LoadImageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 55);
            this.Controls.Add(this.btn_closewindow);
            this.Controls.Add(this.btn_loadImage);
            this.Name = "LoadImageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadImageFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.Button btn_closewindow;
    }
}
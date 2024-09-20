
namespace halconCSharp2.VControl
{
    partial class FlowNode
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_LED = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_LED
            // 
            this.label_LED.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_LED.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_LED.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_LED.ForeColor = System.Drawing.Color.Red;
            this.label_LED.Location = new System.Drawing.Point(0, 0);
            this.label_LED.Name = "label_LED";
            this.label_LED.Size = new System.Drawing.Size(36, 33);
            this.label_LED.TabIndex = 0;
            this.label_LED.Text = "·";
            this.label_LED.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FlowNode_MouseDoubleClick);
            // 
            // title
            // 
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(36, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(161, 33);
            this.title.TabIndex = 1;
            this.title.Text = "加载图像";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FlowNode_MouseDoubleClick);
            // 
            // FlowNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.label_LED);
            this.Name = "FlowNode";
            this.Size = new System.Drawing.Size(197, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_LED;
        private System.Windows.Forms.Label title;
    }
}

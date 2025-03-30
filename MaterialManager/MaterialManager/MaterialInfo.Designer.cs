namespace MaterialManager
{
    partial class MaterialInfo
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.labelContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.Blue;
            this.labelTitle.Location = new System.Drawing.Point(12, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(543, 33);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "欢迎来到材料管理系统！当前时间：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTime.Location = new System.Drawing.Point(656, 46);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 36);
            this.labelTime.TabIndex = 1;
            // 
            // timerNow
            // 
            this.timerNow.Enabled = true;
            this.timerNow.Interval = 1000;
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelContent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelContent.Location = new System.Drawing.Point(561, 30);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(111, 33);
            this.labelContent.TabIndex = 2;
            this.labelContent.Text = "label1";
            // 
            // MaterialInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 919);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "MaterialInfo";
            this.Text = "MaterialInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.Label labelContent;
    }
}
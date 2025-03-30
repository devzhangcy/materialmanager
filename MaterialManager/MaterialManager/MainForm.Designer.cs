namespace MaterialManager
{
    partial class MainForm
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
            this.tabWindows = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabPurchase = new System.Windows.Forms.TabPage();
            this.tabMaterial = new System.Windows.Forms.TabPage();
            this.tabType = new System.Windows.Forms.TabPage();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.tabWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWindows
            // 
            this.tabWindows.Controls.Add(this.tabMain);
            this.tabWindows.Controls.Add(this.tabPurchase);
            this.tabWindows.Controls.Add(this.tabMaterial);
            this.tabWindows.Controls.Add(this.tabType);
            this.tabWindows.Controls.Add(this.tabSupplier);
            this.tabWindows.Controls.Add(this.tabUser);
            this.tabWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWindows.HotTrack = true;
            this.tabWindows.Location = new System.Drawing.Point(0, 0);
            this.tabWindows.Margin = new System.Windows.Forms.Padding(4);
            this.tabWindows.Name = "tabWindows";
            this.tabWindows.Padding = new System.Drawing.Point(12, 6);
            this.tabWindows.SelectedIndex = 0;
            this.tabWindows.Size = new System.Drawing.Size(1291, 969);
            this.tabWindows.TabIndex = 0;
            this.tabWindows.SelectedIndexChanged += new System.EventHandler(this.tabWindows_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Location = new System.Drawing.Point(4, 34);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(4);
            this.tabMain.Size = new System.Drawing.Size(1283, 931);
            this.tabMain.TabIndex = 0;
            this.tabMain.Tag = "MaterialManager.MaterialInfo";
            this.tabMain.Text = "主页";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabPurchase
            // 
            this.tabPurchase.Location = new System.Drawing.Point(4, 34);
            this.tabPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.Padding = new System.Windows.Forms.Padding(4);
            this.tabPurchase.Size = new System.Drawing.Size(1283, 931);
            this.tabPurchase.TabIndex = 1;
            this.tabPurchase.Tag = "MaterialManager.Purchase";
            this.tabPurchase.Text = "采购管理";
            this.tabPurchase.UseVisualStyleBackColor = true;
            // 
            // tabMaterial
            // 
            this.tabMaterial.Location = new System.Drawing.Point(4, 34);
            this.tabMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.tabMaterial.Name = "tabMaterial";
            this.tabMaterial.Padding = new System.Windows.Forms.Padding(4);
            this.tabMaterial.Size = new System.Drawing.Size(1283, 931);
            this.tabMaterial.TabIndex = 2;
            this.tabMaterial.Tag = "MaterialManager.Material";
            this.tabMaterial.Text = "库存管理";
            this.tabMaterial.UseVisualStyleBackColor = true;
            // 
            // tabType
            // 
            this.tabType.Location = new System.Drawing.Point(4, 34);
            this.tabType.Name = "tabType";
            this.tabType.Size = new System.Drawing.Size(1283, 931);
            this.tabType.TabIndex = 3;
            this.tabType.Tag = "MaterialManager.Type";
            this.tabType.Text = "种类管理";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // tabSupplier
            // 
            this.tabSupplier.Location = new System.Drawing.Point(4, 34);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Size = new System.Drawing.Size(1283, 931);
            this.tabSupplier.TabIndex = 4;
            this.tabSupplier.Tag = "MaterialManager.Supplier";
            this.tabSupplier.Text = "供应商管理";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // tabUser
            // 
            this.tabUser.Location = new System.Drawing.Point(4, 34);
            this.tabUser.Name = "tabUser";
            this.tabUser.Size = new System.Drawing.Size(1283, 931);
            this.tabUser.TabIndex = 5;
            this.tabUser.Tag = "MaterialManager.User";
            this.tabUser.Text = "用户管理";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 969);
            this.Controls.Add(this.tabWindows);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabWindows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabWindows;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabPurchase;
        private System.Windows.Forms.TabPage tabMaterial;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.TabPage tabUser;
    }
}


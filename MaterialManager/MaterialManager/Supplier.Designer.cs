namespace MaterialManager
{
    partial class Supplier
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbltype = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridSupplier = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textName);
            this.panelTop.Controls.Add(this.btnDel);
            this.panelTop.Controls.Add(this.btnEdit);
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.lbltype);
            this.panelTop.Controls.Add(this.btnQuery);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1261, 78);
            this.panelTop.TabIndex = 0;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(135, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(163, 28);
            this.textName.TabIndex = 22;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(1137, 22);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 34);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1015, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(893, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(12, 30);
            this.lbltype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(116, 18);
            this.lbltype.TabIndex = 16;
            this.lbltype.Text = "供应商名称：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(772, 22);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(112, 34);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridSupplier
            // 
            this.dataGridSupplier.AllowUserToAddRows = false;
            this.dataGridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.telphone,
            this.description,
            this.createtime});
            this.dataGridSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSupplier.Location = new System.Drawing.Point(0, 78);
            this.dataGridSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSupplier.Name = "dataGridSupplier";
            this.dataGridSupplier.RowHeadersWidth = 62;
            this.dataGridSupplier.RowTemplate.Height = 30;
            this.dataGridSupplier.Size = new System.Drawing.Size(1261, 841);
            this.dataGridSupplier.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "供应商名称";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "供应商地址";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.Width = 200;
            // 
            // telphone
            // 
            this.telphone.DataPropertyName = "telphone";
            this.telphone.HeaderText = "联系方式";
            this.telphone.MinimumWidth = 8;
            this.telphone.Name = "telphone";
            this.telphone.Width = 200;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "备注信息";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.Width = 400;
            // 
            // createtime
            // 
            this.createtime.DataPropertyName = "createtime";
            this.createtime.HeaderText = "创建时间";
            this.createtime.Name = "createtime";
            this.createtime.ReadOnly = true;
            this.createtime.Width = 200;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 919);
            this.Controls.Add(this.dataGridSupplier);
            this.Controls.Add(this.panelTop);
            this.Name = "Supplier";
            this.Text = "供应商管理";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dataGridSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn telphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
    }
}
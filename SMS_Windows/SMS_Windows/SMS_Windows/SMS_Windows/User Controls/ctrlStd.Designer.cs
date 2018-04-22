namespace SMS_Windows.User_Controls
{
    partial class ctrlStd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClsName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTempStd = new System.Windows.Forms.DataGridView();
            this.dgvStd = new System.Windows.Forms.DataGridView();
            this.StdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StandardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStd)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvTempStd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvStd, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 644);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(687, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 41);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtClsName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 57);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard Name:";
            // 
            // txtClsName
            // 
            this.txtClsName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClsName.Location = new System.Drawing.Point(249, 15);
            this.txtClsName.Name = "txtClsName";
            this.txtClsName.Size = new System.Drawing.Size(322, 26);
            this.txtClsName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Location = new System.Drawing.Point(577, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTempStd
            // 
            this.dgvTempStd.AllowUserToAddRows = false;
            this.dgvTempStd.BackgroundColor = System.Drawing.Color.White;
            this.dgvTempStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StdName});
            this.dgvTempStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTempStd.GridColor = System.Drawing.Color.Black;
            this.dgvTempStd.Location = new System.Drawing.Point(4, 68);
            this.dgvTempStd.Name = "dgvTempStd";
            this.dgvTempStd.RowTemplate.Height = 24;
            this.dgvTempStd.Size = new System.Drawing.Size(820, 249);
            this.dgvTempStd.TabIndex = 1;
            // 
            // dgvStd
            // 
            this.dgvStd.AllowUserToAddRows = false;
            this.dgvStd.AllowUserToDeleteRows = false;
            this.dgvStd.BackgroundColor = System.Drawing.Color.White;
            this.dgvStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StdId,
            this.StandardName});
            this.dgvStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStd.GridColor = System.Drawing.Color.Black;
            this.dgvStd.Location = new System.Drawing.Point(4, 388);
            this.dgvStd.Name = "dgvStd";
            this.dgvStd.ReadOnly = true;
            this.dgvStd.RowTemplate.Height = 24;
            this.dgvStd.Size = new System.Drawing.Size(820, 252);
            this.dgvStd.TabIndex = 2;
            this.dgvStd.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStd_RowHeaderMouseClick);
            // 
            // StdId
            // 
            this.StdId.DataPropertyName = "StdId";
            this.StdId.HeaderText = "Standard Id";
            this.StdId.Name = "StdId";
            this.StdId.Visible = false;
            // 
            // StandardName
            // 
            this.StandardName.DataPropertyName = "StdName";
            this.StandardName.HeaderText = "Standard Name";
            this.StandardName.Name = "StandardName";
            this.StandardName.ReadOnly = true;
            // 
            // StdName
            // 
            this.StdName.DataPropertyName = "StdName";
            this.StdName.HeaderText = "Standard Name";
            this.StdName.Name = "StdName";
            // 
            // ctrlStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlStd";
            this.Size = new System.Drawing.Size(828, 644);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClsName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTempStd;
        private System.Windows.Forms.DataGridView dgvStd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StandardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
    }
}

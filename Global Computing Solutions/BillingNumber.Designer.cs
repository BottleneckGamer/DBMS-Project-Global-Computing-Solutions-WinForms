
namespace Global_Computing_Solutions
{
    partial class BillingNumber
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
            this.billbtnspnl = new System.Windows.Forms.Panel();
            this.billAddbtn = new System.Windows.Forms.Button();
            this.billdelbtn = new System.Windows.Forms.Button();
            this.billUpbtn = new System.Windows.Forms.Button();
            this.billclosebtn = new System.Windows.Forms.Button();
            this.billdatapnl = new System.Windows.Forms.Panel();
            this.billdatagridview = new System.Windows.Forms.DataGridView();
            this.billdatalbl = new System.Windows.Forms.Label();
            this.gCSDevDataSet = new Global_Computing_Solutions.GCSDevDataSet();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.BillTableAdapter();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billbtnspnl.SuspendLayout();
            this.billdatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // billbtnspnl
            // 
            this.billbtnspnl.Controls.Add(this.billAddbtn);
            this.billbtnspnl.Controls.Add(this.billdelbtn);
            this.billbtnspnl.Controls.Add(this.billUpbtn);
            this.billbtnspnl.Controls.Add(this.billclosebtn);
            this.billbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.billbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.billbtnspnl.Name = "billbtnspnl";
            this.billbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.billbtnspnl.TabIndex = 2;
            // 
            // billAddbtn
            // 
            this.billAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.billAddbtn.Location = new System.Drawing.Point(384, 0);
            this.billAddbtn.Name = "billAddbtn";
            this.billAddbtn.Size = new System.Drawing.Size(75, 40);
            this.billAddbtn.TabIndex = 3;
            this.billAddbtn.Text = "Add";
            this.billAddbtn.UseVisualStyleBackColor = true;
            this.billAddbtn.Click += new System.EventHandler(this.billAddbtn_Click);
            // 
            // billdelbtn
            // 
            this.billdelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.billdelbtn.Location = new System.Drawing.Point(459, 0);
            this.billdelbtn.Name = "billdelbtn";
            this.billdelbtn.Size = new System.Drawing.Size(75, 40);
            this.billdelbtn.TabIndex = 2;
            this.billdelbtn.Text = "Delete";
            this.billdelbtn.UseVisualStyleBackColor = true;
            this.billdelbtn.Click += new System.EventHandler(this.billdelbtn_Click);
            // 
            // billUpbtn
            // 
            this.billUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.billUpbtn.Location = new System.Drawing.Point(534, 0);
            this.billUpbtn.Name = "billUpbtn";
            this.billUpbtn.Size = new System.Drawing.Size(75, 40);
            this.billUpbtn.TabIndex = 2;
            this.billUpbtn.Text = "Update";
            this.billUpbtn.UseVisualStyleBackColor = true;
            this.billUpbtn.Click += new System.EventHandler(this.billUpbtn_Click);
            // 
            // billclosebtn
            // 
            this.billclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.billclosebtn.Location = new System.Drawing.Point(609, 0);
            this.billclosebtn.Name = "billclosebtn";
            this.billclosebtn.Size = new System.Drawing.Size(75, 40);
            this.billclosebtn.TabIndex = 2;
            this.billclosebtn.Text = "Close";
            this.billclosebtn.UseVisualStyleBackColor = true;
            this.billclosebtn.Click += new System.EventHandler(this.billclosebtn_Click);
            // 
            // billdatapnl
            // 
            this.billdatapnl.Controls.Add(this.billdatagridview);
            this.billdatapnl.Controls.Add(this.billdatalbl);
            this.billdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billdatapnl.Location = new System.Drawing.Point(0, 0);
            this.billdatapnl.Name = "billdatapnl";
            this.billdatapnl.Size = new System.Drawing.Size(684, 511);
            this.billdatapnl.TabIndex = 3;
            // 
            // billdatagridview
            // 
            this.billdatagridview.AutoGenerateColumns = false;
            this.billdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.billdatagridview.DataSource = this.billBindingSource;
            this.billdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billdatagridview.Location = new System.Drawing.Point(0, 20);
            this.billdatagridview.Name = "billdatagridview";
            this.billdatagridview.Size = new System.Drawing.Size(684, 491);
            this.billdatagridview.TabIndex = 1;
            // 
            // billdatalbl
            // 
            this.billdatalbl.AutoSize = true;
            this.billdatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.billdatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billdatalbl.Location = new System.Drawing.Point(0, 0);
            this.billdatalbl.Name = "billdatalbl";
            this.billdatalbl.Size = new System.Drawing.Size(89, 20);
            this.billdatalbl.TabIndex = 0;
            this.billdatalbl.Text = "Billing Data";
            // 
            // gCSDevDataSet
            // 
            this.gCSDevDataSet.DataSetName = "GCSDevDataSet";
            this.gCSDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billDateDataGridViewTextBoxColumn
            // 
            this.billDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate";
            this.billDateDataGridViewTextBoxColumn.HeaderText = "BillDate";
            this.billDateDataGridViewTextBoxColumn.Name = "billDateDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // BillingNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.billbtnspnl);
            this.Controls.Add(this.billdatapnl);
            this.Name = "BillingNumber";
            this.Text = "BillingNumber";
            this.Load += new System.EventHandler(this.BillingNumber_Load);
            this.billbtnspnl.ResumeLayout(false);
            this.billdatapnl.ResumeLayout(false);
            this.billdatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel billbtnspnl;
        private System.Windows.Forms.Button billAddbtn;
        private System.Windows.Forms.Button billdelbtn;
        private System.Windows.Forms.Button billUpbtn;
        private System.Windows.Forms.Button billclosebtn;
        private System.Windows.Forms.Panel billdatapnl;
        private System.Windows.Forms.DataGridView billdatagridview;
        private System.Windows.Forms.Label billdatalbl;
        private GCSDevDataSet gCSDevDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private GCSDevDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    }
}
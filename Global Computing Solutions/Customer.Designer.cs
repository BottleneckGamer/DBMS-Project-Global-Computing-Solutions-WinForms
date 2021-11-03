
namespace Global_Computing_Solutions
{
    partial class Customer
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
            this.customerupbtn = new System.Windows.Forms.Button();
            this.customerclosebtn = new System.Windows.Forms.Button();
            this.customerdelbtn = new System.Windows.Forms.Button();
            this.customerlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            this.customerbtnpnl = new System.Windows.Forms.Panel();
            this.customeraddbtn = new System.Windows.Forms.Button();
            this.gCSDevDataSet = new Global_Computing_Solutions.GCSDevDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.CustomerTableAdapter();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.customerbtnpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerupbtn
            // 
            this.customerupbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.customerupbtn.Location = new System.Drawing.Point(534, 0);
            this.customerupbtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerupbtn.Name = "customerupbtn";
            this.customerupbtn.Size = new System.Drawing.Size(75, 40);
            this.customerupbtn.TabIndex = 17;
            this.customerupbtn.Text = "Update";
            this.customerupbtn.UseVisualStyleBackColor = true;
            this.customerupbtn.Click += new System.EventHandler(this.customerupbtn_Click);
            // 
            // customerclosebtn
            // 
            this.customerclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.customerclosebtn.Location = new System.Drawing.Point(609, 0);
            this.customerclosebtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerclosebtn.Name = "customerclosebtn";
            this.customerclosebtn.Size = new System.Drawing.Size(75, 40);
            this.customerclosebtn.TabIndex = 16;
            this.customerclosebtn.Text = "Close";
            this.customerclosebtn.UseVisualStyleBackColor = true;
            this.customerclosebtn.Click += new System.EventHandler(this.customerclosebtn_Click);
            // 
            // customerdelbtn
            // 
            this.customerdelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.customerdelbtn.Location = new System.Drawing.Point(459, 0);
            this.customerdelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerdelbtn.Name = "customerdelbtn";
            this.customerdelbtn.Size = new System.Drawing.Size(75, 40);
            this.customerdelbtn.TabIndex = 15;
            this.customerdelbtn.Text = "Delete";
            this.customerdelbtn.UseVisualStyleBackColor = true;
            this.customerdelbtn.Click += new System.EventHandler(this.customerdelbtn_Click);
            // 
            // customerlbl
            // 
            this.customerlbl.AutoSize = true;
            this.customerlbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.customerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerlbl.Location = new System.Drawing.Point(0, 0);
            this.customerlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerlbl.Name = "customerlbl";
            this.customerlbl.Size = new System.Drawing.Size(86, 20);
            this.customerlbl.TabIndex = 13;
            this.customerlbl.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CustomerDataGrid);
            this.panel1.Controls.Add(this.customerlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 511);
            this.panel1.TabIndex = 18;
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AutoGenerateColumns = false;
            this.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.regionIdDataGridViewTextBoxColumn});
            this.CustomerDataGrid.DataSource = this.customerBindingSource;
            this.CustomerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDataGrid.Location = new System.Drawing.Point(0, 20);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.Size = new System.Drawing.Size(684, 491);
            this.CustomerDataGrid.TabIndex = 14;
            // 
            // customerbtnpnl
            // 
            this.customerbtnpnl.Controls.Add(this.customeraddbtn);
            this.customerbtnpnl.Controls.Add(this.customerdelbtn);
            this.customerbtnpnl.Controls.Add(this.customerupbtn);
            this.customerbtnpnl.Controls.Add(this.customerclosebtn);
            this.customerbtnpnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerbtnpnl.Location = new System.Drawing.Point(0, 471);
            this.customerbtnpnl.Name = "customerbtnpnl";
            this.customerbtnpnl.Size = new System.Drawing.Size(684, 40);
            this.customerbtnpnl.TabIndex = 19;
            // 
            // customeraddbtn
            // 
            this.customeraddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.customeraddbtn.Location = new System.Drawing.Point(384, 0);
            this.customeraddbtn.Name = "customeraddbtn";
            this.customeraddbtn.Size = new System.Drawing.Size(75, 40);
            this.customeraddbtn.TabIndex = 18;
            this.customeraddbtn.Text = "Add";
            this.customeraddbtn.UseVisualStyleBackColor = true;
            this.customeraddbtn.Click += new System.EventHandler(this.customeraddbtn_Click);
            // 
            // gCSDevDataSet
            // 
            this.gCSDevDataSet.DataSetName = "GCSDevDataSet";
            this.gCSDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // regionIdDataGridViewTextBoxColumn
            // 
            this.regionIdDataGridViewTextBoxColumn.DataPropertyName = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.HeaderText = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.Name = "regionIdDataGridViewTextBoxColumn";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.customerbtnpnl);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.customerbtnpnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerupbtn;
        private System.Windows.Forms.Button customerclosebtn;
        private System.Windows.Forms.Button customerdelbtn;
        private System.Windows.Forms.Label customerlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel customerbtnpnl;
        private System.Windows.Forms.Button customeraddbtn;
        private System.Windows.Forms.DataGridView CustomerDataGrid;
        private GCSDevDataSet gCSDevDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private GCSDevDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionIdDataGridViewTextBoxColumn;
    }
}

namespace Global_Computing_Solutions
{
    partial class EmployeeForm
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
            this.empbtnspnl = new System.Windows.Forms.Panel();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Edelbtn = new System.Windows.Forms.Button();
            this.EUpbtn = new System.Windows.Forms.Button();
            this.eclosebtn = new System.Windows.Forms.Button();
            this.empdatapnl = new System.Windows.Forms.Panel();
            this.edatagridview = new System.Windows.Forms.DataGridView();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfHireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gCSDevDataSet = new Global_Computing_Solutions.GCSDevDataSet();
            this.empdatalbl = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.EmployeeTableAdapter();
            this.empbtnspnl.SuspendLayout();
            this.empdatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // empbtnspnl
            // 
            this.empbtnspnl.Controls.Add(this.Addbtn);
            this.empbtnspnl.Controls.Add(this.Edelbtn);
            this.empbtnspnl.Controls.Add(this.EUpbtn);
            this.empbtnspnl.Controls.Add(this.eclosebtn);
            this.empbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.empbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.empbtnspnl.Name = "empbtnspnl";
            this.empbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.empbtnspnl.TabIndex = 0;
            // 
            // Addbtn
            // 
            this.Addbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Addbtn.Location = new System.Drawing.Point(384, 0);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 40);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Edelbtn
            // 
            this.Edelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Edelbtn.Location = new System.Drawing.Point(459, 0);
            this.Edelbtn.Name = "Edelbtn";
            this.Edelbtn.Size = new System.Drawing.Size(75, 40);
            this.Edelbtn.TabIndex = 2;
            this.Edelbtn.Text = "Delete";
            this.Edelbtn.UseVisualStyleBackColor = true;
            this.Edelbtn.Click += new System.EventHandler(this.Edelbtn_Click);
            // 
            // EUpbtn
            // 
            this.EUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.EUpbtn.Location = new System.Drawing.Point(534, 0);
            this.EUpbtn.Name = "EUpbtn";
            this.EUpbtn.Size = new System.Drawing.Size(75, 40);
            this.EUpbtn.TabIndex = 2;
            this.EUpbtn.Text = "Update";
            this.EUpbtn.UseVisualStyleBackColor = true;
            this.EUpbtn.Click += new System.EventHandler(this.EUpbtn_Click);
            // 
            // eclosebtn
            // 
            this.eclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.eclosebtn.Location = new System.Drawing.Point(609, 0);
            this.eclosebtn.Name = "eclosebtn";
            this.eclosebtn.Size = new System.Drawing.Size(75, 40);
            this.eclosebtn.TabIndex = 2;
            this.eclosebtn.Text = "Close";
            this.eclosebtn.UseVisualStyleBackColor = true;
            this.eclosebtn.Click += new System.EventHandler(this.eclosebtn_Click);
            // 
            // empdatapnl
            // 
            this.empdatapnl.Controls.Add(this.edatagridview);
            this.empdatapnl.Controls.Add(this.empdatalbl);
            this.empdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empdatapnl.Location = new System.Drawing.Point(0, 0);
            this.empdatapnl.Name = "empdatapnl";
            this.empdatapnl.Size = new System.Drawing.Size(684, 471);
            this.empdatapnl.TabIndex = 1;
            // 
            // edatagridview
            // 
            this.edatagridview.AutoGenerateColumns = false;
            this.edatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.dateOfHireDataGridViewTextBoxColumn,
            this.regionIdDataGridViewTextBoxColumn,
            this.managerIdDataGridViewTextBoxColumn});
            this.edatagridview.DataSource = this.employeeBindingSource;
            this.edatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edatagridview.Location = new System.Drawing.Point(0, 20);
            this.edatagridview.Name = "edatagridview";
            this.edatagridview.Size = new System.Drawing.Size(684, 451);
            this.edatagridview.TabIndex = 1;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // dateOfHireDataGridViewTextBoxColumn
            // 
            this.dateOfHireDataGridViewTextBoxColumn.DataPropertyName = "DateOfHire";
            this.dateOfHireDataGridViewTextBoxColumn.HeaderText = "DateOfHire";
            this.dateOfHireDataGridViewTextBoxColumn.Name = "dateOfHireDataGridViewTextBoxColumn";
            // 
            // regionIdDataGridViewTextBoxColumn
            // 
            this.regionIdDataGridViewTextBoxColumn.DataPropertyName = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.HeaderText = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.Name = "regionIdDataGridViewTextBoxColumn";
            // 
            // managerIdDataGridViewTextBoxColumn
            // 
            this.managerIdDataGridViewTextBoxColumn.DataPropertyName = "ManagerId";
            this.managerIdDataGridViewTextBoxColumn.HeaderText = "ManagerId";
            this.managerIdDataGridViewTextBoxColumn.Name = "managerIdDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // gCSDevDataSet
            // 
            this.gCSDevDataSet.DataSetName = "GCSDevDataSet";
            this.gCSDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empdatalbl
            // 
            this.empdatalbl.AutoSize = true;
            this.empdatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.empdatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdatalbl.Location = new System.Drawing.Point(0, 0);
            this.empdatalbl.Name = "empdatalbl";
            this.empdatalbl.Size = new System.Drawing.Size(118, 20);
            this.empdatalbl.TabIndex = 0;
            this.empdatalbl.Text = "Employee Data";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.empdatapnl);
            this.Controls.Add(this.empbtnspnl);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.empbtnspnl.ResumeLayout(false);
            this.empdatapnl.ResumeLayout(false);
            this.empdatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel empbtnspnl;
        private System.Windows.Forms.Panel empdatapnl;
        private System.Windows.Forms.DataGridView edatagridview;
        private System.Windows.Forms.Label empdatalbl;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Edelbtn;
        private System.Windows.Forms.Button EUpbtn;
        private System.Windows.Forms.Button eclosebtn;
        private GCSDevDataSet gCSDevDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GCSDevDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfHireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIdDataGridViewTextBoxColumn;
    }
}
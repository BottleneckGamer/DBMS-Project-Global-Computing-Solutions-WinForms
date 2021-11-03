
namespace Global_Computing_Solutions
{
    partial class AddEmployee
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
            this.addemppnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regempbtn = new System.Windows.Forms.Button();
            this.manageassignpnl = new System.Windows.Forms.Panel();
            this.managercmbox = new System.Windows.Forms.ComboBox();
            this.assignmanagerlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addregionbtn = new System.Windows.Forms.Button();
            this.regioncmbox = new System.Windows.Forms.ComboBox();
            this.regionlbl = new System.Windows.Forms.Label();
            this.dateofhirepnl = new System.Windows.Forms.Panel();
            this.dateofhirepicker = new System.Windows.Forms.DateTimePicker();
            this.dateofhirelbl = new System.Windows.Forms.Label();
            this.lastnamepnl = new System.Windows.Forms.Panel();
            this.lastnametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emiddlenamepnl = new System.Windows.Forms.Panel();
            this.midnametxbox = new System.Windows.Forms.TextBox();
            this.emidnamelbl = new System.Windows.Forms.Label();
            this.efirstnamepnl = new System.Windows.Forms.Panel();
            this.efirstnametxtbox = new System.Windows.Forms.TextBox();
            this.efirstnamelbl = new System.Windows.Forms.Label();
            this.gCSDevDataSet = new Global_Computing_Solutions.GCSDevDataSet();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.RegionTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.EmployeeTableAdapter();
            this.addemppnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.manageassignpnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dateofhirepnl.SuspendLayout();
            this.lastnamepnl.SuspendLayout();
            this.emiddlenamepnl.SuspendLayout();
            this.efirstnamepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addemppnl
            // 
            this.addemppnl.Controls.Add(this.panel2);
            this.addemppnl.Controls.Add(this.manageassignpnl);
            this.addemppnl.Controls.Add(this.panel1);
            this.addemppnl.Controls.Add(this.dateofhirepnl);
            this.addemppnl.Controls.Add(this.lastnamepnl);
            this.addemppnl.Controls.Add(this.emiddlenamepnl);
            this.addemppnl.Controls.Add(this.efirstnamepnl);
            this.addemppnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.addemppnl.Location = new System.Drawing.Point(0, 0);
            this.addemppnl.Name = "addemppnl";
            this.addemppnl.Size = new System.Drawing.Size(404, 469);
            this.addemppnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.regempbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 65);
            this.panel2.TabIndex = 6;
            // 
            // regempbtn
            // 
            this.regempbtn.Location = new System.Drawing.Point(54, 22);
            this.regempbtn.Name = "regempbtn";
            this.regempbtn.Size = new System.Drawing.Size(304, 40);
            this.regempbtn.TabIndex = 0;
            this.regempbtn.Text = "Register Employee";
            this.regempbtn.UseVisualStyleBackColor = true;
            this.regempbtn.Click += new System.EventHandler(this.regempbtn_Click);
            // 
            // manageassignpnl
            // 
            this.manageassignpnl.Controls.Add(this.managercmbox);
            this.manageassignpnl.Controls.Add(this.assignmanagerlbl);
            this.manageassignpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageassignpnl.Location = new System.Drawing.Point(0, 305);
            this.manageassignpnl.Name = "manageassignpnl";
            this.manageassignpnl.Size = new System.Drawing.Size(404, 61);
            this.manageassignpnl.TabIndex = 5;
            // 
            // managercmbox
            // 
            this.managercmbox.DataSource = this.employeeBindingSource;
            this.managercmbox.DisplayMember = "EmployeeId";
            this.managercmbox.FormattingEnabled = true;
            this.managercmbox.Location = new System.Drawing.Point(125, 20);
            this.managercmbox.Name = "managercmbox";
            this.managercmbox.Size = new System.Drawing.Size(121, 21);
            this.managercmbox.TabIndex = 1;
            this.managercmbox.ValueMember = "LastName";
            // 
            // assignmanagerlbl
            // 
            this.assignmanagerlbl.AutoSize = true;
            this.assignmanagerlbl.Location = new System.Drawing.Point(12, 28);
            this.assignmanagerlbl.Name = "assignmanagerlbl";
            this.assignmanagerlbl.Size = new System.Drawing.Size(95, 13);
            this.assignmanagerlbl.TabIndex = 0;
            this.assignmanagerlbl.Text = "Assigned Manager";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addregionbtn);
            this.panel1.Controls.Add(this.regioncmbox);
            this.panel1.Controls.Add(this.regionlbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 61);
            this.panel1.TabIndex = 4;
            // 
            // addregionbtn
            // 
            this.addregionbtn.Location = new System.Drawing.Point(268, 9);
            this.addregionbtn.Name = "addregionbtn";
            this.addregionbtn.Size = new System.Drawing.Size(75, 40);
            this.addregionbtn.TabIndex = 2;
            this.addregionbtn.Text = "Add Region";
            this.addregionbtn.UseVisualStyleBackColor = true;
            this.addregionbtn.Click += new System.EventHandler(this.addregionbtn_Click);
            // 
            // regioncmbox
            // 
            this.regioncmbox.DataSource = this.regionBindingSource;
            this.regioncmbox.DisplayMember = "RegionId";
            this.regioncmbox.FormattingEnabled = true;
            this.regioncmbox.Location = new System.Drawing.Point(125, 20);
            this.regioncmbox.Name = "regioncmbox";
            this.regioncmbox.Size = new System.Drawing.Size(121, 21);
            this.regioncmbox.TabIndex = 1;
            this.regioncmbox.ValueMember = "Name";
            // 
            // regionlbl
            // 
            this.regionlbl.AutoSize = true;
            this.regionlbl.Location = new System.Drawing.Point(12, 28);
            this.regionlbl.Name = "regionlbl";
            this.regionlbl.Size = new System.Drawing.Size(41, 13);
            this.regionlbl.TabIndex = 0;
            this.regionlbl.Text = "Region";
            // 
            // dateofhirepnl
            // 
            this.dateofhirepnl.Controls.Add(this.dateofhirepicker);
            this.dateofhirepnl.Controls.Add(this.dateofhirelbl);
            this.dateofhirepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateofhirepnl.Location = new System.Drawing.Point(0, 183);
            this.dateofhirepnl.Name = "dateofhirepnl";
            this.dateofhirepnl.Size = new System.Drawing.Size(404, 61);
            this.dateofhirepnl.TabIndex = 3;
            // 
            // dateofhirepicker
            // 
            this.dateofhirepicker.Location = new System.Drawing.Point(125, 22);
            this.dateofhirepicker.Name = "dateofhirepicker";
            this.dateofhirepicker.Size = new System.Drawing.Size(208, 20);
            this.dateofhirepicker.TabIndex = 1;
            // 
            // dateofhirelbl
            // 
            this.dateofhirelbl.AutoSize = true;
            this.dateofhirelbl.Location = new System.Drawing.Point(12, 28);
            this.dateofhirelbl.Name = "dateofhirelbl";
            this.dateofhirelbl.Size = new System.Drawing.Size(64, 13);
            this.dateofhirelbl.TabIndex = 0;
            this.dateofhirelbl.Text = "Date of Hire";
            // 
            // lastnamepnl
            // 
            this.lastnamepnl.Controls.Add(this.lastnametxtbox);
            this.lastnamepnl.Controls.Add(this.label1);
            this.lastnamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lastnamepnl.Location = new System.Drawing.Point(0, 122);
            this.lastnamepnl.Name = "lastnamepnl";
            this.lastnamepnl.Size = new System.Drawing.Size(404, 61);
            this.lastnamepnl.TabIndex = 2;
            // 
            // lastnametxtbox
            // 
            this.lastnametxtbox.Location = new System.Drawing.Point(125, 21);
            this.lastnametxtbox.Name = "lastnametxtbox";
            this.lastnametxtbox.Size = new System.Drawing.Size(170, 20);
            this.lastnametxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Last Name";
            // 
            // emiddlenamepnl
            // 
            this.emiddlenamepnl.Controls.Add(this.midnametxbox);
            this.emiddlenamepnl.Controls.Add(this.emidnamelbl);
            this.emiddlenamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emiddlenamepnl.Location = new System.Drawing.Point(0, 61);
            this.emiddlenamepnl.Name = "emiddlenamepnl";
            this.emiddlenamepnl.Size = new System.Drawing.Size(404, 61);
            this.emiddlenamepnl.TabIndex = 1;
            // 
            // midnametxbox
            // 
            this.midnametxbox.Location = new System.Drawing.Point(125, 25);
            this.midnametxbox.Name = "midnametxbox";
            this.midnametxbox.Size = new System.Drawing.Size(170, 20);
            this.midnametxbox.TabIndex = 3;
            // 
            // emidnamelbl
            // 
            this.emidnamelbl.AutoSize = true;
            this.emidnamelbl.Location = new System.Drawing.Point(12, 28);
            this.emidnamelbl.Name = "emidnamelbl";
            this.emidnamelbl.Size = new System.Drawing.Size(69, 13);
            this.emidnamelbl.TabIndex = 2;
            this.emidnamelbl.Text = "Middle Name";
            // 
            // efirstnamepnl
            // 
            this.efirstnamepnl.Controls.Add(this.efirstnametxtbox);
            this.efirstnamepnl.Controls.Add(this.efirstnamelbl);
            this.efirstnamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.efirstnamepnl.Location = new System.Drawing.Point(0, 0);
            this.efirstnamepnl.Name = "efirstnamepnl";
            this.efirstnamepnl.Size = new System.Drawing.Size(404, 61);
            this.efirstnamepnl.TabIndex = 0;
            // 
            // efirstnametxtbox
            // 
            this.efirstnametxtbox.Location = new System.Drawing.Point(125, 28);
            this.efirstnametxtbox.Name = "efirstnametxtbox";
            this.efirstnametxtbox.Size = new System.Drawing.Size(170, 20);
            this.efirstnametxtbox.TabIndex = 1;
            // 
            // efirstnamelbl
            // 
            this.efirstnamelbl.AutoSize = true;
            this.efirstnamelbl.Location = new System.Drawing.Point(12, 28);
            this.efirstnamelbl.Name = "efirstnamelbl";
            this.efirstnamelbl.Size = new System.Drawing.Size(57, 13);
            this.efirstnamelbl.TabIndex = 1;
            this.efirstnamelbl.Text = "First Name";
            // 
            // gCSDevDataSet
            // 
            this.gCSDevDataSet.DataSetName = "GCSDevDataSet";
            this.gCSDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 469);
            this.Controls.Add(this.addemppnl);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.addemppnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.manageassignpnl.ResumeLayout(false);
            this.manageassignpnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dateofhirepnl.ResumeLayout(false);
            this.dateofhirepnl.PerformLayout();
            this.lastnamepnl.ResumeLayout(false);
            this.lastnamepnl.PerformLayout();
            this.emiddlenamepnl.ResumeLayout(false);
            this.emiddlenamepnl.PerformLayout();
            this.efirstnamepnl.ResumeLayout(false);
            this.efirstnamepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addemppnl;
        private System.Windows.Forms.Panel dateofhirepnl;
        private System.Windows.Forms.DateTimePicker dateofhirepicker;
        private System.Windows.Forms.Label dateofhirelbl;
        private System.Windows.Forms.Panel lastnamepnl;
        private System.Windows.Forms.TextBox lastnametxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel emiddlenamepnl;
        private System.Windows.Forms.TextBox midnametxbox;
        private System.Windows.Forms.Label emidnamelbl;
        private System.Windows.Forms.Panel efirstnamepnl;
        private System.Windows.Forms.TextBox efirstnametxtbox;
        private System.Windows.Forms.Label efirstnamelbl;
        private System.Windows.Forms.Panel manageassignpnl;
        private System.Windows.Forms.ComboBox managercmbox;
        private System.Windows.Forms.Label assignmanagerlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addregionbtn;
        private System.Windows.Forms.ComboBox regioncmbox;
        private System.Windows.Forms.Label regionlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button regempbtn;
        private GCSDevDataSet gCSDevDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private GCSDevDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private GCSDevDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}
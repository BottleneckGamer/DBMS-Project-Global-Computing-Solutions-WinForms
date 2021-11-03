
namespace Global_Computing_Solutions
{
    partial class Region
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
            this.regdatapnl = new System.Windows.Forms.Panel();
            this.regdatagridview = new System.Windows.Forms.DataGridView();
            this.regionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gCSDevDataSet = new Global_Computing_Solutions.GCSDevDataSet();
            this.regdatalbl = new System.Windows.Forms.Label();
            this.regbtnspnl = new System.Windows.Forms.Panel();
            this.regAddbtn = new System.Windows.Forms.Button();
            this.regdelbtn = new System.Windows.Forms.Button();
            this.rUpbtn = new System.Windows.Forms.Button();
            this.rclosebtn = new System.Windows.Forms.Button();
            this.regionTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.RegionTableAdapter();
            this.regdatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regdatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).BeginInit();
            this.regbtnspnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // regdatapnl
            // 
            this.regdatapnl.Controls.Add(this.regdatagridview);
            this.regdatapnl.Controls.Add(this.regdatalbl);
            this.regdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regdatapnl.Location = new System.Drawing.Point(0, 0);
            this.regdatapnl.Name = "regdatapnl";
            this.regdatapnl.Size = new System.Drawing.Size(684, 471);
            this.regdatapnl.TabIndex = 3;
            // 
            // regdatagridview
            // 
            this.regdatagridview.AutoGenerateColumns = false;
            this.regdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.regdatagridview.DataSource = this.regionBindingSource;
            this.regdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regdatagridview.Location = new System.Drawing.Point(0, 20);
            this.regdatagridview.Name = "regdatagridview";
            this.regdatagridview.Size = new System.Drawing.Size(684, 451);
            this.regdatagridview.TabIndex = 1;
            // 
            // regionIdDataGridViewTextBoxColumn
            // 
            this.regionIdDataGridViewTextBoxColumn.DataPropertyName = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.HeaderText = "RegionId";
            this.regionIdDataGridViewTextBoxColumn.Name = "regionIdDataGridViewTextBoxColumn";
            this.regionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "Region";
            this.regionBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // gCSDevDataSet
            // 
            this.gCSDevDataSet.DataSetName = "GCSDevDataSet";
            this.gCSDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regdatalbl
            // 
            this.regdatalbl.AutoSize = true;
            this.regdatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.regdatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regdatalbl.Location = new System.Drawing.Point(0, 0);
            this.regdatalbl.Name = "regdatalbl";
            this.regdatalbl.Size = new System.Drawing.Size(99, 20);
            this.regdatalbl.TabIndex = 0;
            this.regdatalbl.Text = "Region Data";
            // 
            // regbtnspnl
            // 
            this.regbtnspnl.Controls.Add(this.regAddbtn);
            this.regbtnspnl.Controls.Add(this.regdelbtn);
            this.regbtnspnl.Controls.Add(this.rUpbtn);
            this.regbtnspnl.Controls.Add(this.rclosebtn);
            this.regbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.regbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.regbtnspnl.Name = "regbtnspnl";
            this.regbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.regbtnspnl.TabIndex = 2;
            // 
            // regAddbtn
            // 
            this.regAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.regAddbtn.Location = new System.Drawing.Point(384, 0);
            this.regAddbtn.Name = "regAddbtn";
            this.regAddbtn.Size = new System.Drawing.Size(75, 40);
            this.regAddbtn.TabIndex = 3;
            this.regAddbtn.Text = "Add";
            this.regAddbtn.UseVisualStyleBackColor = true;
            this.regAddbtn.Click += new System.EventHandler(this.regAddbtn_Click);
            // 
            // regdelbtn
            // 
            this.regdelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.regdelbtn.Location = new System.Drawing.Point(459, 0);
            this.regdelbtn.Name = "regdelbtn";
            this.regdelbtn.Size = new System.Drawing.Size(75, 40);
            this.regdelbtn.TabIndex = 2;
            this.regdelbtn.Text = "Delete";
            this.regdelbtn.UseVisualStyleBackColor = true;
            this.regdelbtn.Click += new System.EventHandler(this.regdelbtn_Click);
            // 
            // rUpbtn
            // 
            this.rUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rUpbtn.Location = new System.Drawing.Point(534, 0);
            this.rUpbtn.Name = "rUpbtn";
            this.rUpbtn.Size = new System.Drawing.Size(75, 40);
            this.rUpbtn.TabIndex = 2;
            this.rUpbtn.Text = "Update";
            this.rUpbtn.UseVisualStyleBackColor = true;
            this.rUpbtn.Click += new System.EventHandler(this.rUpbtn_Click);
            // 
            // rclosebtn
            // 
            this.rclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rclosebtn.Location = new System.Drawing.Point(609, 0);
            this.rclosebtn.Name = "rclosebtn";
            this.rclosebtn.Size = new System.Drawing.Size(75, 40);
            this.rclosebtn.TabIndex = 2;
            this.rclosebtn.Text = "Close";
            this.rclosebtn.UseVisualStyleBackColor = true;
            this.rclosebtn.Click += new System.EventHandler(this.rclosebtn_Click);
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.regdatapnl);
            this.Controls.Add(this.regbtnspnl);
            this.Name = "Region";
            this.Text = "Region";
            this.Load += new System.EventHandler(this.Region_Load);
            this.regdatapnl.ResumeLayout(false);
            this.regdatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regdatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).EndInit();
            this.regbtnspnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regdatapnl;
        private System.Windows.Forms.DataGridView regdatagridview;
        private System.Windows.Forms.Label regdatalbl;
        private System.Windows.Forms.Panel regbtnspnl;
        private System.Windows.Forms.Button regAddbtn;
        private System.Windows.Forms.Button regdelbtn;
        private System.Windows.Forms.Button rUpbtn;
        private System.Windows.Forms.Button rclosebtn;
        private GCSDevDataSet gCSDevDataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private GCSDevDataSetTableAdapters.RegionTableAdapter regionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
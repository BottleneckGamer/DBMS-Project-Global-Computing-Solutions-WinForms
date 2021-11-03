
namespace Global_Computing_Solutions
{
    partial class Skills
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
            this.skilldatalbl = new System.Windows.Forms.Label();
            this.skillAddbtn = new System.Windows.Forms.Button();
            this.skillbtnspnl = new System.Windows.Forms.Panel();
            this.skilldelbtn = new System.Windows.Forms.Button();
            this.skillUpbtn = new System.Windows.Forms.Button();
            this.skillclosebtn = new System.Windows.Forms.Button();
            this.skilldatapnl = new System.Windows.Forms.Panel();
            this.skilldatagridview = new System.Windows.Forms.DataGridView();
            this.gCSDevDataSet = new Global_Computing_Solutions.GCSDevDataSet();
            this.skillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skillTableAdapter = new Global_Computing_Solutions.GCSDevDataSetTableAdapters.SkillTableAdapter();
            this.skillIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateOfPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillbtnspnl.SuspendLayout();
            this.skilldatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skilldatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skilldatalbl
            // 
            this.skilldatalbl.AutoSize = true;
            this.skilldatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.skilldatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skilldatalbl.Location = new System.Drawing.Point(0, 0);
            this.skilldatalbl.Name = "skilldatalbl";
            this.skilldatalbl.Size = new System.Drawing.Size(84, 20);
            this.skilldatalbl.TabIndex = 0;
            this.skilldatalbl.Text = "Skills Data";
            // 
            // skillAddbtn
            // 
            this.skillAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.skillAddbtn.Location = new System.Drawing.Point(384, 0);
            this.skillAddbtn.Name = "skillAddbtn";
            this.skillAddbtn.Size = new System.Drawing.Size(75, 40);
            this.skillAddbtn.TabIndex = 3;
            this.skillAddbtn.Text = "Add";
            this.skillAddbtn.UseVisualStyleBackColor = true;
            this.skillAddbtn.Click += new System.EventHandler(this.skillAddbtn_Click);
            // 
            // skillbtnspnl
            // 
            this.skillbtnspnl.Controls.Add(this.skillAddbtn);
            this.skillbtnspnl.Controls.Add(this.skilldelbtn);
            this.skillbtnspnl.Controls.Add(this.skillUpbtn);
            this.skillbtnspnl.Controls.Add(this.skillclosebtn);
            this.skillbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skillbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.skillbtnspnl.Name = "skillbtnspnl";
            this.skillbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.skillbtnspnl.TabIndex = 6;
            // 
            // skilldelbtn
            // 
            this.skilldelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.skilldelbtn.Location = new System.Drawing.Point(459, 0);
            this.skilldelbtn.Name = "skilldelbtn";
            this.skilldelbtn.Size = new System.Drawing.Size(75, 40);
            this.skilldelbtn.TabIndex = 2;
            this.skilldelbtn.Text = "Delete";
            this.skilldelbtn.UseVisualStyleBackColor = true;
            this.skilldelbtn.Click += new System.EventHandler(this.skilldelbtn_Click);
            // 
            // skillUpbtn
            // 
            this.skillUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.skillUpbtn.Location = new System.Drawing.Point(534, 0);
            this.skillUpbtn.Name = "skillUpbtn";
            this.skillUpbtn.Size = new System.Drawing.Size(75, 40);
            this.skillUpbtn.TabIndex = 2;
            this.skillUpbtn.Text = "Update";
            this.skillUpbtn.UseVisualStyleBackColor = true;
            this.skillUpbtn.Click += new System.EventHandler(this.skillUpbtn_Click);
            // 
            // skillclosebtn
            // 
            this.skillclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.skillclosebtn.Location = new System.Drawing.Point(609, 0);
            this.skillclosebtn.Name = "skillclosebtn";
            this.skillclosebtn.Size = new System.Drawing.Size(75, 40);
            this.skillclosebtn.TabIndex = 2;
            this.skillclosebtn.Text = "Close";
            this.skillclosebtn.UseVisualStyleBackColor = true;
            this.skillclosebtn.Click += new System.EventHandler(this.skillclosebtn_Click);
            // 
            // skilldatapnl
            // 
            this.skilldatapnl.Controls.Add(this.skilldatagridview);
            this.skilldatapnl.Controls.Add(this.skilldatalbl);
            this.skilldatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skilldatapnl.Location = new System.Drawing.Point(0, 0);
            this.skilldatapnl.Name = "skilldatapnl";
            this.skilldatapnl.Size = new System.Drawing.Size(684, 511);
            this.skilldatapnl.TabIndex = 7;
            // 
            // skilldatagridview
            // 
            this.skilldatagridview.AutoGenerateColumns = false;
            this.skilldatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skilldatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rateOfPayDataGridViewTextBoxColumn});
            this.skilldatagridview.DataSource = this.skillBindingSource;
            this.skilldatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skilldatagridview.Location = new System.Drawing.Point(0, 20);
            this.skilldatagridview.Name = "skilldatagridview";
            this.skilldatagridview.Size = new System.Drawing.Size(684, 491);
            this.skilldatagridview.TabIndex = 1;
            // 
            // gCSDevDataSet
            // 
            this.gCSDevDataSet.DataSetName = "GCSDevDataSet";
            this.gCSDevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // skillBindingSource
            // 
            this.skillBindingSource.DataMember = "Skill";
            this.skillBindingSource.DataSource = this.gCSDevDataSet;
            // 
            // skillTableAdapter
            // 
            this.skillTableAdapter.ClearBeforeFill = true;
            // 
            // skillIdDataGridViewTextBoxColumn
            // 
            this.skillIdDataGridViewTextBoxColumn.DataPropertyName = "SkillId";
            this.skillIdDataGridViewTextBoxColumn.HeaderText = "SkillId";
            this.skillIdDataGridViewTextBoxColumn.Name = "skillIdDataGridViewTextBoxColumn";
            this.skillIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rateOfPayDataGridViewTextBoxColumn
            // 
            this.rateOfPayDataGridViewTextBoxColumn.DataPropertyName = "RateOfPay";
            this.rateOfPayDataGridViewTextBoxColumn.HeaderText = "RateOfPay";
            this.rateOfPayDataGridViewTextBoxColumn.Name = "rateOfPayDataGridViewTextBoxColumn";
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.skillbtnspnl);
            this.Controls.Add(this.skilldatapnl);
            this.Name = "Skills";
            this.Text = "Skills";
            this.Load += new System.EventHandler(this.Skills_Load);
            this.skillbtnspnl.ResumeLayout(false);
            this.skilldatapnl.ResumeLayout(false);
            this.skilldatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skilldatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCSDevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label skilldatalbl;
        private System.Windows.Forms.Button skillAddbtn;
        private System.Windows.Forms.Panel skillbtnspnl;
        private System.Windows.Forms.Button skilldelbtn;
        private System.Windows.Forms.Button skillUpbtn;
        private System.Windows.Forms.Button skillclosebtn;
        private System.Windows.Forms.Panel skilldatapnl;
        private System.Windows.Forms.DataGridView skilldatagridview;
        private GCSDevDataSet gCSDevDataSet;
        private System.Windows.Forms.BindingSource skillBindingSource;
        private GCSDevDataSetTableAdapters.SkillTableAdapter skillTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateOfPayDataGridViewTextBoxColumn;
    }
}
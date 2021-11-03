
namespace Global_Computing_Solutions
{
    partial class Assignment
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
            this.assAddbtn = new System.Windows.Forms.Button();
            this.assdatapnl = new System.Windows.Forms.Panel();
            this.adatagridview = new System.Windows.Forms.DataGridView();
            this.assigndatalbl = new System.Windows.Forms.Label();
            this.assbtnspnl = new System.Windows.Forms.Panel();
            this.assdelbtn = new System.Windows.Forms.Button();
            this.assUpbtn = new System.Windows.Forms.Button();
            this.assclosebtn = new System.Windows.Forms.Button();
            this.assdatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adatagridview)).BeginInit();
            this.assbtnspnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // assAddbtn
            // 
            this.assAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.assAddbtn.Location = new System.Drawing.Point(384, 0);
            this.assAddbtn.Name = "assAddbtn";
            this.assAddbtn.Size = new System.Drawing.Size(75, 40);
            this.assAddbtn.TabIndex = 3;
            this.assAddbtn.Text = "Add";
            this.assAddbtn.UseVisualStyleBackColor = true;
            this.assAddbtn.Click += new System.EventHandler(this.assAddbtn_Click);
            // 
            // assdatapnl
            // 
            this.assdatapnl.Controls.Add(this.adatagridview);
            this.assdatapnl.Controls.Add(this.assigndatalbl);
            this.assdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assdatapnl.Location = new System.Drawing.Point(0, 0);
            this.assdatapnl.Name = "assdatapnl";
            this.assdatapnl.Size = new System.Drawing.Size(684, 471);
            this.assdatapnl.TabIndex = 3;
            this.assdatapnl.Paint += new System.Windows.Forms.PaintEventHandler(this.assdatapnl_Paint);
            // 
            // adatagridview
            // 
            this.adatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adatagridview.Location = new System.Drawing.Point(0, 20);
            this.adatagridview.Name = "adatagridview";
            this.adatagridview.Size = new System.Drawing.Size(684, 451);
            this.adatagridview.TabIndex = 1;
            this.adatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adatagridview_CellContentClick);
            // 
            // assigndatalbl
            // 
            this.assigndatalbl.AutoSize = true;
            this.assigndatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.assigndatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigndatalbl.Location = new System.Drawing.Point(0, 0);
            this.assigndatalbl.Name = "assigndatalbl";
            this.assigndatalbl.Size = new System.Drawing.Size(132, 20);
            this.assigndatalbl.TabIndex = 0;
            this.assigndatalbl.Text = "Assignment Data";
            this.assigndatalbl.Click += new System.EventHandler(this.assigndatalbl_Click);
            // 
            // assbtnspnl
            // 
            this.assbtnspnl.Controls.Add(this.assAddbtn);
            this.assbtnspnl.Controls.Add(this.assdelbtn);
            this.assbtnspnl.Controls.Add(this.assUpbtn);
            this.assbtnspnl.Controls.Add(this.assclosebtn);
            this.assbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.assbtnspnl.Name = "assbtnspnl";
            this.assbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.assbtnspnl.TabIndex = 2;
            this.assbtnspnl.Paint += new System.Windows.Forms.PaintEventHandler(this.assbtnspnl_Paint);
            // 
            // assdelbtn
            // 
            this.assdelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.assdelbtn.Location = new System.Drawing.Point(459, 0);
            this.assdelbtn.Name = "assdelbtn";
            this.assdelbtn.Size = new System.Drawing.Size(75, 40);
            this.assdelbtn.TabIndex = 2;
            this.assdelbtn.Text = "Delete";
            this.assdelbtn.UseVisualStyleBackColor = true;
            this.assdelbtn.Click += new System.EventHandler(this.assdelbtn_Click);
            // 
            // assUpbtn
            // 
            this.assUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.assUpbtn.Location = new System.Drawing.Point(534, 0);
            this.assUpbtn.Name = "assUpbtn";
            this.assUpbtn.Size = new System.Drawing.Size(75, 40);
            this.assUpbtn.TabIndex = 2;
            this.assUpbtn.Text = "Update";
            this.assUpbtn.UseVisualStyleBackColor = true;
            this.assUpbtn.Click += new System.EventHandler(this.assUpbtn_Click);
            // 
            // assclosebtn
            // 
            this.assclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.assclosebtn.Location = new System.Drawing.Point(609, 0);
            this.assclosebtn.Name = "assclosebtn";
            this.assclosebtn.Size = new System.Drawing.Size(75, 40);
            this.assclosebtn.TabIndex = 2;
            this.assclosebtn.Text = "Close";
            this.assclosebtn.UseVisualStyleBackColor = true;
            this.assclosebtn.Click += new System.EventHandler(this.assclosebtn_Click);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.assdatapnl);
            this.Controls.Add(this.assbtnspnl);
            this.Name = "Assignment";
            this.Text = "Assignment";
            this.assdatapnl.ResumeLayout(false);
            this.assdatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adatagridview)).EndInit();
            this.assbtnspnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button assAddbtn;
        private System.Windows.Forms.Panel assdatapnl;
        private System.Windows.Forms.DataGridView adatagridview;
        private System.Windows.Forms.Label assigndatalbl;
        private System.Windows.Forms.Panel assbtnspnl;
        private System.Windows.Forms.Button assdelbtn;
        private System.Windows.Forms.Button assUpbtn;
        private System.Windows.Forms.Button assclosebtn;
    }
}
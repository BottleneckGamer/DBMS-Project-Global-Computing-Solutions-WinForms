
namespace Global_Computing_Solutions
{
    partial class WorkLog
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
            this.wldatagridview = new System.Windows.Forms.DataGridView();
            this.wldatalbl = new System.Windows.Forms.Label();
            this.wlAddbtn = new System.Windows.Forms.Button();
            this.assdatapnl = new System.Windows.Forms.Panel();
            this.wlbtnspnl = new System.Windows.Forms.Panel();
            this.wldelbtn = new System.Windows.Forms.Button();
            this.wlUpbtn = new System.Windows.Forms.Button();
            this.wlclosebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wldatagridview)).BeginInit();
            this.assdatapnl.SuspendLayout();
            this.wlbtnspnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // wldatagridview
            // 
            this.wldatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wldatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wldatagridview.Location = new System.Drawing.Point(0, 20);
            this.wldatagridview.Name = "wldatagridview";
            this.wldatagridview.Size = new System.Drawing.Size(684, 451);
            this.wldatagridview.TabIndex = 1;
            // 
            // wldatalbl
            // 
            this.wldatalbl.AutoSize = true;
            this.wldatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.wldatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wldatalbl.Location = new System.Drawing.Point(0, 0);
            this.wldatalbl.Name = "wldatalbl";
            this.wldatalbl.Size = new System.Drawing.Size(116, 20);
            this.wldatalbl.TabIndex = 0;
            this.wldatalbl.Text = "Work Log Data";
            // 
            // wlAddbtn
            // 
            this.wlAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.wlAddbtn.Location = new System.Drawing.Point(384, 0);
            this.wlAddbtn.Name = "wlAddbtn";
            this.wlAddbtn.Size = new System.Drawing.Size(75, 40);
            this.wlAddbtn.TabIndex = 3;
            this.wlAddbtn.Text = "Add";
            this.wlAddbtn.UseVisualStyleBackColor = true;
            this.wlAddbtn.Click += new System.EventHandler(this.wlAddbtn_Click);
            // 
            // assdatapnl
            // 
            this.assdatapnl.Controls.Add(this.wldatagridview);
            this.assdatapnl.Controls.Add(this.wldatalbl);
            this.assdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assdatapnl.Location = new System.Drawing.Point(0, 0);
            this.assdatapnl.Name = "assdatapnl";
            this.assdatapnl.Size = new System.Drawing.Size(684, 471);
            this.assdatapnl.TabIndex = 5;
            // 
            // wlbtnspnl
            // 
            this.wlbtnspnl.Controls.Add(this.wlAddbtn);
            this.wlbtnspnl.Controls.Add(this.wldelbtn);
            this.wlbtnspnl.Controls.Add(this.wlUpbtn);
            this.wlbtnspnl.Controls.Add(this.wlclosebtn);
            this.wlbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wlbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.wlbtnspnl.Name = "wlbtnspnl";
            this.wlbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.wlbtnspnl.TabIndex = 4;
            // 
            // wldelbtn
            // 
            this.wldelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.wldelbtn.Location = new System.Drawing.Point(459, 0);
            this.wldelbtn.Name = "wldelbtn";
            this.wldelbtn.Size = new System.Drawing.Size(75, 40);
            this.wldelbtn.TabIndex = 2;
            this.wldelbtn.Text = "Delete";
            this.wldelbtn.UseVisualStyleBackColor = true;
            // 
            // wlUpbtn
            // 
            this.wlUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.wlUpbtn.Location = new System.Drawing.Point(534, 0);
            this.wlUpbtn.Name = "wlUpbtn";
            this.wlUpbtn.Size = new System.Drawing.Size(75, 40);
            this.wlUpbtn.TabIndex = 2;
            this.wlUpbtn.Text = "Update";
            this.wlUpbtn.UseVisualStyleBackColor = true;
            this.wlUpbtn.Click += new System.EventHandler(this.wlUpbtn_Click);
            // 
            // wlclosebtn
            // 
            this.wlclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.wlclosebtn.Location = new System.Drawing.Point(609, 0);
            this.wlclosebtn.Name = "wlclosebtn";
            this.wlclosebtn.Size = new System.Drawing.Size(75, 40);
            this.wlclosebtn.TabIndex = 2;
            this.wlclosebtn.Text = "Close";
            this.wlclosebtn.UseVisualStyleBackColor = true;
            this.wlclosebtn.Click += new System.EventHandler(this.wlclosebtn_Click);
            // 
            // WorkLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.assdatapnl);
            this.Controls.Add(this.wlbtnspnl);
            this.Name = "WorkLog";
            this.Text = "WorkLog";
            ((System.ComponentModel.ISupportInitialize)(this.wldatagridview)).EndInit();
            this.assdatapnl.ResumeLayout(false);
            this.assdatapnl.PerformLayout();
            this.wlbtnspnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView wldatagridview;
        private System.Windows.Forms.Label wldatalbl;
        private System.Windows.Forms.Button wlAddbtn;
        private System.Windows.Forms.Panel assdatapnl;
        private System.Windows.Forms.Panel wlbtnspnl;
        private System.Windows.Forms.Button wldelbtn;
        private System.Windows.Forms.Button wlUpbtn;
        private System.Windows.Forms.Button wlclosebtn;
    }
}
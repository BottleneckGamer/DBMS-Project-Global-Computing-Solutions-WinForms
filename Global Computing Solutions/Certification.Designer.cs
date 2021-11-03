
namespace Global_Computing_Solutions
{
    partial class Certification
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
            this.certclosebtn = new System.Windows.Forms.Button();
            this.certdatapnl = new System.Windows.Forms.Panel();
            this.certdatagridview = new System.Windows.Forms.DataGridView();
            this.Certdatalbl = new System.Windows.Forms.Label();
            this.certbtnspnl = new System.Windows.Forms.Panel();
            this.certAddbtn = new System.Windows.Forms.Button();
            this.certdelbtn = new System.Windows.Forms.Button();
            this.certUpbtn = new System.Windows.Forms.Button();
            this.certdatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certdatagridview)).BeginInit();
            this.certbtnspnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // certclosebtn
            // 
            this.certclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.certclosebtn.Location = new System.Drawing.Point(609, 0);
            this.certclosebtn.Name = "certclosebtn";
            this.certclosebtn.Size = new System.Drawing.Size(75, 40);
            this.certclosebtn.TabIndex = 2;
            this.certclosebtn.Text = "Close";
            this.certclosebtn.UseVisualStyleBackColor = true;
            // 
            // certdatapnl
            // 
            this.certdatapnl.Controls.Add(this.certdatagridview);
            this.certdatapnl.Controls.Add(this.Certdatalbl);
            this.certdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certdatapnl.Location = new System.Drawing.Point(0, 0);
            this.certdatapnl.Name = "certdatapnl";
            this.certdatapnl.Size = new System.Drawing.Size(684, 471);
            this.certdatapnl.TabIndex = 5;
            // 
            // certdatagridview
            // 
            this.certdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.certdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.certdatagridview.Location = new System.Drawing.Point(0, 20);
            this.certdatagridview.Name = "certdatagridview";
            this.certdatagridview.Size = new System.Drawing.Size(684, 451);
            this.certdatagridview.TabIndex = 1;
            // 
            // Certdatalbl
            // 
            this.Certdatalbl.AutoSize = true;
            this.Certdatalbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Certdatalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Certdatalbl.Location = new System.Drawing.Point(0, 0);
            this.Certdatalbl.Name = "Certdatalbl";
            this.Certdatalbl.Size = new System.Drawing.Size(132, 20);
            this.Certdatalbl.TabIndex = 0;
            this.Certdatalbl.Text = "Certification Data";
            // 
            // certbtnspnl
            // 
            this.certbtnspnl.Controls.Add(this.certAddbtn);
            this.certbtnspnl.Controls.Add(this.certdelbtn);
            this.certbtnspnl.Controls.Add(this.certUpbtn);
            this.certbtnspnl.Controls.Add(this.certclosebtn);
            this.certbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.certbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.certbtnspnl.Name = "certbtnspnl";
            this.certbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.certbtnspnl.TabIndex = 4;
            // 
            // certAddbtn
            // 
            this.certAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.certAddbtn.Location = new System.Drawing.Point(384, 0);
            this.certAddbtn.Name = "certAddbtn";
            this.certAddbtn.Size = new System.Drawing.Size(75, 40);
            this.certAddbtn.TabIndex = 3;
            this.certAddbtn.Text = "Add";
            this.certAddbtn.UseVisualStyleBackColor = true;
            this.certAddbtn.Click += new System.EventHandler(this.certAddbtn_Click);
            // 
            // certdelbtn
            // 
            this.certdelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.certdelbtn.Location = new System.Drawing.Point(459, 0);
            this.certdelbtn.Name = "certdelbtn";
            this.certdelbtn.Size = new System.Drawing.Size(75, 40);
            this.certdelbtn.TabIndex = 2;
            this.certdelbtn.Text = "Delete";
            this.certdelbtn.UseVisualStyleBackColor = true;
            // 
            // certUpbtn
            // 
            this.certUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.certUpbtn.Location = new System.Drawing.Point(534, 0);
            this.certUpbtn.Name = "certUpbtn";
            this.certUpbtn.Size = new System.Drawing.Size(75, 40);
            this.certUpbtn.TabIndex = 2;
            this.certUpbtn.Text = "Update";
            this.certUpbtn.UseVisualStyleBackColor = true;
            this.certUpbtn.Click += new System.EventHandler(this.certUpbtn_Click);
            // 
            // Certification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.certdatapnl);
            this.Controls.Add(this.certbtnspnl);
            this.Name = "Certification";
            this.Text = "Certification";
            this.certdatapnl.ResumeLayout(false);
            this.certdatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.certdatagridview)).EndInit();
            this.certbtnspnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button certclosebtn;
        private System.Windows.Forms.Panel certdatapnl;
        private System.Windows.Forms.DataGridView certdatagridview;
        private System.Windows.Forms.Label Certdatalbl;
        private System.Windows.Forms.Panel certbtnspnl;
        private System.Windows.Forms.Button certAddbtn;
        private System.Windows.Forms.Button certdelbtn;
        private System.Windows.Forms.Button certUpbtn;
    }
}
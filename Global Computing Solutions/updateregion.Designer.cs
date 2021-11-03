
namespace Global_Computing_Solutions
{
    partial class updateregion
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
            this.efirstnamepnl = new System.Windows.Forms.Panel();
            this.upregnametxtbox = new System.Windows.Forms.TextBox();
            this.regnamelbl = new System.Windows.Forms.Label();
            this.upregregionbtn = new System.Windows.Forms.Button();
            this.efirstnamepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // efirstnamepnl
            // 
            this.efirstnamepnl.Controls.Add(this.upregnametxtbox);
            this.efirstnamepnl.Controls.Add(this.regnamelbl);
            this.efirstnamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.efirstnamepnl.Location = new System.Drawing.Point(0, 0);
            this.efirstnamepnl.Name = "efirstnamepnl";
            this.efirstnamepnl.Size = new System.Drawing.Size(395, 61);
            this.efirstnamepnl.TabIndex = 3;
            // 
            // upregnametxtbox
            // 
            this.upregnametxtbox.Location = new System.Drawing.Point(125, 28);
            this.upregnametxtbox.Name = "upregnametxtbox";
            this.upregnametxtbox.Size = new System.Drawing.Size(170, 20);
            this.upregnametxtbox.TabIndex = 1;
            // 
            // regnamelbl
            // 
            this.regnamelbl.AutoSize = true;
            this.regnamelbl.Location = new System.Drawing.Point(12, 28);
            this.regnamelbl.Name = "regnamelbl";
            this.regnamelbl.Size = new System.Drawing.Size(72, 13);
            this.regnamelbl.TabIndex = 1;
            this.regnamelbl.Text = "Region Name";
            // 
            // upregregionbtn
            // 
            this.upregregionbtn.Location = new System.Drawing.Point(125, 67);
            this.upregregionbtn.Name = "upregregionbtn";
            this.upregregionbtn.Size = new System.Drawing.Size(131, 40);
            this.upregregionbtn.TabIndex = 4;
            this.upregregionbtn.Text = "Register Region";
            this.upregregionbtn.UseVisualStyleBackColor = true;
            this.upregregionbtn.Click += new System.EventHandler(this.upregregionbtn_Click);
            // 
            // updateregion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 117);
            this.Controls.Add(this.efirstnamepnl);
            this.Controls.Add(this.upregregionbtn);
            this.Name = "updateregion";
            this.Text = "update region";
            this.Load += new System.EventHandler(this.updateregion_Load);
            this.efirstnamepnl.ResumeLayout(false);
            this.efirstnamepnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel efirstnamepnl;
        private System.Windows.Forms.TextBox upregnametxtbox;
        private System.Windows.Forms.Label regnamelbl;
        private System.Windows.Forms.Button upregregionbtn;
    }
}
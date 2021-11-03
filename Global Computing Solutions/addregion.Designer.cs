
namespace Global_Computing_Solutions
{
    partial class addregion
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
            this.regnametxtbox = new System.Windows.Forms.TextBox();
            this.regnamelbl = new System.Windows.Forms.Label();
            this.regregionbtn = new System.Windows.Forms.Button();
            this.efirstnamepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // efirstnamepnl
            // 
            this.efirstnamepnl.Controls.Add(this.regnametxtbox);
            this.efirstnamepnl.Controls.Add(this.regnamelbl);
            this.efirstnamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.efirstnamepnl.Location = new System.Drawing.Point(0, 0);
            this.efirstnamepnl.Name = "efirstnamepnl";
            this.efirstnamepnl.Size = new System.Drawing.Size(395, 61);
            this.efirstnamepnl.TabIndex = 1;
            // 
            // regnametxtbox
            // 
            this.regnametxtbox.Location = new System.Drawing.Point(125, 28);
            this.regnametxtbox.Name = "regnametxtbox";
            this.regnametxtbox.Size = new System.Drawing.Size(170, 20);
            this.regnametxtbox.TabIndex = 1;
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
            // regregionbtn
            // 
            this.regregionbtn.Location = new System.Drawing.Point(135, 67);
            this.regregionbtn.Name = "regregionbtn";
            this.regregionbtn.Size = new System.Drawing.Size(131, 40);
            this.regregionbtn.TabIndex = 2;
            this.regregionbtn.Text = "Register Region";
            this.regregionbtn.UseVisualStyleBackColor = true;
            this.regregionbtn.Click += new System.EventHandler(this.regregionbtn_Click);
            // 
            // addregion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 117);
            this.Controls.Add(this.efirstnamepnl);
            this.Controls.Add(this.regregionbtn);
            this.Name = "addregion";
            this.Text = "addregion";
            this.efirstnamepnl.ResumeLayout(false);
            this.efirstnamepnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel efirstnamepnl;
        private System.Windows.Forms.TextBox regnametxtbox;
        private System.Windows.Forms.Label regnamelbl;
        private System.Windows.Forms.Button regregionbtn;
    }
}
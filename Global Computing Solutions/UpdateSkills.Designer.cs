
namespace Global_Computing_Solutions
{
    partial class UpdateSkills
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
            this.rateofpaylbl = new System.Windows.Forms.Label();
            this.efirstnamepnl = new System.Windows.Forms.Panel();
            this.upregskillbtn = new System.Windows.Forms.Button();
            this.uprateofpaytxtbox = new System.Windows.Forms.TextBox();
            this.skillnamelbl = new System.Windows.Forms.Label();
            this.emiddlenamepnl = new System.Windows.Forms.Panel();
            this.upskillnametxbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.efirstnamepnl.SuspendLayout();
            this.emiddlenamepnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rateofpaylbl
            // 
            this.rateofpaylbl.AutoSize = true;
            this.rateofpaylbl.Location = new System.Drawing.Point(59, 30);
            this.rateofpaylbl.Name = "rateofpaylbl";
            this.rateofpaylbl.Size = new System.Drawing.Size(63, 13);
            this.rateofpaylbl.TabIndex = 1;
            this.rateofpaylbl.Text = "Rate of Pay";
            // 
            // efirstnamepnl
            // 
            this.efirstnamepnl.Controls.Add(this.upregskillbtn);
            this.efirstnamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.efirstnamepnl.Location = new System.Drawing.Point(0, 126);
            this.efirstnamepnl.Name = "efirstnamepnl";
            this.efirstnamepnl.Size = new System.Drawing.Size(379, 61);
            this.efirstnamepnl.TabIndex = 11;
            // 
            // upregskillbtn
            // 
            this.upregskillbtn.Location = new System.Drawing.Point(108, 12);
            this.upregskillbtn.Name = "upregskillbtn";
            this.upregskillbtn.Size = new System.Drawing.Size(152, 40);
            this.upregskillbtn.TabIndex = 0;
            this.upregskillbtn.Text = "Register Skill";
            this.upregskillbtn.UseVisualStyleBackColor = true;
            this.upregskillbtn.Click += new System.EventHandler(this.upregskillbtn_Click);
            // 
            // uprateofpaytxtbox
            // 
            this.uprateofpaytxtbox.Location = new System.Drawing.Point(144, 27);
            this.uprateofpaytxtbox.Name = "uprateofpaytxtbox";
            this.uprateofpaytxtbox.Size = new System.Drawing.Size(170, 20);
            this.uprateofpaytxtbox.TabIndex = 1;
            // 
            // skillnamelbl
            // 
            this.skillnamelbl.AutoSize = true;
            this.skillnamelbl.Location = new System.Drawing.Point(65, 31);
            this.skillnamelbl.Name = "skillnamelbl";
            this.skillnamelbl.Size = new System.Drawing.Size(57, 13);
            this.skillnamelbl.TabIndex = 2;
            this.skillnamelbl.Text = "Skill Name";
            // 
            // emiddlenamepnl
            // 
            this.emiddlenamepnl.Controls.Add(this.uprateofpaytxtbox);
            this.emiddlenamepnl.Controls.Add(this.rateofpaylbl);
            this.emiddlenamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emiddlenamepnl.Location = new System.Drawing.Point(0, 65);
            this.emiddlenamepnl.Name = "emiddlenamepnl";
            this.emiddlenamepnl.Size = new System.Drawing.Size(379, 61);
            this.emiddlenamepnl.TabIndex = 12;
            // 
            // upskillnametxbox
            // 
            this.upskillnametxbox.Location = new System.Drawing.Point(144, 24);
            this.upskillnametxbox.Name = "upskillnametxbox";
            this.upskillnametxbox.Size = new System.Drawing.Size(170, 20);
            this.upskillnametxbox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.skillnamelbl);
            this.panel2.Controls.Add(this.upskillnametxbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 65);
            this.panel2.TabIndex = 13;
            // 
            // UpdateSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 190);
            this.Controls.Add(this.efirstnamepnl);
            this.Controls.Add(this.emiddlenamepnl);
            this.Controls.Add(this.panel2);
            this.Name = "UpdateSkills";
            this.Text = "UpdateSkills";
            this.Load += new System.EventHandler(this.UpdateSkills_Load);
            this.efirstnamepnl.ResumeLayout(false);
            this.emiddlenamepnl.ResumeLayout(false);
            this.emiddlenamepnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label rateofpaylbl;
        private System.Windows.Forms.Panel efirstnamepnl;
        private System.Windows.Forms.Button upregskillbtn;
        private System.Windows.Forms.TextBox uprateofpaytxtbox;
        private System.Windows.Forms.Label skillnamelbl;
        private System.Windows.Forms.Panel emiddlenamepnl;
        private System.Windows.Forms.TextBox upskillnametxbox;
        private System.Windows.Forms.Panel panel2;
    }
}
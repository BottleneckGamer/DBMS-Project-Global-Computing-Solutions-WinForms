
namespace Global_Computing_Solutions
{
    partial class addcertification
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
            this.regcertbtn = new System.Windows.Forms.Button();
            this.empidclbl = new System.Windows.Forms.Label();
            this.Skilllbl = new System.Windows.Forms.Label();
            this.dateofcertpicker = new System.Windows.Forms.DateTimePicker();
            this.dateofcertlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateofhirepnl = new System.Windows.Forms.Panel();
            this.emiddlenamepnl = new System.Windows.Forms.Panel();
            this.certskillid = new System.Windows.Forms.ComboBox();
            this.certempid = new System.Windows.Forms.ComboBox();
            this.efirstnamepnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.dateofhirepnl.SuspendLayout();
            this.emiddlenamepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // efirstnamepnl
            // 
            this.efirstnamepnl.Controls.Add(this.regcertbtn);
            this.efirstnamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.efirstnamepnl.Location = new System.Drawing.Point(0, 187);
            this.efirstnamepnl.Name = "efirstnamepnl";
            this.efirstnamepnl.Size = new System.Drawing.Size(388, 61);
            this.efirstnamepnl.TabIndex = 7;
            // 
            // regcertbtn
            // 
            this.regcertbtn.Location = new System.Drawing.Point(60, 18);
            this.regcertbtn.Name = "regcertbtn";
            this.regcertbtn.Size = new System.Drawing.Size(241, 40);
            this.regcertbtn.TabIndex = 0;
            this.regcertbtn.Text = "Register Certification";
            this.regcertbtn.UseVisualStyleBackColor = true;
            this.regcertbtn.Click += new System.EventHandler(this.regcertbtn_Click);
            // 
            // empidclbl
            // 
            this.empidclbl.AutoSize = true;
            this.empidclbl.Location = new System.Drawing.Point(12, 30);
            this.empidclbl.Name = "empidclbl";
            this.empidclbl.Size = new System.Drawing.Size(67, 13);
            this.empidclbl.TabIndex = 1;
            this.empidclbl.Text = "Employee ID";
            // 
            // Skilllbl
            // 
            this.Skilllbl.AutoSize = true;
            this.Skilllbl.Location = new System.Drawing.Point(12, 32);
            this.Skilllbl.Name = "Skilllbl";
            this.Skilllbl.Size = new System.Drawing.Size(40, 13);
            this.Skilllbl.TabIndex = 2;
            this.Skilllbl.Text = "Skill ID";
            // 
            // dateofcertpicker
            // 
            this.dateofcertpicker.Location = new System.Drawing.Point(125, 22);
            this.dateofcertpicker.Name = "dateofcertpicker";
            this.dateofcertpicker.Size = new System.Drawing.Size(208, 20);
            this.dateofcertpicker.TabIndex = 1;
            // 
            // dateofcertlbl
            // 
            this.dateofcertlbl.AutoSize = true;
            this.dateofcertlbl.Location = new System.Drawing.Point(12, 29);
            this.dateofcertlbl.Name = "dateofcertlbl";
            this.dateofcertlbl.Size = new System.Drawing.Size(100, 13);
            this.dateofcertlbl.TabIndex = 0;
            this.dateofcertlbl.Text = "Date of Certification";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateofcertpicker);
            this.panel2.Controls.Add(this.dateofcertlbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 65);
            this.panel2.TabIndex = 10;
            // 
            // dateofhirepnl
            // 
            this.dateofhirepnl.Controls.Add(this.certempid);
            this.dateofhirepnl.Controls.Add(this.empidclbl);
            this.dateofhirepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateofhirepnl.Location = new System.Drawing.Point(0, 61);
            this.dateofhirepnl.Name = "dateofhirepnl";
            this.dateofhirepnl.Size = new System.Drawing.Size(388, 61);
            this.dateofhirepnl.TabIndex = 9;
            // 
            // emiddlenamepnl
            // 
            this.emiddlenamepnl.Controls.Add(this.certskillid);
            this.emiddlenamepnl.Controls.Add(this.Skilllbl);
            this.emiddlenamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emiddlenamepnl.Location = new System.Drawing.Point(0, 0);
            this.emiddlenamepnl.Name = "emiddlenamepnl";
            this.emiddlenamepnl.Size = new System.Drawing.Size(388, 61);
            this.emiddlenamepnl.TabIndex = 8;
            // 
            // certskillid
            // 
            this.certskillid.FormattingEnabled = true;
            this.certskillid.Location = new System.Drawing.Point(125, 24);
            this.certskillid.Name = "certskillid";
            this.certskillid.Size = new System.Drawing.Size(121, 21);
            this.certskillid.TabIndex = 3;
            // 
            // certempid
            // 
            this.certempid.FormattingEnabled = true;
            this.certempid.Location = new System.Drawing.Point(125, 22);
            this.certempid.Name = "certempid";
            this.certempid.Size = new System.Drawing.Size(121, 21);
            this.certempid.TabIndex = 2;
            // 
            // addcertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 284);
            this.Controls.Add(this.efirstnamepnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateofhirepnl);
            this.Controls.Add(this.emiddlenamepnl);
            this.Name = "addcertification";
            this.Text = "addcertification";
            this.efirstnamepnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dateofhirepnl.ResumeLayout(false);
            this.dateofhirepnl.PerformLayout();
            this.emiddlenamepnl.ResumeLayout(false);
            this.emiddlenamepnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel efirstnamepnl;
        private System.Windows.Forms.Button regcertbtn;
        private System.Windows.Forms.Label empidclbl;
        private System.Windows.Forms.Label Skilllbl;
        private System.Windows.Forms.DateTimePicker dateofcertpicker;
        private System.Windows.Forms.Label dateofcertlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dateofhirepnl;
        private System.Windows.Forms.Panel emiddlenamepnl;
        private System.Windows.Forms.ComboBox certempid;
        private System.Windows.Forms.ComboBox certskillid;
    }
}
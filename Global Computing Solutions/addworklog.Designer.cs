
namespace Global_Computing_Solutions
{
    partial class addworklog
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
            this.wlempidlbl = new System.Windows.Forms.Label();
            this.wltaskid = new System.Windows.Forms.Label();
            this.noofhrslbl = new System.Windows.Forms.Label();
            this.wldatepicker = new System.Windows.Forms.DateTimePicker();
            this.dateofhirelbl = new System.Windows.Forms.Label();
            this.dateofhirepnl = new System.Windows.Forms.Panel();
            this.wlnoofhrspnl = new System.Windows.Forms.Panel();
            this.wlnoofhourstxtbox = new System.Windows.Forms.TextBox();
            this.emiddlenamepnl = new System.Windows.Forms.Panel();
            this.wltaskidcmbox = new System.Windows.Forms.ComboBox();
            this.wlempidpnl = new System.Windows.Forms.Panel();
            this.wlempidcmbox = new System.Windows.Forms.ComboBox();
            this.addemppnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wlregbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.wlbillingnocmbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateofhirepnl.SuspendLayout();
            this.wlnoofhrspnl.SuspendLayout();
            this.emiddlenamepnl.SuspendLayout();
            this.wlempidpnl.SuspendLayout();
            this.addemppnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wlempidlbl
            // 
            this.wlempidlbl.AutoSize = true;
            this.wlempidlbl.Location = new System.Drawing.Point(12, 28);
            this.wlempidlbl.Name = "wlempidlbl";
            this.wlempidlbl.Size = new System.Drawing.Size(67, 13);
            this.wlempidlbl.TabIndex = 1;
            this.wlempidlbl.Text = "Employee ID";
            // 
            // wltaskid
            // 
            this.wltaskid.AutoSize = true;
            this.wltaskid.Location = new System.Drawing.Point(12, 28);
            this.wltaskid.Name = "wltaskid";
            this.wltaskid.Size = new System.Drawing.Size(45, 13);
            this.wltaskid.TabIndex = 2;
            this.wltaskid.Text = "Task ID";
            // 
            // noofhrslbl
            // 
            this.noofhrslbl.AutoSize = true;
            this.noofhrslbl.Location = new System.Drawing.Point(12, 28);
            this.noofhrslbl.Name = "noofhrslbl";
            this.noofhrslbl.Size = new System.Drawing.Size(67, 13);
            this.noofhrslbl.TabIndex = 0;
            this.noofhrslbl.Text = "No. of Hours";
            // 
            // wldatepicker
            // 
            this.wldatepicker.Location = new System.Drawing.Point(125, 22);
            this.wldatepicker.Name = "wldatepicker";
            this.wldatepicker.Size = new System.Drawing.Size(208, 20);
            this.wldatepicker.TabIndex = 1;
            // 
            // dateofhirelbl
            // 
            this.dateofhirelbl.AutoSize = true;
            this.dateofhirelbl.Location = new System.Drawing.Point(12, 28);
            this.dateofhirelbl.Name = "dateofhirelbl";
            this.dateofhirelbl.Size = new System.Drawing.Size(30, 13);
            this.dateofhirelbl.TabIndex = 0;
            this.dateofhirelbl.Text = "Date";
            // 
            // dateofhirepnl
            // 
            this.dateofhirepnl.Controls.Add(this.wldatepicker);
            this.dateofhirepnl.Controls.Add(this.dateofhirelbl);
            this.dateofhirepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateofhirepnl.Location = new System.Drawing.Point(0, 183);
            this.dateofhirepnl.Name = "dateofhirepnl";
            this.dateofhirepnl.Size = new System.Drawing.Size(404, 61);
            this.dateofhirepnl.TabIndex = 3;
            // 
            // wlnoofhrspnl
            // 
            this.wlnoofhrspnl.Controls.Add(this.wlnoofhourstxtbox);
            this.wlnoofhrspnl.Controls.Add(this.noofhrslbl);
            this.wlnoofhrspnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.wlnoofhrspnl.Location = new System.Drawing.Point(0, 122);
            this.wlnoofhrspnl.Name = "wlnoofhrspnl";
            this.wlnoofhrspnl.Size = new System.Drawing.Size(404, 61);
            this.wlnoofhrspnl.TabIndex = 2;
            // 
            // wlnoofhourstxtbox
            // 
            this.wlnoofhourstxtbox.Location = new System.Drawing.Point(125, 21);
            this.wlnoofhourstxtbox.Name = "wlnoofhourstxtbox";
            this.wlnoofhourstxtbox.Size = new System.Drawing.Size(165, 20);
            this.wlnoofhourstxtbox.TabIndex = 1;
            // 
            // emiddlenamepnl
            // 
            this.emiddlenamepnl.Controls.Add(this.wltaskidcmbox);
            this.emiddlenamepnl.Controls.Add(this.wltaskid);
            this.emiddlenamepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.emiddlenamepnl.Location = new System.Drawing.Point(0, 61);
            this.emiddlenamepnl.Name = "emiddlenamepnl";
            this.emiddlenamepnl.Size = new System.Drawing.Size(404, 61);
            this.emiddlenamepnl.TabIndex = 1;
            // 
            // wltaskidcmbox
            // 
            this.wltaskidcmbox.FormattingEnabled = true;
            this.wltaskidcmbox.Location = new System.Drawing.Point(125, 20);
            this.wltaskidcmbox.Name = "wltaskidcmbox";
            this.wltaskidcmbox.Size = new System.Drawing.Size(165, 21);
            this.wltaskidcmbox.TabIndex = 3;
            // 
            // wlempidpnl
            // 
            this.wlempidpnl.Controls.Add(this.wlempidcmbox);
            this.wlempidpnl.Controls.Add(this.wlempidlbl);
            this.wlempidpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.wlempidpnl.Location = new System.Drawing.Point(0, 0);
            this.wlempidpnl.Name = "wlempidpnl";
            this.wlempidpnl.Size = new System.Drawing.Size(404, 61);
            this.wlempidpnl.TabIndex = 0;
            // 
            // wlempidcmbox
            // 
            this.wlempidcmbox.FormattingEnabled = true;
            this.wlempidcmbox.Location = new System.Drawing.Point(125, 20);
            this.wlempidcmbox.Name = "wlempidcmbox";
            this.wlempidcmbox.Size = new System.Drawing.Size(165, 21);
            this.wlempidcmbox.TabIndex = 2;
            // 
            // addemppnl
            // 
            this.addemppnl.Controls.Add(this.panel1);
            this.addemppnl.Controls.Add(this.panel3);
            this.addemppnl.Controls.Add(this.dateofhirepnl);
            this.addemppnl.Controls.Add(this.wlnoofhrspnl);
            this.addemppnl.Controls.Add(this.emiddlenamepnl);
            this.addemppnl.Controls.Add(this.wlempidpnl);
            this.addemppnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.addemppnl.Location = new System.Drawing.Point(0, 0);
            this.addemppnl.Name = "addemppnl";
            this.addemppnl.Size = new System.Drawing.Size(404, 450);
            this.addemppnl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wlregbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 65);
            this.panel1.TabIndex = 8;
            // 
            // wlregbtn
            // 
            this.wlregbtn.Location = new System.Drawing.Point(54, 22);
            this.wlregbtn.Name = "wlregbtn";
            this.wlregbtn.Size = new System.Drawing.Size(304, 40);
            this.wlregbtn.TabIndex = 0;
            this.wlregbtn.Text = "Register Work Log";
            this.wlregbtn.UseVisualStyleBackColor = true;
            this.wlregbtn.Click += new System.EventHandler(this.wlregbtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.wlbillingnocmbox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 61);
            this.panel3.TabIndex = 7;
            // 
            // wlbillingnocmbox
            // 
            this.wlbillingnocmbox.FormattingEnabled = true;
            this.wlbillingnocmbox.Location = new System.Drawing.Point(125, 20);
            this.wlbillingnocmbox.Name = "wlbillingnocmbox";
            this.wlbillingnocmbox.Size = new System.Drawing.Size(165, 21);
            this.wlbillingnocmbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Billing Number";
            // 
            // addworklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.addemppnl);
            this.Name = "addworklog";
            this.Text = "addworklog";
            this.dateofhirepnl.ResumeLayout(false);
            this.dateofhirepnl.PerformLayout();
            this.wlnoofhrspnl.ResumeLayout(false);
            this.wlnoofhrspnl.PerformLayout();
            this.emiddlenamepnl.ResumeLayout(false);
            this.emiddlenamepnl.PerformLayout();
            this.wlempidpnl.ResumeLayout(false);
            this.wlempidpnl.PerformLayout();
            this.addemppnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label wlempidlbl;
        private System.Windows.Forms.Label wltaskid;
        private System.Windows.Forms.Label noofhrslbl;
        private System.Windows.Forms.DateTimePicker wldatepicker;
        private System.Windows.Forms.Label dateofhirelbl;
        private System.Windows.Forms.Panel dateofhirepnl;
        private System.Windows.Forms.Panel wlnoofhrspnl;
        private System.Windows.Forms.TextBox wlnoofhourstxtbox;
        private System.Windows.Forms.Panel emiddlenamepnl;
        private System.Windows.Forms.ComboBox wltaskidcmbox;
        private System.Windows.Forms.Panel wlempidpnl;
        private System.Windows.Forms.ComboBox wlempidcmbox;
        private System.Windows.Forms.Panel addemppnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button wlregbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox wlbillingnocmbox;
        private System.Windows.Forms.Label label2;
    }
}
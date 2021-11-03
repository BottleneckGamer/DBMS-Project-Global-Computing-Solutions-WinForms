
namespace Global_Computing_Solutions
{
    partial class addAssignment
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
            this.assempidlbl = new System.Windows.Forms.Label();
            this.aenddatepnl = new System.Windows.Forms.Panel();
            this.aenddate = new System.Windows.Forms.DateTimePicker();
            this.assenddatelbl = new System.Windows.Forms.Label();
            this.asstasklbl = new System.Windows.Forms.Label();
            this.astartdatepnl = new System.Windows.Forms.Panel();
            this.astartdate = new System.Windows.Forms.DateTimePicker();
            this.assstartdatelbl = new System.Windows.Forms.Label();
            this.ataskidpnl = new System.Windows.Forms.Panel();
            this.regassbtn = new System.Windows.Forms.Button();
            this.aempidpnl = new System.Windows.Forms.Panel();
            this.regasspnl = new System.Windows.Forms.Panel();
            this.assempidcmbox = new System.Windows.Forms.ComboBox();
            this.asstaskidcmbox = new System.Windows.Forms.ComboBox();
            this.aenddatepnl.SuspendLayout();
            this.astartdatepnl.SuspendLayout();
            this.ataskidpnl.SuspendLayout();
            this.aempidpnl.SuspendLayout();
            this.regasspnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // assempidlbl
            // 
            this.assempidlbl.AutoSize = true;
            this.assempidlbl.Location = new System.Drawing.Point(24, 23);
            this.assempidlbl.Name = "assempidlbl";
            this.assempidlbl.Size = new System.Drawing.Size(67, 13);
            this.assempidlbl.TabIndex = 1;
            this.assempidlbl.Text = "Employee ID";
            // 
            // aenddatepnl
            // 
            this.aenddatepnl.Controls.Add(this.aenddate);
            this.aenddatepnl.Controls.Add(this.assenddatelbl);
            this.aenddatepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.aenddatepnl.Location = new System.Drawing.Point(0, 187);
            this.aenddatepnl.Name = "aenddatepnl";
            this.aenddatepnl.Size = new System.Drawing.Size(373, 61);
            this.aenddatepnl.TabIndex = 8;
            // 
            // aenddate
            // 
            this.aenddate.Location = new System.Drawing.Point(125, 22);
            this.aenddate.Name = "aenddate";
            this.aenddate.Size = new System.Drawing.Size(208, 20);
            this.aenddate.TabIndex = 1;
            // 
            // assenddatelbl
            // 
            this.assenddatelbl.AutoSize = true;
            this.assenddatelbl.Location = new System.Drawing.Point(29, 29);
            this.assenddatelbl.Name = "assenddatelbl";
            this.assenddatelbl.Size = new System.Drawing.Size(52, 13);
            this.assenddatelbl.TabIndex = 0;
            this.assenddatelbl.Text = "End Date";
            // 
            // asstasklbl
            // 
            this.asstasklbl.AutoSize = true;
            this.asstasklbl.Location = new System.Drawing.Point(24, 23);
            this.asstasklbl.Name = "asstasklbl";
            this.asstasklbl.Size = new System.Drawing.Size(45, 13);
            this.asstasklbl.TabIndex = 2;
            this.asstasklbl.Text = "Task ID";
            // 
            // astartdatepnl
            // 
            this.astartdatepnl.Controls.Add(this.astartdate);
            this.astartdatepnl.Controls.Add(this.assstartdatelbl);
            this.astartdatepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.astartdatepnl.Location = new System.Drawing.Point(0, 126);
            this.astartdatepnl.Name = "astartdatepnl";
            this.astartdatepnl.Size = new System.Drawing.Size(373, 61);
            this.astartdatepnl.TabIndex = 7;
            // 
            // astartdate
            // 
            this.astartdate.Location = new System.Drawing.Point(125, 19);
            this.astartdate.Name = "astartdate";
            this.astartdate.Size = new System.Drawing.Size(208, 20);
            this.astartdate.TabIndex = 1;
            // 
            // assstartdatelbl
            // 
            this.assstartdatelbl.AutoSize = true;
            this.assstartdatelbl.Location = new System.Drawing.Point(24, 26);
            this.assstartdatelbl.Name = "assstartdatelbl";
            this.assstartdatelbl.Size = new System.Drawing.Size(55, 13);
            this.assstartdatelbl.TabIndex = 0;
            this.assstartdatelbl.Text = "Start Date";
            // 
            // ataskidpnl
            // 
            this.ataskidpnl.Controls.Add(this.asstaskidcmbox);
            this.ataskidpnl.Controls.Add(this.asstasklbl);
            this.ataskidpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ataskidpnl.Location = new System.Drawing.Point(0, 65);
            this.ataskidpnl.Name = "ataskidpnl";
            this.ataskidpnl.Size = new System.Drawing.Size(373, 61);
            this.ataskidpnl.TabIndex = 9;
            // 
            // regassbtn
            // 
            this.regassbtn.Location = new System.Drawing.Point(32, 18);
            this.regassbtn.Name = "regassbtn";
            this.regassbtn.Size = new System.Drawing.Size(304, 40);
            this.regassbtn.TabIndex = 0;
            this.regassbtn.Text = "Register Assignment";
            this.regassbtn.UseVisualStyleBackColor = true;
            this.regassbtn.Click += new System.EventHandler(this.regassbtn_Click);
            // 
            // aempidpnl
            // 
            this.aempidpnl.Controls.Add(this.assempidcmbox);
            this.aempidpnl.Controls.Add(this.assempidlbl);
            this.aempidpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.aempidpnl.Location = new System.Drawing.Point(0, 0);
            this.aempidpnl.Name = "aempidpnl";
            this.aempidpnl.Size = new System.Drawing.Size(373, 65);
            this.aempidpnl.TabIndex = 10;
            // 
            // regasspnl
            // 
            this.regasspnl.Controls.Add(this.regassbtn);
            this.regasspnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.regasspnl.Location = new System.Drawing.Point(0, 248);
            this.regasspnl.Name = "regasspnl";
            this.regasspnl.Size = new System.Drawing.Size(373, 61);
            this.regasspnl.TabIndex = 12;
            // 
            // assempidcmbox
            // 
            this.assempidcmbox.FormattingEnabled = true;
            this.assempidcmbox.Location = new System.Drawing.Point(125, 20);
            this.assempidcmbox.Name = "assempidcmbox";
            this.assempidcmbox.Size = new System.Drawing.Size(121, 21);
            this.assempidcmbox.TabIndex = 2;
            // 
            // asstaskidcmbox
            // 
            this.asstaskidcmbox.FormattingEnabled = true;
            this.asstaskidcmbox.Location = new System.Drawing.Point(125, 20);
            this.asstaskidcmbox.Name = "asstaskidcmbox";
            this.asstaskidcmbox.Size = new System.Drawing.Size(121, 21);
            this.asstaskidcmbox.TabIndex = 3;
            // 
            // addAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 333);
            this.Controls.Add(this.regasspnl);
            this.Controls.Add(this.aenddatepnl);
            this.Controls.Add(this.astartdatepnl);
            this.Controls.Add(this.ataskidpnl);
            this.Controls.Add(this.aempidpnl);
            this.Name = "addAssignment";
            this.Text = "addAssignment";
            this.aenddatepnl.ResumeLayout(false);
            this.aenddatepnl.PerformLayout();
            this.astartdatepnl.ResumeLayout(false);
            this.astartdatepnl.PerformLayout();
            this.ataskidpnl.ResumeLayout(false);
            this.ataskidpnl.PerformLayout();
            this.aempidpnl.ResumeLayout(false);
            this.aempidpnl.PerformLayout();
            this.regasspnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label assempidlbl;
        private System.Windows.Forms.Panel aenddatepnl;
        private System.Windows.Forms.Button regassbtn;
        private System.Windows.Forms.Label asstasklbl;
        private System.Windows.Forms.Panel astartdatepnl;
        private System.Windows.Forms.DateTimePicker astartdate;
        private System.Windows.Forms.Label assstartdatelbl;
        private System.Windows.Forms.Panel ataskidpnl;
        private System.Windows.Forms.Panel aempidpnl;
        private System.Windows.Forms.DateTimePicker aenddate;
        private System.Windows.Forms.Label assenddatelbl;
        private System.Windows.Forms.Panel regasspnl;
        private System.Windows.Forms.ComboBox asstaskidcmbox;
        private System.Windows.Forms.ComboBox assempidcmbox;
    }
}
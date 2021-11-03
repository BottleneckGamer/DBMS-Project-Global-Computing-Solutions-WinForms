
namespace Global_Computing_Solutions
{
    partial class UpdateBilling
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
            this.addemppnl = new System.Windows.Forms.Panel();
            this.regbillpnl = new System.Windows.Forms.Panel();
            this.regbillbtn = new System.Windows.Forms.Button();
            this.totalamountpnl = new System.Windows.Forms.Panel();
            this.dateofhirelbl = new System.Windows.Forms.Label();
            this.totalamounttxtbox = new System.Windows.Forms.TextBox();
            this.billdatepnl = new System.Windows.Forms.Panel();
            this.billdatepicker = new System.Windows.Forms.DateTimePicker();
            this.billdatelbl = new System.Windows.Forms.Label();
            this.addemppnl.SuspendLayout();
            this.regbillpnl.SuspendLayout();
            this.totalamountpnl.SuspendLayout();
            this.billdatepnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // addemppnl
            // 
            this.addemppnl.Controls.Add(this.regbillpnl);
            this.addemppnl.Controls.Add(this.totalamountpnl);
            this.addemppnl.Controls.Add(this.billdatepnl);
            this.addemppnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.addemppnl.Location = new System.Drawing.Point(0, 0);
            this.addemppnl.Name = "addemppnl";
            this.addemppnl.Size = new System.Drawing.Size(404, 206);
            this.addemppnl.TabIndex = 2;
            // 
            // regbillpnl
            // 
            this.regbillpnl.Controls.Add(this.regbillbtn);
            this.regbillpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.regbillpnl.Location = new System.Drawing.Point(0, 122);
            this.regbillpnl.Name = "regbillpnl";
            this.regbillpnl.Size = new System.Drawing.Size(404, 65);
            this.regbillpnl.TabIndex = 6;
            // 
            // regbillbtn
            // 
            this.regbillbtn.Location = new System.Drawing.Point(54, 22);
            this.regbillbtn.Name = "regbillbtn";
            this.regbillbtn.Size = new System.Drawing.Size(304, 40);
            this.regbillbtn.TabIndex = 0;
            this.regbillbtn.Text = "Register Billing";
            this.regbillbtn.UseVisualStyleBackColor = true;
            this.regbillbtn.Click += new System.EventHandler(this.regbillbtn_Click);
            // 
            // totalamountpnl
            // 
            this.totalamountpnl.Controls.Add(this.dateofhirelbl);
            this.totalamountpnl.Controls.Add(this.totalamounttxtbox);
            this.totalamountpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalamountpnl.Location = new System.Drawing.Point(0, 61);
            this.totalamountpnl.Name = "totalamountpnl";
            this.totalamountpnl.Size = new System.Drawing.Size(404, 61);
            this.totalamountpnl.TabIndex = 3;
            // 
            // dateofhirelbl
            // 
            this.dateofhirelbl.AutoSize = true;
            this.dateofhirelbl.Location = new System.Drawing.Point(12, 28);
            this.dateofhirelbl.Name = "dateofhirelbl";
            this.dateofhirelbl.Size = new System.Drawing.Size(70, 13);
            this.dateofhirelbl.TabIndex = 0;
            this.dateofhirelbl.Text = "Total Amount";
            // 
            // totalamounttxtbox
            // 
            this.totalamounttxtbox.Location = new System.Drawing.Point(114, 21);
            this.totalamounttxtbox.Name = "totalamounttxtbox";
            this.totalamounttxtbox.Size = new System.Drawing.Size(170, 20);
            this.totalamounttxtbox.TabIndex = 1;
            // 
            // billdatepnl
            // 
            this.billdatepnl.Controls.Add(this.billdatepicker);
            this.billdatepnl.Controls.Add(this.billdatelbl);
            this.billdatepnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.billdatepnl.Location = new System.Drawing.Point(0, 0);
            this.billdatepnl.Name = "billdatepnl";
            this.billdatepnl.Size = new System.Drawing.Size(404, 61);
            this.billdatepnl.TabIndex = 2;
            // 
            // billdatepicker
            // 
            this.billdatepicker.Location = new System.Drawing.Point(114, 22);
            this.billdatepicker.Name = "billdatepicker";
            this.billdatepicker.Size = new System.Drawing.Size(208, 20);
            this.billdatepicker.TabIndex = 1;
            // 
            // billdatelbl
            // 
            this.billdatelbl.AutoSize = true;
            this.billdatelbl.Location = new System.Drawing.Point(12, 28);
            this.billdatelbl.Name = "billdatelbl";
            this.billdatelbl.Size = new System.Drawing.Size(46, 13);
            this.billdatelbl.TabIndex = 0;
            this.billdatelbl.Text = "Bill Date";
            // 
            // UpdateBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 206);
            this.Controls.Add(this.addemppnl);
            this.Name = "UpdateBilling";
            this.Text = "UpdateBilling";
            this.Load += new System.EventHandler(this.UpdateBilling_Load);
            this.addemppnl.ResumeLayout(false);
            this.regbillpnl.ResumeLayout(false);
            this.totalamountpnl.ResumeLayout(false);
            this.totalamountpnl.PerformLayout();
            this.billdatepnl.ResumeLayout(false);
            this.billdatepnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addemppnl;
        private System.Windows.Forms.Panel regbillpnl;
        private System.Windows.Forms.Button regbillbtn;
        private System.Windows.Forms.Panel totalamountpnl;
        private System.Windows.Forms.Label dateofhirelbl;
        private System.Windows.Forms.TextBox totalamounttxtbox;
        private System.Windows.Forms.Panel billdatepnl;
        private System.Windows.Forms.DateTimePicker billdatepicker;
        private System.Windows.Forms.Label billdatelbl;
    }
}
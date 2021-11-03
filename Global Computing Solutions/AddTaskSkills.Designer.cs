
namespace Global_Computing_Solutions
{
    partial class AddTaskSkills
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
            this.noofemplbl = new System.Windows.Forms.Label();
            this.regtspnl = new System.Windows.Forms.Panel();
            this.tsregbtn = new System.Windows.Forms.Button();
            this.tsdutyidlbl = new System.Windows.Forms.Label();
            this.noofemppnl = new System.Windows.Forms.Panel();
            this.numberofemptxtbox = new System.Windows.Forms.TextBox();
            this.tsdutyidcmbox = new System.Windows.Forms.ComboBox();
            this.tsskillid = new System.Windows.Forms.Label();
            this.tsdutyidpnl = new System.Windows.Forms.Panel();
            this.tsskillidcmbox = new System.Windows.Forms.ComboBox();
            this.tsskillidpnl = new System.Windows.Forms.Panel();
            this.regtspnl.SuspendLayout();
            this.noofemppnl.SuspendLayout();
            this.tsdutyidpnl.SuspendLayout();
            this.tsskillidpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // noofemplbl
            // 
            this.noofemplbl.AutoSize = true;
            this.noofemplbl.Location = new System.Drawing.Point(33, 24);
            this.noofemplbl.Name = "noofemplbl";
            this.noofemplbl.Size = new System.Drawing.Size(85, 13);
            this.noofemplbl.TabIndex = 1;
            this.noofemplbl.Text = "No. of Employee";
            // 
            // regtspnl
            // 
            this.regtspnl.Controls.Add(this.tsregbtn);
            this.regtspnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.regtspnl.Location = new System.Drawing.Point(0, 187);
            this.regtspnl.Name = "regtspnl";
            this.regtspnl.Size = new System.Drawing.Size(382, 61);
            this.regtspnl.TabIndex = 9;
            // 
            // tsregbtn
            // 
            this.tsregbtn.Location = new System.Drawing.Point(36, 18);
            this.tsregbtn.Name = "tsregbtn";
            this.tsregbtn.Size = new System.Drawing.Size(304, 40);
            this.tsregbtn.TabIndex = 0;
            this.tsregbtn.Text = "Register Task Skills";
            this.tsregbtn.UseVisualStyleBackColor = true;
            this.tsregbtn.Click += new System.EventHandler(this.tsregbtn_Click);
            // 
            // tsdutyidlbl
            // 
            this.tsdutyidlbl.AutoSize = true;
            this.tsdutyidlbl.Location = new System.Drawing.Point(55, 29);
            this.tsdutyidlbl.Name = "tsdutyidlbl";
            this.tsdutyidlbl.Size = new System.Drawing.Size(43, 13);
            this.tsdutyidlbl.TabIndex = 2;
            this.tsdutyidlbl.Text = "Duty ID";
            // 
            // noofemppnl
            // 
            this.noofemppnl.Controls.Add(this.numberofemptxtbox);
            this.noofemppnl.Controls.Add(this.noofemplbl);
            this.noofemppnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.noofemppnl.Location = new System.Drawing.Point(0, 126);
            this.noofemppnl.Name = "noofemppnl";
            this.noofemppnl.Size = new System.Drawing.Size(382, 61);
            this.noofemppnl.TabIndex = 10;
            // 
            // numberofemptxtbox
            // 
            this.numberofemptxtbox.Location = new System.Drawing.Point(125, 17);
            this.numberofemptxtbox.Name = "numberofemptxtbox";
            this.numberofemptxtbox.Size = new System.Drawing.Size(165, 20);
            this.numberofemptxtbox.TabIndex = 2;
            // 
            // tsdutyidcmbox
            // 
            this.tsdutyidcmbox.FormattingEnabled = true;
            this.tsdutyidcmbox.Location = new System.Drawing.Point(125, 21);
            this.tsdutyidcmbox.Name = "tsdutyidcmbox";
            this.tsdutyidcmbox.Size = new System.Drawing.Size(165, 21);
            this.tsdutyidcmbox.TabIndex = 3;
            // 
            // tsskillid
            // 
            this.tsskillid.AutoSize = true;
            this.tsskillid.Location = new System.Drawing.Point(60, 36);
            this.tsskillid.Name = "tsskillid";
            this.tsskillid.Size = new System.Drawing.Size(40, 13);
            this.tsskillid.TabIndex = 1;
            this.tsskillid.Text = "Skill ID";
            // 
            // tsdutyidpnl
            // 
            this.tsdutyidpnl.Controls.Add(this.tsdutyidlbl);
            this.tsdutyidpnl.Controls.Add(this.tsdutyidcmbox);
            this.tsdutyidpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsdutyidpnl.Location = new System.Drawing.Point(0, 65);
            this.tsdutyidpnl.Name = "tsdutyidpnl";
            this.tsdutyidpnl.Size = new System.Drawing.Size(382, 61);
            this.tsdutyidpnl.TabIndex = 11;
            // 
            // tsskillidcmbox
            // 
            this.tsskillidcmbox.FormattingEnabled = true;
            this.tsskillidcmbox.Location = new System.Drawing.Point(125, 28);
            this.tsskillidcmbox.Name = "tsskillidcmbox";
            this.tsskillidcmbox.Size = new System.Drawing.Size(165, 21);
            this.tsskillidcmbox.TabIndex = 1;
            // 
            // tsskillidpnl
            // 
            this.tsskillidpnl.Controls.Add(this.tsskillid);
            this.tsskillidpnl.Controls.Add(this.tsskillidcmbox);
            this.tsskillidpnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsskillidpnl.Location = new System.Drawing.Point(0, 0);
            this.tsskillidpnl.Name = "tsskillidpnl";
            this.tsskillidpnl.Size = new System.Drawing.Size(382, 65);
            this.tsskillidpnl.TabIndex = 12;
            // 
            // AddTaskSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 268);
            this.Controls.Add(this.regtspnl);
            this.Controls.Add(this.noofemppnl);
            this.Controls.Add(this.tsdutyidpnl);
            this.Controls.Add(this.tsskillidpnl);
            this.Name = "AddTaskSkills";
            this.Text = "AddTaskSkills";
            this.regtspnl.ResumeLayout(false);
            this.noofemppnl.ResumeLayout(false);
            this.noofemppnl.PerformLayout();
            this.tsdutyidpnl.ResumeLayout(false);
            this.tsdutyidpnl.PerformLayout();
            this.tsskillidpnl.ResumeLayout(false);
            this.tsskillidpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label noofemplbl;
        private System.Windows.Forms.Panel regtspnl;
        private System.Windows.Forms.Button tsregbtn;
        private System.Windows.Forms.Label tsdutyidlbl;
        private System.Windows.Forms.Panel noofemppnl;
        private System.Windows.Forms.TextBox numberofemptxtbox;
        private System.Windows.Forms.ComboBox tsdutyidcmbox;
        private System.Windows.Forms.Label tsskillid;
        private System.Windows.Forms.Panel tsdutyidpnl;
        private System.Windows.Forms.ComboBox tsskillidcmbox;
        private System.Windows.Forms.Panel tsskillidpnl;
    }
}

namespace Global_Computing_Solutions
{
    partial class TaskSkills
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
            this.tsAddbtn = new System.Windows.Forms.Button();
            this.taskskillslbtnspnl = new System.Windows.Forms.Panel();
            this.tsdelbtn = new System.Windows.Forms.Button();
            this.tsUpbtn = new System.Windows.Forms.Button();
            this.tsclosebtn = new System.Windows.Forms.Button();
            this.taskskillsdatapnl = new System.Windows.Forms.Panel();
            this.taskskillsdatagridview = new System.Windows.Forms.DataGridView();
            this.taskskillslbl = new System.Windows.Forms.Label();
            this.taskskillslbtnspnl.SuspendLayout();
            this.taskskillsdatapnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskskillsdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // tsAddbtn
            // 
            this.tsAddbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsAddbtn.Location = new System.Drawing.Point(384, 0);
            this.tsAddbtn.Name = "tsAddbtn";
            this.tsAddbtn.Size = new System.Drawing.Size(75, 40);
            this.tsAddbtn.TabIndex = 3;
            this.tsAddbtn.Text = "Add";
            this.tsAddbtn.UseVisualStyleBackColor = true;
            this.tsAddbtn.Click += new System.EventHandler(this.tsAddbtn_Click);
            // 
            // taskskillslbtnspnl
            // 
            this.taskskillslbtnspnl.Controls.Add(this.tsAddbtn);
            this.taskskillslbtnspnl.Controls.Add(this.tsdelbtn);
            this.taskskillslbtnspnl.Controls.Add(this.tsUpbtn);
            this.taskskillslbtnspnl.Controls.Add(this.tsclosebtn);
            this.taskskillslbtnspnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskskillslbtnspnl.Location = new System.Drawing.Point(0, 471);
            this.taskskillslbtnspnl.Name = "taskskillslbtnspnl";
            this.taskskillslbtnspnl.Size = new System.Drawing.Size(684, 40);
            this.taskskillslbtnspnl.TabIndex = 4;
            // 
            // tsdelbtn
            // 
            this.tsdelbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsdelbtn.Location = new System.Drawing.Point(459, 0);
            this.tsdelbtn.Name = "tsdelbtn";
            this.tsdelbtn.Size = new System.Drawing.Size(75, 40);
            this.tsdelbtn.TabIndex = 2;
            this.tsdelbtn.Text = "Delete";
            this.tsdelbtn.UseVisualStyleBackColor = true;
            // 
            // tsUpbtn
            // 
            this.tsUpbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsUpbtn.Location = new System.Drawing.Point(534, 0);
            this.tsUpbtn.Name = "tsUpbtn";
            this.tsUpbtn.Size = new System.Drawing.Size(75, 40);
            this.tsUpbtn.TabIndex = 2;
            this.tsUpbtn.Text = "Update";
            this.tsUpbtn.UseVisualStyleBackColor = true;
            this.tsUpbtn.Click += new System.EventHandler(this.tsUpbtn_Click);
            // 
            // tsclosebtn
            // 
            this.tsclosebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.tsclosebtn.Location = new System.Drawing.Point(609, 0);
            this.tsclosebtn.Name = "tsclosebtn";
            this.tsclosebtn.Size = new System.Drawing.Size(75, 40);
            this.tsclosebtn.TabIndex = 2;
            this.tsclosebtn.Text = "Close";
            this.tsclosebtn.UseVisualStyleBackColor = true;
            // 
            // taskskillsdatapnl
            // 
            this.taskskillsdatapnl.Controls.Add(this.taskskillsdatagridview);
            this.taskskillsdatapnl.Controls.Add(this.taskskillslbl);
            this.taskskillsdatapnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskskillsdatapnl.Location = new System.Drawing.Point(0, 0);
            this.taskskillsdatapnl.Name = "taskskillsdatapnl";
            this.taskskillsdatapnl.Size = new System.Drawing.Size(684, 511);
            this.taskskillsdatapnl.TabIndex = 5;
            // 
            // taskskillsdatagridview
            // 
            this.taskskillsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskskillsdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskskillsdatagridview.Location = new System.Drawing.Point(0, 20);
            this.taskskillsdatagridview.Name = "taskskillsdatagridview";
            this.taskskillsdatagridview.Size = new System.Drawing.Size(684, 491);
            this.taskskillsdatagridview.TabIndex = 1;
            // 
            // taskskillslbl
            // 
            this.taskskillslbl.AutoSize = true;
            this.taskskillslbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskskillslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskskillslbl.Location = new System.Drawing.Point(0, 0);
            this.taskskillslbl.Name = "taskskillslbl";
            this.taskskillslbl.Size = new System.Drawing.Size(83, 20);
            this.taskskillslbl.TabIndex = 0;
            this.taskskillslbl.Text = "Task Skills";
            // 
            // TaskSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.taskskillslbtnspnl);
            this.Controls.Add(this.taskskillsdatapnl);
            this.Name = "TaskSkills";
            this.Text = "TaskSkills";
            this.taskskillslbtnspnl.ResumeLayout(false);
            this.taskskillsdatapnl.ResumeLayout(false);
            this.taskskillsdatapnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskskillsdatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tsAddbtn;
        private System.Windows.Forms.Panel taskskillslbtnspnl;
        private System.Windows.Forms.Button tsdelbtn;
        private System.Windows.Forms.Button tsUpbtn;
        private System.Windows.Forms.Button tsclosebtn;
        private System.Windows.Forms.Panel taskskillsdatapnl;
        private System.Windows.Forms.DataGridView taskskillsdatagridview;
        private System.Windows.Forms.Label taskskillslbl;
    }
}
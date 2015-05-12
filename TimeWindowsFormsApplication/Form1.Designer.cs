namespace TimeWindowsFormsApplication
{
    partial class Form1
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
            this.lblSetHour = new System.Windows.Forms.Label();
            this.tbxSetHour = new System.Windows.Forms.TextBox();
            this.txbSetMin = new System.Windows.Forms.TextBox();
            this.lblSetMin = new System.Windows.Forms.Label();
            this.txbSetSec = new System.Windows.Forms.TextBox();
            this.lblSetSecond = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetTime = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSetHour
            // 
            this.lblSetHour.AutoSize = true;
            this.lblSetHour.Location = new System.Drawing.Point(51, 26);
            this.lblSetHour.Name = "lblSetHour";
            this.lblSetHour.Size = new System.Drawing.Size(52, 13);
            this.lblSetHour.TabIndex = 0;
            this.lblSetHour.Text = "Set Hour:";
            // 
            // tbxSetHour
            // 
            this.tbxSetHour.Location = new System.Drawing.Point(120, 23);
            this.tbxSetHour.Name = "tbxSetHour";
            this.tbxSetHour.Size = new System.Drawing.Size(100, 20);
            this.tbxSetHour.TabIndex = 1;
            // 
            // txbSetMin
            // 
            this.txbSetMin.Location = new System.Drawing.Point(120, 66);
            this.txbSetMin.Name = "txbSetMin";
            this.txbSetMin.Size = new System.Drawing.Size(100, 20);
            this.txbSetMin.TabIndex = 3;
            // 
            // lblSetMin
            // 
            this.lblSetMin.AutoSize = true;
            this.lblSetMin.Location = new System.Drawing.Point(51, 69);
            this.lblSetMin.Name = "lblSetMin";
            this.lblSetMin.Size = new System.Drawing.Size(61, 13);
            this.lblSetMin.TabIndex = 2;
            this.lblSetMin.Text = "Set Minute:";
            // 
            // txbSetSec
            // 
            this.txbSetSec.Location = new System.Drawing.Point(120, 110);
            this.txbSetSec.Name = "txbSetSec";
            this.txbSetSec.Size = new System.Drawing.Size(100, 20);
            this.txbSetSec.TabIndex = 5;
            // 
            // lblSetSecond
            // 
            this.lblSetSecond.AutoSize = true;
            this.lblSetSecond.Location = new System.Drawing.Point(51, 113);
            this.lblSetSecond.Name = "lblSetSecond";
            this.lblSetSecond.Size = new System.Drawing.Size(66, 13);
            this.lblSetSecond.TabIndex = 4;
            this.lblSetSecond.Text = "Set Second:";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(120, 162);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 6;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSecond);
            this.groupBox1.Controls.Add(this.lblMinute);
            this.groupBox1.Controls.Add(this.lblHour);
            this.groupBox1.Controls.Add(this.btnGetTime);
            this.groupBox1.Location = new System.Drawing.Point(54, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 177);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Object";
            // 
            // btnGetTime
            // 
            this.btnGetTime.Location = new System.Drawing.Point(6, 34);
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(75, 23);
            this.btnGetTime.TabIndex = 0;
            this.btnGetTime.Text = "Get Time";
            this.btnGetTime.UseVisualStyleBackColor = true;
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(7, 88);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(0, 13);
            this.lblHour.TabIndex = 1;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(72, 88);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(0, 13);
            this.lblMinute.TabIndex = 2;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(131, 88);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(0, 13);
            this.lblSecond.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add second";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 459);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.txbSetSec);
            this.Controls.Add(this.lblSetSecond);
            this.Controls.Add(this.txbSetMin);
            this.Controls.Add(this.lblSetMin);
            this.Controls.Add(this.tbxSetHour);
            this.Controls.Add(this.lblSetHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetHour;
        private System.Windows.Forms.TextBox tbxSetHour;
        private System.Windows.Forms.TextBox txbSetMin;
        private System.Windows.Forms.Label lblSetMin;
        private System.Windows.Forms.TextBox txbSetSec;
        private System.Windows.Forms.Label lblSetSecond;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnGetTime;
        private System.Windows.Forms.Button btnAdd;
    }
}


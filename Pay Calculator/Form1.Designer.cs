namespace Pay_Calculator
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
            this.fntb = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lntb = new System.Windows.Forms.TextBox();
            this.idtb = new System.Windows.Forms.TextBox();
            this.hwtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mplabel = new System.Windows.Forms.Label();
            this.calcpaybutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fntb
            // 
            this.fntb.Location = new System.Drawing.Point(437, 87);
            this.fntb.Name = "fntb";
            this.fntb.Size = new System.Drawing.Size(100, 29);
            this.fntb.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(188, 87);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(106, 25);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "First Name\r\n";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lntb
            // 
            this.lntb.Location = new System.Drawing.Point(437, 156);
            this.lntb.Name = "lntb";
            this.lntb.Size = new System.Drawing.Size(100, 29);
            this.lntb.TabIndex = 2;
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(437, 211);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(100, 29);
            this.idtb.TabIndex = 3;
            // 
            // hwtb
            // 
            this.hwtb.Location = new System.Drawing.Point(437, 269);
            this.hwtb.Name = "hwtb";
            this.hwtb.Size = new System.Drawing.Size(100, 29);
            this.hwtb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Emp ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours Worked";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // prtb
            // 
            this.prtb.Location = new System.Drawing.Point(437, 324);
            this.prtb.Name = "prtb";
            this.prtb.Size = new System.Drawing.Size(100, 29);
            this.prtb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pay Rate";
            // 
            // mplabel
            // 
            this.mplabel.AutoSize = true;
            this.mplabel.Location = new System.Drawing.Point(417, 386);
            this.mplabel.Name = "mplabel";
            this.mplabel.Size = new System.Drawing.Size(120, 25);
            this.mplabel.TabIndex = 10;
            this.mplabel.Text = "Monthly Pay";
            this.mplabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // calcpaybutton
            // 
            this.calcpaybutton.Location = new System.Drawing.Point(193, 386);
            this.calcpaybutton.Name = "calcpaybutton";
            this.calcpaybutton.Size = new System.Drawing.Size(133, 61);
            this.calcpaybutton.TabIndex = 11;
            this.calcpaybutton.Text = "Calculate Pay";
            this.calcpaybutton.UseVisualStyleBackColor = true;
            this.calcpaybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 512);
            this.Controls.Add(this.calcpaybutton);
            this.Controls.Add(this.mplabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hwtb);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.lntb);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.fntb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fntb;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox lntb;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox hwtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mplabel;
        private System.Windows.Forms.Button calcpaybutton;
    }
}


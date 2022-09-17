namespace TestClientApp
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.textBoxATL = new System.Windows.Forms.TextBox();
            this.textBoxCOM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chkFireEvent = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResultName = new System.Windows.Forms.TextBox();
            this.textBoxResultMarks = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(88, 29);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(293, 20);
            this.txtboxName.TabIndex = 0;
            // 
            // textBoxATL
            // 
            this.textBoxATL.Location = new System.Drawing.Point(33, 128);
            this.textBoxATL.Name = "textBoxATL";
            this.textBoxATL.Size = new System.Drawing.Size(100, 20);
            this.textBoxATL.TabIndex = 1;
            // 
            // textBoxCOM
            // 
            this.textBoxCOM.Location = new System.Drawing.Point(281, 128);
            this.textBoxCOM.Name = "textBoxCOM";
            this.textBoxCOM.Size = new System.Drawing.Size(100, 20);
            this.textBoxCOM.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ATL-Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "COM Marks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkFireEvent
            // 
            this.chkFireEvent.AutoSize = true;
            this.chkFireEvent.Location = new System.Drawing.Point(44, 187);
            this.chkFireEvent.Name = "chkFireEvent";
            this.chkFireEvent.Size = new System.Drawing.Size(71, 17);
            this.chkFireEvent.TabIndex = 7;
            this.chkFireEvent.Text = "FireEvent";
            this.chkFireEvent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkFireEvent);
            this.groupBox1.Controls.Add(this.txtboxName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxATL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxCOM);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 238);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Values";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResultMarks);
            this.groupBox2.Controls.Add(this.textBoxResultName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marks";
            // 
            // textBoxResultName
            // 
            this.textBoxResultName.Enabled = false;
            this.textBoxResultName.Location = new System.Drawing.Point(88, 17);
            this.textBoxResultName.Name = "textBoxResultName";
            this.textBoxResultName.Size = new System.Drawing.Size(293, 20);
            this.textBoxResultName.TabIndex = 2;
            // 
            // textBoxResultMarks
            // 
            this.textBoxResultMarks.Enabled = false;
            this.textBoxResultMarks.Location = new System.Drawing.Point(88, 56);
            this.textBoxResultMarks.Name = "textBoxResultMarks";
            this.textBoxResultMarks.Size = new System.Drawing.Size(293, 20);
            this.textBoxResultMarks.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox textBoxATL;
        private System.Windows.Forms.TextBox textBoxCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkFireEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultMarks;
        private System.Windows.Forms.TextBox textBoxResultName;
    }
}


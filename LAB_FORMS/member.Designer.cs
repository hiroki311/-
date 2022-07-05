
namespace LAB_FORMS
{
    partial class member
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
            this.testbutton1 = new System.Windows.Forms.Button();
            this.re01 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RE02 = new System.Windows.Forms.Button();
            this.RE3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testbutton1
            // 
            this.testbutton1.Location = new System.Drawing.Point(633, 145);
            this.testbutton1.Name = "testbutton1";
            this.testbutton1.Size = new System.Drawing.Size(75, 23);
            this.testbutton1.TabIndex = 0;
            this.testbutton1.Text = "button1";
            this.testbutton1.UseVisualStyleBackColor = true;
            this.testbutton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // re01
            // 
            this.re01.Location = new System.Drawing.Point(182, 187);
            this.re01.Name = "re01";
            this.re01.Size = new System.Drawing.Size(149, 67);
            this.re01.TabIndex = 1;
            this.re01.Text = "需要註冊";
            this.re01.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "註冊事件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RE02
            // 
            this.RE02.Location = new System.Drawing.Point(182, 277);
            this.RE02.Name = "RE02";
            this.RE02.Size = new System.Drawing.Size(149, 59);
            this.RE02.TabIndex = 3;
            this.RE02.Text = "快速註冊";
            this.RE02.UseVisualStyleBackColor = true;
            this.RE02.Click += new System.EventHandler(this.RE02_Click_1);
            // 
            // RE3
            // 
            this.RE3.Location = new System.Drawing.Point(182, 359);
            this.RE3.Name = "RE3";
            this.RE3.Size = new System.Drawing.Size(149, 59);
            this.RE3.TabIndex = 4;
            this.RE3.Text = "取消註冊";
            this.RE3.UseVisualStyleBackColor = true;
            this.RE3.Click += new System.EventHandler(this.RE3_Click);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RE3);
            this.Controls.Add(this.RE02);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.re01);
            this.Controls.Add(this.testbutton1);
            this.Name = "member";
            this.Text = "member";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testbutton1;
        private System.Windows.Forms.Button re01;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button RE02;
        private System.Windows.Forms.Button RE3;
    }
}
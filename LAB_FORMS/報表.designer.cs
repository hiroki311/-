
namespace LAB_FORMS
{
    partial class report
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intextBox1 = new System.Windows.Forms.TextBox();
            this.intextBox2 = new System.Windows.Forms.TextBox();
            this.intextBox3 = new System.Windows.Forms.TextBox();
            this.intextBox4 = new System.Windows.Forms.TextBox();
            this.intextBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(161, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(161, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "期限(年):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(161, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "利率%:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(161, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "月付款:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(161, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "總付款:";
            // 
            // intextBox1
            // 
            this.intextBox1.Enabled = false;
            this.intextBox1.Location = new System.Drawing.Point(322, 98);
            this.intextBox1.Name = "intextBox1";
            this.intextBox1.Size = new System.Drawing.Size(100, 22);
            this.intextBox1.TabIndex = 5;
            this.intextBox1.TextChanged += new System.EventHandler(this.intextBox1_TextChanged);
            // 
            // intextBox2
            // 
            this.intextBox2.Enabled = false;
            this.intextBox2.Location = new System.Drawing.Point(322, 139);
            this.intextBox2.Name = "intextBox2";
            this.intextBox2.Size = new System.Drawing.Size(100, 22);
            this.intextBox2.TabIndex = 6;
            // 
            // intextBox3
            // 
            this.intextBox3.Enabled = false;
            this.intextBox3.Location = new System.Drawing.Point(322, 190);
            this.intextBox3.Name = "intextBox3";
            this.intextBox3.Size = new System.Drawing.Size(100, 22);
            this.intextBox3.TabIndex = 7;
            // 
            // intextBox4
            // 
            this.intextBox4.Enabled = false;
            this.intextBox4.Location = new System.Drawing.Point(322, 240);
            this.intextBox4.Name = "intextBox4";
            this.intextBox4.Size = new System.Drawing.Size(100, 22);
            this.intextBox4.TabIndex = 8;
            // 
            // intextBox5
            // 
            this.intextBox5.Enabled = false;
            this.intextBox5.Location = new System.Drawing.Point(322, 285);
            this.intextBox5.Name = "intextBox5";
            this.intextBox5.Size = new System.Drawing.Size(100, 22);
            this.intextBox5.TabIndex = 9;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.intextBox5);
            this.Controls.Add(this.intextBox4);
            this.Controls.Add(this.intextBox3);
            this.Controls.Add(this.intextBox2);
            this.Controls.Add(this.intextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "report";
            this.Text = "報表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox intextBox1;
        public System.Windows.Forms.TextBox intextBox2;
        public System.Windows.Forms.TextBox intextBox3;
        public System.Windows.Forms.TextBox intextBox4;
        public System.Windows.Forms.TextBox intextBox5;
    }
}
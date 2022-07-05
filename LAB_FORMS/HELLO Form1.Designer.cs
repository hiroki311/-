
namespace LAB_FORMS
{
    partial class helloform
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helloform));
            this.button = new System.Windows.Forms.Button();
            this.labname = new System.Windows.Forms.Label();
            this.boxname = new System.Windows.Forms.TextBox();
            this.labenglishname = new System.Windows.Forms.Label();
            this.labgender = new System.Windows.Forms.Label();
            this.labconstellation = new System.Windows.Forms.Label();
            this.textBoxengname = new System.Windows.Forms.TextBox();
            this.textBoxboygirl = new System.Windows.Forms.TextBox();
            this.textBox3seisa = new System.Windows.Forms.TextBox();
            this.buttoneng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.Location = new System.Drawing.Point(138, 384);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(165, 57);
            this.button.TabIndex = 0;
            this.button.Text = "說你好";
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            this.button.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.BackColor = System.Drawing.Color.Transparent;
            this.labname.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labname.Location = new System.Drawing.Point(169, 85);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(98, 32);
            this.labname.TabIndex = 1;
            this.labname.Text = "姓名:";
            // 
            // boxname
            // 
            this.boxname.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxname.Location = new System.Drawing.Point(359, 85);
            this.boxname.Name = "boxname";
            this.boxname.Size = new System.Drawing.Size(197, 46);
            this.boxname.TabIndex = 2;
            this.boxname.TextChanged += new System.EventHandler(this.boxname_TextChanged);
            // 
            // labenglishname
            // 
            this.labenglishname.AutoSize = true;
            this.labenglishname.BackColor = System.Drawing.Color.Transparent;
            this.labenglishname.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labenglishname.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labenglishname.Location = new System.Drawing.Point(132, 155);
            this.labenglishname.Name = "labenglishname";
            this.labenglishname.Size = new System.Drawing.Size(253, 32);
            this.labenglishname.TabIndex = 3;
            this.labenglishname.Text = "English Name: ";
            // 
            // labgender
            // 
            this.labgender.AutoSize = true;
            this.labgender.BackColor = System.Drawing.Color.Transparent;
            this.labgender.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labgender.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labgender.Location = new System.Drawing.Point(169, 212);
            this.labgender.Name = "labgender";
            this.labgender.Size = new System.Drawing.Size(115, 32);
            this.labgender.TabIndex = 4;
            this.labgender.Text = "性別: ";
            this.labgender.Click += new System.EventHandler(this.label2_Click);
            // 
            // labconstellation
            // 
            this.labconstellation.AutoSize = true;
            this.labconstellation.BackColor = System.Drawing.Color.Transparent;
            this.labconstellation.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labconstellation.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labconstellation.Location = new System.Drawing.Point(169, 271);
            this.labconstellation.Name = "labconstellation";
            this.labconstellation.Size = new System.Drawing.Size(81, 32);
            this.labconstellation.TabIndex = 5;
            this.labconstellation.Text = "星座";
            // 
            // textBoxengname
            // 
            this.textBoxengname.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxengname.Location = new System.Drawing.Point(359, 155);
            this.textBoxengname.Name = "textBoxengname";
            this.textBoxengname.Size = new System.Drawing.Size(197, 46);
            this.textBoxengname.TabIndex = 6;
            // 
            // textBoxboygirl
            // 
            this.textBoxboygirl.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxboygirl.Location = new System.Drawing.Point(359, 215);
            this.textBoxboygirl.Name = "textBoxboygirl";
            this.textBoxboygirl.Size = new System.Drawing.Size(197, 46);
            this.textBoxboygirl.TabIndex = 7;
            // 
            // textBox3seisa
            // 
            this.textBox3seisa.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3seisa.Location = new System.Drawing.Point(359, 271);
            this.textBox3seisa.Name = "textBox3seisa";
            this.textBox3seisa.Size = new System.Drawing.Size(197, 46);
            this.textBox3seisa.TabIndex = 8;
            this.textBox3seisa.TextChanged += new System.EventHandler(this.textBox3seisa_TextChanged);
            // 
            // buttoneng
            // 
            this.buttoneng.AllowDrop = true;
            this.buttoneng.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttoneng.Image = ((System.Drawing.Image)(resources.GetObject("buttoneng.Image")));
            this.buttoneng.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneng.Location = new System.Drawing.Point(404, 384);
            this.buttoneng.Name = "buttoneng";
            this.buttoneng.Size = new System.Drawing.Size(152, 57);
            this.buttoneng.TabIndex = 9;
            this.buttoneng.Text = "Sayhello";
            this.buttoneng.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttoneng.UseVisualStyleBackColor = true;
            this.buttoneng.Click += new System.EventHandler(this.buttoneng_Click);
            this.buttoneng.MouseLeave += new System.EventHandler(this.buttoneng_MouseLeave);
            this.buttoneng.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttoneng_MouseMove);
            // 
            // helloform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 477);
            this.Controls.Add(this.buttoneng);
            this.Controls.Add(this.textBox3seisa);
            this.Controls.Add(this.textBoxboygirl);
            this.Controls.Add(this.textBoxengname);
            this.Controls.Add(this.labconstellation);
            this.Controls.Add(this.labgender);
            this.Controls.Add(this.labenglishname);
            this.Controls.Add(this.boxname);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.button);
            this.Name = "helloform";
            this.Text = "HELLO FORM";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.TextBox boxname;
        private System.Windows.Forms.Label labenglishname;
        private System.Windows.Forms.Label labgender;
        private System.Windows.Forms.Label labconstellation;
        private System.Windows.Forms.TextBox textBoxengname;
        private System.Windows.Forms.TextBox textBoxboygirl;
        private System.Windows.Forms.TextBox textBox3seisa;
        private System.Windows.Forms.Button buttoneng;
    }
}


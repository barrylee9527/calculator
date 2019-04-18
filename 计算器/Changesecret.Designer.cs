namespace 计算器
{
    partial class Changesecret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changesecret));
            this.oldsecret = new System.Windows.Forms.Label();
            this.newsecret = new System.Windows.Forms.Label();
            this.assure = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldsecret
            // 
            this.oldsecret.AutoSize = true;
            this.oldsecret.BackColor = System.Drawing.Color.Transparent;
            this.oldsecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oldsecret.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.oldsecret.Location = new System.Drawing.Point(64, 76);
            this.oldsecret.Name = "oldsecret";
            this.oldsecret.Size = new System.Drawing.Size(41, 12);
            this.oldsecret.TabIndex = 0;
            this.oldsecret.Text = "原密码";
            // 
            // newsecret
            // 
            this.newsecret.AutoSize = true;
            this.newsecret.BackColor = System.Drawing.Color.Transparent;
            this.newsecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newsecret.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newsecret.Location = new System.Drawing.Point(64, 147);
            this.newsecret.Name = "newsecret";
            this.newsecret.Size = new System.Drawing.Size(41, 12);
            this.newsecret.TabIndex = 1;
            this.newsecret.Text = "新密码";
            // 
            // assure
            // 
            this.assure.AutoSize = true;
            this.assure.BackColor = System.Drawing.Color.Transparent;
            this.assure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assure.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.assure.Location = new System.Drawing.Point(61, 230);
            this.assure.Name = "assure";
            this.assure.Size = new System.Drawing.Size(53, 12);
            this.assure.TabIndex = 2;
            this.assure.Text = "确认密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 21);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 21);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(52, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(205, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Changesecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(321, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.assure);
            this.Controls.Add(this.newsecret);
            this.Controls.Add(this.oldsecret);
            this.Name = "Changesecret";
            this.Text = "Changesecret";
            this.Load += new System.EventHandler(this.Changesecret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldsecret;
        private System.Windows.Forms.Label newsecret;
        private System.Windows.Forms.Label assure;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
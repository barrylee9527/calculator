namespace 计算器
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRig = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCe = new System.Windows.Forms.Button();
            this.BtnDivi = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnSubt = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.软件信息 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.androidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.作者信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.历史记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.软件信息.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(3, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(392, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLeft.Location = new System.Drawing.Point(4, 183);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(95, 49);
            this.BtnLeft.TabIndex = 1;
            this.BtnLeft.Text = "（";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRig
            // 
            this.BtnRig.AutoSize = true;
            this.BtnRig.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRig.Location = new System.Drawing.Point(102, 183);
            this.BtnRig.Name = "BtnRig";
            this.BtnRig.Size = new System.Drawing.Size(93, 49);
            this.BtnRig.TabIndex = 2;
            this.BtnRig.Text = "）";
            this.BtnRig.UseVisualStyleBackColor = true;
            this.BtnRig.Click += new System.EventHandler(this.BtnRig_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnC.Location = new System.Drawing.Point(201, 183);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(95, 49);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "◀";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCe
            // 
            this.BtnCe.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnCe.Location = new System.Drawing.Point(300, 183);
            this.BtnCe.Name = "BtnCe";
            this.BtnCe.Size = new System.Drawing.Size(95, 49);
            this.BtnCe.TabIndex = 4;
            this.BtnCe.Text = "C";
            this.BtnCe.UseVisualStyleBackColor = true;
            this.BtnCe.Click += new System.EventHandler(this.BtnCe_Click);
            // 
            // BtnDivi
            // 
            this.BtnDivi.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnDivi.Location = new System.Drawing.Point(300, 239);
            this.BtnDivi.Name = "BtnDivi";
            this.BtnDivi.Size = new System.Drawing.Size(95, 49);
            this.BtnDivi.TabIndex = 8;
            this.BtnDivi.Text = "/";
            this.BtnDivi.UseVisualStyleBackColor = true;
            this.BtnDivi.Click += new System.EventHandler(this.BtnDivi_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.Info;
            this.Btn9.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn9.Location = new System.Drawing.Point(201, 239);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(95, 49);
            this.Btn9.TabIndex = 7;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.Info;
            this.Btn8.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn8.Location = new System.Drawing.Point(102, 239);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(95, 49);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.Info;
            this.Btn7.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn7.Location = new System.Drawing.Point(4, 238);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(95, 49);
            this.Btn7.TabIndex = 5;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnMul.Location = new System.Drawing.Point(300, 293);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(95, 49);
            this.BtnMul.TabIndex = 12;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.Info;
            this.Btn6.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn6.Location = new System.Drawing.Point(201, 293);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(95, 49);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.Info;
            this.Btn5.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn5.Location = new System.Drawing.Point(102, 293);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(95, 49);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.Info;
            this.Btn4.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn4.Location = new System.Drawing.Point(3, 293);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(95, 49);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnSubt
            // 
            this.BtnSubt.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnSubt.Location = new System.Drawing.Point(300, 347);
            this.BtnSubt.Name = "BtnSubt";
            this.BtnSubt.Size = new System.Drawing.Size(95, 49);
            this.BtnSubt.TabIndex = 16;
            this.BtnSubt.Text = "-";
            this.BtnSubt.UseVisualStyleBackColor = true;
            this.BtnSubt.Click += new System.EventHandler(this.BtnSubt_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.Info;
            this.Btn3.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn3.Location = new System.Drawing.Point(201, 347);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(95, 49);
            this.Btn3.TabIndex = 15;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.Info;
            this.Btn2.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn2.Location = new System.Drawing.Point(102, 347);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(95, 49);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.Info;
            this.Btn1.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn1.Location = new System.Drawing.Point(3, 347);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(95, 49);
            this.Btn1.TabIndex = 13;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnAdd.Location = new System.Drawing.Point(300, 402);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 49);
            this.BtnAdd.TabIndex = 20;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnEqual.Location = new System.Drawing.Point(201, 402);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(95, 49);
            this.BtnEqual.TabIndex = 19;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Font = new System.Drawing.Font("宋体", 21.75F);
            this.BtnDot.Location = new System.Drawing.Point(102, 402);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(95, 49);
            this.BtnDot.TabIndex = 18;
            this.BtnDot.Text = ".";
            this.BtnDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.Info;
            this.Btn0.Font = new System.Drawing.Font("宋体", 21.75F);
            this.Btn0.Location = new System.Drawing.Point(4, 402);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(95, 49);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(3, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(392, 33);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // 软件信息
            // 
            this.软件信息.Dock = System.Windows.Forms.DockStyle.None;
            this.软件信息.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.软件信息.Location = new System.Drawing.Point(-3, 4);
            this.软件信息.Name = "软件信息";
            this.软件信息.Size = new System.Drawing.Size(96, 25);
            this.软件信息.TabIndex = 22;
            this.软件信息.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.科学ToolStripMenuItem,
            this.程序员ToolStripMenuItem,
            this.androidToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 科学ToolStripMenuItem
            // 
            this.科学ToolStripMenuItem.Name = "科学ToolStripMenuItem";
            this.科学ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.科学ToolStripMenuItem.Text = "‭IOS";
            this.科学ToolStripMenuItem.Click += new System.EventHandler(this.科学ToolStripMenuItem_Click_1);
            // 
            // 程序员ToolStripMenuItem
            // 
            this.程序员ToolStripMenuItem.Name = "程序员ToolStripMenuItem";
            this.程序员ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.程序员ToolStripMenuItem.Text = "Linux";
            // 
            // androidToolStripMenuItem
            // 
            this.androidToolStripMenuItem.Name = "androidToolStripMenuItem";
            this.androidToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.androidToolStripMenuItem.Text = "Android";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本信息ToolStripMenuItem,
            this.作者信息ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 版本信息ToolStripMenuItem
            // 
            this.版本信息ToolStripMenuItem.Name = "版本信息ToolStripMenuItem";
            this.版本信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.版本信息ToolStripMenuItem.Text = "版本信息";
            this.版本信息ToolStripMenuItem.Click += new System.EventHandler(this.版本信息ToolStripMenuItem_Click);
            // 
            // 作者信息ToolStripMenuItem
            // 
            this.作者信息ToolStripMenuItem.Name = "作者信息ToolStripMenuItem";
            this.作者信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.作者信息ToolStripMenuItem.Text = "团队信息";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.历史记录ToolStripMenuItem,
            this.转账ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(274, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(120, 25);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 历史记录ToolStripMenuItem
            // 
            this.历史记录ToolStripMenuItem.Name = "历史记录ToolStripMenuItem";
            this.历史记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.历史记录ToolStripMenuItem.Text = "历史记录";
            this.历史记录ToolStripMenuItem.Click += new System.EventHandler(this.历史记录ToolStripMenuItem_Click);
            // 
            // 转账ToolStripMenuItem
            // 
            this.转账ToolStripMenuItem.Name = "转账ToolStripMenuItem";
            this.转账ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.转账ToolStripMenuItem.Text = "转账";
            this.转账ToolStripMenuItem.Click += new System.EventHandler(this.转账ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 25);
            this.button1.TabIndex = 24;
            this.button1.Text = "按住说话";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSubt);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnDivi);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnCe);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnRig);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.软件信息);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.软件信息;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.软件信息.ResumeLayout(false);
            this.软件信息.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRig;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCe;
        private System.Windows.Forms.Button BtnDivi;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnSubt;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip 软件信息;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科学ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 程序员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 作者信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem androidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 历史记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转账ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}


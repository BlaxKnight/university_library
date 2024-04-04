namespace Library
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.کتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دانشآموزهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کتابهایدادهشدهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جزییاتکاملکتابهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دانشآموزهاToolStripMenuItem,
            this.کتابهاToolStripMenuItem,
            this.کتابهایدادهشدهToolStripMenuItem,
            this.جزییاتکاملکتابهاToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(481, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // کتابهاToolStripMenuItem
            // 
            this.کتابهاToolStripMenuItem.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.کتابهاToolStripMenuItem.Name = "کتابهاToolStripMenuItem";
            this.کتابهاToolStripMenuItem.Size = new System.Drawing.Size(121, 33);
            this.کتابهاToolStripMenuItem.Text = "کتاب های موجود";
            this.کتابهاToolStripMenuItem.Click += new System.EventHandler(this.کتابهاToolStripMenuItem_Click);
            // 
            // دانشآموزهاToolStripMenuItem
            // 
            this.دانشآموزهاToolStripMenuItem.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.دانشآموزهاToolStripMenuItem.Name = "دانشآموزهاToolStripMenuItem";
            this.دانشآموزهاToolStripMenuItem.Size = new System.Drawing.Size(86, 33);
            this.دانشآموزهاToolStripMenuItem.Text = "دانشجویان";
            this.دانشآموزهاToolStripMenuItem.Click += new System.EventHandler(this.دانشآموزهاToolStripMenuItem_Click);
            // 
            // کتابهایدادهشدهToolStripMenuItem
            // 
            this.کتابهایدادهشدهToolStripMenuItem.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.کتابهایدادهشدهToolStripMenuItem.Name = "کتابهایدادهشدهToolStripMenuItem";
            this.کتابهایدادهشدهToolStripMenuItem.Size = new System.Drawing.Size(136, 33);
            this.کتابهایدادهشدهToolStripMenuItem.Text = "قرض و تحویل کتاب";
            this.کتابهایدادهشدهToolStripMenuItem.Click += new System.EventHandler(this.کتابهایدادهشدهToolStripMenuItem_Click);
            // 
            // جزییاتکاملکتابهاToolStripMenuItem
            // 
            this.جزییاتکاملکتابهاToolStripMenuItem.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.جزییاتکاملکتابهاToolStripMenuItem.Name = "جزییاتکاملکتابهاToolStripMenuItem";
            this.جزییاتکاملکتابهاToolStripMenuItem.Size = new System.Drawing.Size(72, 33);
            this.جزییاتکاملکتابهاToolStripMenuItem.Text = "تاریخچه";
            this.جزییاتکاملکتابهاToolStripMenuItem.Click += new System.EventHandler(this.جزییاتکاملکتابهاToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(59, 33);
            this.toolStripMenuItem3.Text = "خروج";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(481, 38);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("B Yagut", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "خوش آمدید!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem کتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دانشآموزهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کتابهایدادهشدهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جزییاتکاملکتابهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}
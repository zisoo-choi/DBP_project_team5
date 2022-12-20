
namespace team5_project_ui
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.환자등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.차트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.의료진목록ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환자등록ToolStripMenuItem,
            this.의료진목록ToolStripMenuItem1,
            this.차트ToolStripMenuItem,
            this.정보ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1312, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 환자등록ToolStripMenuItem
            // 
            this.환자등록ToolStripMenuItem.Name = "환자등록ToolStripMenuItem";
            this.환자등록ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.환자등록ToolStripMenuItem.Text = "환자등록";
            this.환자등록ToolStripMenuItem.Click += new System.EventHandler(this.환자등록ToolStripMenuItem_Click);
            // 
            // 차트ToolStripMenuItem
            // 
            this.차트ToolStripMenuItem.Name = "차트ToolStripMenuItem";
            this.차트ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.차트ToolStripMenuItem.Text = "차트";
            this.차트ToolStripMenuItem.Click += new System.EventHandler(this.차트ToolStripMenuItem_Click);
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.정보ToolStripMenuItem.Text = "정보";
            this.정보ToolStripMenuItem.Click += new System.EventHandler(this.정보ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 의료진목록ToolStripMenuItem1
            // 
            this.의료진목록ToolStripMenuItem1.Name = "의료진목록ToolStripMenuItem1";
            this.의료진목록ToolStripMenuItem1.Size = new System.Drawing.Size(103, 24);
            this.의료진목록ToolStripMenuItem1.Text = "의료진 목록";
            this.의료진목록ToolStripMenuItem1.Click += new System.EventHandler(this.의료진목록ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 793);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "응급실 관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 환자등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 차트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 의료진목록ToolStripMenuItem1;
    }
}
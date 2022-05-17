
namespace cv12
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.PictureBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCustomPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(10, 34);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(150, 150);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            this.p1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p1_MouseDown);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(160, 34);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(150, 150);
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            this.p2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p2_MouseDown);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(310, 34);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(150, 150);
            this.p3.TabIndex = 2;
            this.p3.TabStop = false;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            this.p3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p3_MouseDown);
            // 
            // p6
            // 
            this.p6.Location = new System.Drawing.Point(310, 184);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(150, 150);
            this.p6.TabIndex = 5;
            this.p6.TabStop = false;
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(160, 184);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(150, 150);
            this.p5.TabIndex = 4;
            this.p5.TabStop = false;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(10, 184);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(150, 150);
            this.p4.TabIndex = 3;
            this.p4.TabStop = false;
            this.p4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p4_MouseDown);
            // 
            // p9
            // 
            this.p9.Location = new System.Drawing.Point(310, 334);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(150, 150);
            this.p9.TabIndex = 8;
            this.p9.TabStop = false;
            // 
            // p8
            // 
            this.p8.Location = new System.Drawing.Point(160, 334);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(150, 150);
            this.p8.TabIndex = 7;
            this.p8.TabStop = false;
            // 
            // p7
            // 
            this.p7.Location = new System.Drawing.Point(10, 334);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(150, 150);
            this.p7.TabIndex = 6;
            this.p7.TabStop = false;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCustomPictureToolStripMenuItem,
            this.highScoresToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openCustomPictureToolStripMenuItem
            // 
            this.openCustomPictureToolStripMenuItem.Name = "openCustomPictureToolStripMenuItem";
            this.openCustomPictureToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openCustomPictureToolStripMenuItem.Text = "&Open Custom Picture";
            this.openCustomPictureToolStripMenuItem.Click += new System.EventHandler(this.openCustomPictureToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.highScoresToolStripMenuItem.Text = "&High Scores";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p9;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCustomPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}


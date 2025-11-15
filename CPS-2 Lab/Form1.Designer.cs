namespace CPS_2_Lab
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
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potientialFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomNoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.only50RandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.floatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.correctnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomWalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dRWFor1WalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dRWFor15WalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dRWFor100WalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dRWFor500WalkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfAvoidingWalkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.potientialFieldToolStripMenuItem,
            this.randomNoToolStripMenuItem,
            this.randomWalkToolStripMenuItem,
            this.selfAvoidingWalkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.refreshToolStripMenuItem.Font = new System.Drawing.Font("Sitka Subheading", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(143, 51);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // potientialFieldToolStripMenuItem
            // 
            this.potientialFieldToolStripMenuItem.Name = "potientialFieldToolStripMenuItem";
            this.potientialFieldToolStripMenuItem.Size = new System.Drawing.Size(151, 51);
            this.potientialFieldToolStripMenuItem.Text = "PotientialField";
            this.potientialFieldToolStripMenuItem.Click += new System.EventHandler(this.potientialFieldToolStripMenuItem_Click);
            // 
            // randomNoToolStripMenuItem
            // 
            this.randomNoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomNoToolStripMenuItem1,
            this.only50RandomToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.floatToolStripMenuItem,
            this.plotToolStripMenuItem1,
            this.correctnessToolStripMenuItem});
            this.randomNoToolStripMenuItem.Name = "randomNoToolStripMenuItem";
            this.randomNoToolStripMenuItem.Size = new System.Drawing.Size(125, 51);
            this.randomNoToolStripMenuItem.Text = "Random No";
            // 
            // randomNoToolStripMenuItem1
            // 
            this.randomNoToolStripMenuItem1.BackColor = System.Drawing.Color.Aquamarine;
            this.randomNoToolStripMenuItem1.Name = "randomNoToolStripMenuItem1";
            this.randomNoToolStripMenuItem1.Size = new System.Drawing.Size(418, 34);
            this.randomNoToolStripMenuItem1.Text = "Random Number 0 -32 integer";
            this.randomNoToolStripMenuItem1.Click += new System.EventHandler(this.randomNoToolStripMenuItem1_Click);
            // 
            // only50RandomToolStripMenuItem
            // 
            this.only50RandomToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.only50RandomToolStripMenuItem.Name = "only50RandomToolStripMenuItem";
            this.only50RandomToolStripMenuItem.Size = new System.Drawing.Size(418, 34);
            this.only50RandomToolStripMenuItem.Text = "only 50 Random Number";
            this.only50RandomToolStripMenuItem.Click += new System.EventHandler(this.only50RandomToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(418, 34);
            this.toolStripMenuItem2.Text = "0 - 99";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(418, 34);
            this.toolStripMenuItem3.Text = "0 - 0.9999";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(418, 34);
            this.toolStripMenuItem4.Text = "10 - 19";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // floatToolStripMenuItem
            // 
            this.floatToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            this.floatToolStripMenuItem.Size = new System.Drawing.Size(418, 34);
            this.floatToolStripMenuItem.Text = "10 - 19 (Float) Random generation";
            this.floatToolStripMenuItem.Click += new System.EventHandler(this.floatToolStripMenuItem_Click);
            // 
            // plotToolStripMenuItem1
            // 
            this.plotToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plotToolStripMenuItem1.Name = "plotToolStripMenuItem1";
            this.plotToolStripMenuItem1.Size = new System.Drawing.Size(418, 34);
            this.plotToolStripMenuItem1.Text = "Plot (Steps=500)(R=299)";
            this.plotToolStripMenuItem1.Click += new System.EventHandler(this.plotToolStripMenuItem1_Click);
            // 
            // correctnessToolStripMenuItem
            // 
            this.correctnessToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.correctnessToolStripMenuItem.Name = "correctnessToolStripMenuItem";
            this.correctnessToolStripMenuItem.Size = new System.Drawing.Size(418, 34);
            this.correctnessToolStripMenuItem.Text = "Correctness (Steps=1000)(R=100-149)";
            this.correctnessToolStripMenuItem.Click += new System.EventHandler(this.correctnessToolStripMenuItem_Click);
            // 
            // randomWalkToolStripMenuItem
            // 
            this.randomWalkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dRWFor1WalkerToolStripMenuItem,
            this.dRWFor15WalkerToolStripMenuItem,
            this.dRWFor100WalkerToolStripMenuItem,
            this.dRWFor500WalkerToolStripMenuItem});
            this.randomWalkToolStripMenuItem.Name = "randomWalkToolStripMenuItem";
            this.randomWalkToolStripMenuItem.Size = new System.Drawing.Size(144, 51);
            this.randomWalkToolStripMenuItem.Text = "Random Walk";
            // 
            // dRWFor1WalkerToolStripMenuItem
            // 
            this.dRWFor1WalkerToolStripMenuItem.Name = "dRWFor1WalkerToolStripMenuItem";
            this.dRWFor1WalkerToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.dRWFor1WalkerToolStripMenuItem.Text = "1D RW For 1 Walker ";
            this.dRWFor1WalkerToolStripMenuItem.Click += new System.EventHandler(this.dRWFor1WalkerToolStripMenuItem_Click);
            // 
            // dRWFor15WalkerToolStripMenuItem
            // 
            this.dRWFor15WalkerToolStripMenuItem.Name = "dRWFor15WalkerToolStripMenuItem";
            this.dRWFor15WalkerToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.dRWFor15WalkerToolStripMenuItem.Text = "1D RW For 100 Walker ";
            this.dRWFor15WalkerToolStripMenuItem.Click += new System.EventHandler(this.dRWFor15WalkerToolStripMenuItem_Click);
            // 
            // dRWFor100WalkerToolStripMenuItem
            // 
            this.dRWFor100WalkerToolStripMenuItem.Name = "dRWFor100WalkerToolStripMenuItem";
            this.dRWFor100WalkerToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.dRWFor100WalkerToolStripMenuItem.Text = "2D RW For 1 Walker ";
            this.dRWFor100WalkerToolStripMenuItem.Click += new System.EventHandler(this.dRWFor100WalkerToolStripMenuItem_Click);
            // 
            // dRWFor500WalkerToolStripMenuItem
            // 
            this.dRWFor500WalkerToolStripMenuItem.Name = "dRWFor500WalkerToolStripMenuItem";
            this.dRWFor500WalkerToolStripMenuItem.Size = new System.Drawing.Size(284, 34);
            this.dRWFor500WalkerToolStripMenuItem.Text = "2D RW For 100 Walker ";
            this.dRWFor500WalkerToolStripMenuItem.Click += new System.EventHandler(this.dRWFor500WalkerToolStripMenuItem_Click);
            // 
            // selfAvoidingWalkToolStripMenuItem
            // 
            this.selfAvoidingWalkToolStripMenuItem.Name = "selfAvoidingWalkToolStripMenuItem";
            this.selfAvoidingWalkToolStripMenuItem.Size = new System.Drawing.Size(185, 51);
            this.selfAvoidingWalkToolStripMenuItem.Text = "Self Avoiding Walk";
            this.selfAvoidingWalkToolStripMenuItem.Click += new System.EventHandler(this.selfAvoidingWalkToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem potientialFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomWalkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfAvoidingWalkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem only50RandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem floatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomNoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem correctnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dRWFor1WalkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dRWFor15WalkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dRWFor100WalkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dRWFor500WalkerToolStripMenuItem;
    }
}


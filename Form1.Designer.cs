﻿namespace Gustavo_Rocillo_e_Carlos
{
    partial class frmmenu
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
            this.algoritmosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosToolStripMenuItem
            // 
            this.algoritmosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmo1ToolStripMenuItem,
            this.algoritmo2ToolStripMenuItem,
            this.algoritmo3ToolStripMenuItem});
            this.algoritmosToolStripMenuItem.Name = "algoritmosToolStripMenuItem";
            this.algoritmosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.algoritmosToolStripMenuItem.Text = "Algoritmos";
            // 
            // algoritmo1ToolStripMenuItem
            // 
            this.algoritmo1ToolStripMenuItem.Name = "algoritmo1ToolStripMenuItem";
            this.algoritmo1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.algoritmo1ToolStripMenuItem.Text = "Algoritmo 1";
            this.algoritmo1ToolStripMenuItem.Click += new System.EventHandler(this.algoritmo1ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // algoritmo2ToolStripMenuItem
            // 
            this.algoritmo2ToolStripMenuItem.Name = "algoritmo2ToolStripMenuItem";
            this.algoritmo2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.algoritmo2ToolStripMenuItem.Text = "Algoritmo 2";
            this.algoritmo2ToolStripMenuItem.Click += new System.EventHandler(this.algoritmo2ToolStripMenuItem_Click);
            // 
            // algoritmo3ToolStripMenuItem
            // 
            this.algoritmo3ToolStripMenuItem.Name = "algoritmo3ToolStripMenuItem";
            this.algoritmo3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.algoritmo3ToolStripMenuItem.Text = "Algoritmo 3";
            this.algoritmo3ToolStripMenuItem.Click += new System.EventHandler(this.algoritmo3ToolStripMenuItem_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 293);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmmenu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmo3ToolStripMenuItem;
    }
}


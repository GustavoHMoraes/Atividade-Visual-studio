namespace Gustavo_Rocillo_e_Carlos
{
    partial class frm3
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
            this.txtx = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnw = new System.Windows.Forms.Button();
            this.btnv = new System.Windows.Forms.Button();
            this.btnl = new System.Windows.Forms.Button();
            this.btndw = new System.Windows.Forms.Button();
            this.btnf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual numero que você quer fazer a tabuada?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sua Tabuada aqui:";
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(369, 6);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(179, 22);
            this.txtx.TabIndex = 2;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(369, 48);
            this.txtr.Multiline = true;
            this.txtr.Name = "txtr";
            this.txtr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtr.Size = new System.Drawing.Size(179, 48);
            this.txtr.TabIndex = 3;
            // 
            // btnw
            // 
            this.btnw.Location = new System.Drawing.Point(387, 155);
            this.btnw.Name = "btnw";
            this.btnw.Size = new System.Drawing.Size(104, 23);
            this.btnw.TabIndex = 4;
            this.btnw.Text = "calcular while";
            this.btnw.UseVisualStyleBackColor = true;
            this.btnw.Click += new System.EventHandler(this.btnw_Click);
            // 
            // btnv
            // 
            this.btnv.Location = new System.Drawing.Point(283, 155);
            this.btnv.Name = "btnv";
            this.btnv.Size = new System.Drawing.Size(75, 23);
            this.btnv.TabIndex = 5;
            this.btnv.Text = "voltar";
            this.btnv.UseVisualStyleBackColor = true;
            this.btnv.Click += new System.EventHandler(this.btnv_Click);
            // 
            // btnl
            // 
            this.btnl.Location = new System.Drawing.Point(161, 155);
            this.btnl.Name = "btnl";
            this.btnl.Size = new System.Drawing.Size(75, 23);
            this.btnl.TabIndex = 6;
            this.btnl.Text = "limpar";
            this.btnl.UseVisualStyleBackColor = true;
            this.btnl.Click += new System.EventHandler(this.btnl_Click);
            // 
            // btndw
            // 
            this.btndw.Location = new System.Drawing.Point(628, 155);
            this.btndw.Name = "btndw";
            this.btndw.Size = new System.Drawing.Size(89, 23);
            this.btndw.TabIndex = 7;
            this.btndw.Text = "calcular do while";
            this.btndw.UseVisualStyleBackColor = true;
            this.btndw.Click += new System.EventHandler(this.btndw_Click);
            // 
            // btnf
            // 
            this.btnf.Location = new System.Drawing.Point(513, 155);
            this.btnf.Name = "btnf";
            this.btnf.Size = new System.Drawing.Size(95, 23);
            this.btnf.TabIndex = 8;
            this.btnf.Text = "calcular for";
            this.btnf.UseVisualStyleBackColor = true;
            this.btnf.Click += new System.EventHandler(this.button5_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnf);
            this.Controls.Add(this.btndw);
            this.Controls.Add(this.btnl);
            this.Controls.Add(this.btnv);
            this.Controls.Add(this.btnw);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm3";
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnw;
        private System.Windows.Forms.Button btnv;
        private System.Windows.Forms.Button btnl;
        private System.Windows.Forms.Button btndw;
        private System.Windows.Forms.Button btnf;
    }
}
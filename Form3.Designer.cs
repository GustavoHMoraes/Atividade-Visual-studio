namespace Gustavo_Rocillo_e_Carlos
{
    partial class frm2
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
            this.txtg = new System.Windows.Forms.TextBox();
            this.txtv = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnvotar = new System.Windows.Forms.Button();
            this.btnacabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votar. 1=José da Silva, 2=Maria Juruma, 3=João da tapioca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ganhador";
            // 
            // txtg
            // 
            this.txtg.Location = new System.Drawing.Point(39, 112);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(749, 22);
            this.txtg.TabIndex = 3;
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(39, 59);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(749, 22);
            this.txtv.TabIndex = 4;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(430, 181);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(349, 181);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnvotar
            // 
            this.btnvotar.Location = new System.Drawing.Point(511, 181);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(75, 23);
            this.btnvotar.TabIndex = 7;
            this.btnvotar.Text = "votar";
            this.btnvotar.UseVisualStyleBackColor = true;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // btnacabar
            // 
            this.btnacabar.Location = new System.Drawing.Point(592, 181);
            this.btnacabar.Name = "btnacabar";
            this.btnacabar.Size = new System.Drawing.Size(131, 23);
            this.btnacabar.TabIndex = 8;
            this.btnacabar.Text = "acabar votacao";
            this.btnacabar.UseVisualStyleBackColor = true;
            this.btnacabar.Click += new System.EventHandler(this.btnacabar_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnacabar);
            this.Controls.Add(this.btnvotar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtv);
            this.Controls.Add(this.txtg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm2";
            this.Text = "Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnvotar;
        private System.Windows.Forms.Button btnacabar;
    }
}
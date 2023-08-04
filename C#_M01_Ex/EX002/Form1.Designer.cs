namespace EX002
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnINICIAR = new System.Windows.Forms.Button();
            this.lblmsg1 = new System.Windows.Forms.Label();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.lblmsg3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnINICIAR
            // 
            this.btnINICIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIAR.Location = new System.Drawing.Point(179, 151);
            this.btnINICIAR.Name = "btnINICIAR";
            this.btnINICIAR.Size = new System.Drawing.Size(123, 35);
            this.btnINICIAR.TabIndex = 0;
            this.btnINICIAR.Text = "INICIAR";
            this.btnINICIAR.UseVisualStyleBackColor = true;
            this.btnINICIAR.Click += new System.EventHandler(this.btnINICIAR_Click);
            // 
            // lblmsg1
            // 
            this.lblmsg1.AutoSize = true;
            this.lblmsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg1.Location = new System.Drawing.Point(28, 50);
            this.lblmsg1.Name = "lblmsg1";
            this.lblmsg1.Size = new System.Drawing.Size(74, 31);
            this.lblmsg1.TabIndex = 1;
            this.lblmsg1.Text = "MEU";
            this.lblmsg1.Visible = false;
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(160, 50);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(111, 31);
            this.lblmsg2.TabIndex = 2;
            this.lblmsg2.Text = "BRASIL";
            this.lblmsg2.Visible = false;
            // 
            // lblmsg3
            // 
            this.lblmsg3.AutoSize = true;
            this.lblmsg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg3.Location = new System.Drawing.Point(321, 50);
            this.lblmsg3.Name = "lblmsg3";
            this.lblmsg3.Size = new System.Drawing.Size(178, 31);
            this.lblmsg3.TabIndex = 3;
            this.lblmsg3.Text = "BRASILEIRO";
            this.lblmsg3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 244);
            this.Controls.Add(this.lblmsg3);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.lblmsg1);
            this.Controls.Add(this.btnINICIAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnINICIAR;
        private System.Windows.Forms.Label lblmsg1;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Label lblmsg3;
    }
}


namespace registradorDePersonajes.PL
{
    partial class frmVerPersonajes
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
            this.pbImagenPersonaje = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblAtaque = new System.Windows.Forms.Label();
            this.lblDefensa = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenPersonaje
            // 
            this.pbImagenPersonaje.Location = new System.Drawing.Point(9, 103);
            this.pbImagenPersonaje.Name = "pbImagenPersonaje";
            this.pbImagenPersonaje.Size = new System.Drawing.Size(300, 300);
            this.pbImagenPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPersonaje.TabIndex = 0;
            this.pbImagenPersonaje.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "VIDA";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.MinimumSize = new System.Drawing.Size(300, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(300, 31);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "label2";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ATAQUE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DEFENSA";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(10, 73);
            this.lblVida.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblVida.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(90, 25);
            this.lblVida.TabIndex = 5;
            this.lblVida.Text = "0";
            this.lblVida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVida.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAtaque
            // 
            this.lblAtaque.AutoSize = true;
            this.lblAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtaque.Location = new System.Drawing.Point(115, 73);
            this.lblAtaque.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblAtaque.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblAtaque.Name = "lblAtaque";
            this.lblAtaque.Size = new System.Drawing.Size(90, 25);
            this.lblAtaque.TabIndex = 6;
            this.lblAtaque.Text = "0";
            this.lblAtaque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefensa
            // 
            this.lblDefensa.AutoSize = true;
            this.lblDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefensa.Location = new System.Drawing.Point(214, 73);
            this.lblDefensa.MaximumSize = new System.Drawing.Size(90, 0);
            this.lblDefensa.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblDefensa.Name = "lblDefensa";
            this.lblDefensa.Size = new System.Drawing.Size(90, 25);
            this.lblDefensa.TabIndex = 7;
            this.lblDefensa.Text = "0";
            this.lblDefensa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(9, 409);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(150, 60);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(163, 409);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(146, 60);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmVerPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 473);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblDefensa);
            this.Controls.Add(this.lblAtaque);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagenPersonaje);
            this.Name = "frmVerPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personajes";
            this.Load += new System.EventHandler(this.frmVerPersonajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPersonaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenPersonaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblAtaque;
        private System.Windows.Forms.Label lblDefensa;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}
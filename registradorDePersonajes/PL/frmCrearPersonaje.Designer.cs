namespace registradorDePersonajes.PL
{
    partial class frmCrearPersonaje
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefensa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAtaque = new System.Windows.Forms.TextBox();
            this.btnCrearPersonaje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenPersonaje
            // 
            this.pbImagenPersonaje.Location = new System.Drawing.Point(11, 25);
            this.pbImagenPersonaje.Name = "pbImagenPersonaje";
            this.pbImagenPersonaje.Size = new System.Drawing.Size(300, 300);
            this.pbImagenPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenPersonaje.TabIndex = 0;
            this.pbImagenPersonaje.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 393);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(298, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa el nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crear tu propio personaje";
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.Location = new System.Drawing.Point(13, 332);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(300, 30);
            this.btnSubirImagen.TabIndex = 4;
            this.btnSubirImagen.Text = "Ingresar imagen";
            this.btnSubirImagen.UseVisualStyleBackColor = true;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresa la cantidad de vida";
            // 
            // txtVida
            // 
            this.txtVida.Location = new System.Drawing.Point(11, 436);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(298, 20);
            this.txtVida.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingresa la cantidad de defensa";
            // 
            // txtDefensa
            // 
            this.txtDefensa.Location = new System.Drawing.Point(11, 522);
            this.txtDefensa.Name = "txtDefensa";
            this.txtDefensa.Size = new System.Drawing.Size(298, 20);
            this.txtDefensa.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingresa la cantidad de ataque";
            // 
            // txtAtaque
            // 
            this.txtAtaque.Location = new System.Drawing.Point(11, 479);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.Size = new System.Drawing.Size(298, 20);
            this.txtAtaque.TabIndex = 7;
            // 
            // btnCrearPersonaje
            // 
            this.btnCrearPersonaje.Location = new System.Drawing.Point(9, 548);
            this.btnCrearPersonaje.Name = "btnCrearPersonaje";
            this.btnCrearPersonaje.Size = new System.Drawing.Size(300, 50);
            this.btnCrearPersonaje.TabIndex = 11;
            this.btnCrearPersonaje.Text = "CREAR";
            this.btnCrearPersonaje.UseVisualStyleBackColor = true;
            this.btnCrearPersonaje.Click += new System.EventHandler(this.btnCrearPersonaje_Click);
            // 
            // frmCrearPersonaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(323, 605);
            this.Controls.Add(this.btnCrearPersonaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDefensa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAtaque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbImagenPersonaje);
            this.Name = "frmCrearPersonaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPersonaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenPersonaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDefensa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAtaque;
        private System.Windows.Forms.Button btnCrearPersonaje;
    }
}
namespace registradorDePersonajes.PL
{
    partial class frmAviso
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
            this.lablMensaje = new System.Windows.Forms.Label();
            this.btnEntendido = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lablMensaje
            // 
            this.lablMensaje.AutoSize = true;
            this.lablMensaje.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.lablMensaje.Location = new System.Drawing.Point(53, 158);
            this.lablMensaje.MinimumSize = new System.Drawing.Size(300, 0);
            this.lablMensaje.Name = "lablMensaje";
            this.lablMensaje.Size = new System.Drawing.Size(300, 36);
            this.lablMensaje.TabIndex = 3;
            this.lablMensaje.Text = "!Personaje creado exitosamente¡";
            this.lablMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntendido
            // 
            this.btnEntendido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnEntendido.FlatAppearance.BorderSize = 0;
            this.btnEntendido.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnEntendido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnEntendido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnEntendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntendido.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.btnEntendido.Location = new System.Drawing.Point(12, 207);
            this.btnEntendido.Name = "btnEntendido";
            this.btnEntendido.Size = new System.Drawing.Size(376, 50);
            this.btnEntendido.TabIndex = 12;
            this.btnEntendido.Text = "ENTENDIDO";
            this.btnEntendido.UseVisualStyleBackColor = true;
            this.btnEntendido.Click += new System.EventHandler(this.btnCrearPersonaje_Click);
            this.btnEntendido.MouseLeave += new System.EventHandler(this.btnCrearPersonaje_MouseLeave);
            this.btnEntendido.MouseHover += new System.EventHandler(this.btnCrearPersonaje_MouseHover);
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::registradorDePersonajes.Properties.Resources.correcto;
            this.pbImagen.Location = new System.Drawing.Point(121, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(147, 143);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // frmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.btnEntendido);
            this.Controls.Add(this.lablMensaje);
            this.Controls.Add(this.pbImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAvisoExitoso";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lablMensaje;
        private System.Windows.Forms.Button btnEntendido;
    }
}
using registradorDePersonajes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ocupo las clases de conexion de datos
using registradorDePersonajes.DAL;

namespace registradorDePersonajes.PL
{

    public partial class frmCrearPersonaje : Form
    {
        public string salir = "SALIR";
        public string crear = "CREAR";

        // aqui se contiene la imagen
        byte[] file = null;

        personajesDAL objPersonajesDAL;

        public frmCrearPersonaje()
        {
            objPersonajesDAL = new personajesDAL();
            InitializeComponent();
        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            // abro una ventana para que busque una imagen
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            // valido si selecciono ok y selecciono la imagen
            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                // selecciono la imagen
                
                pbImagenPersonaje.Image = Image.FromStream(selectorImagen.OpenFile());
                // configuro para que se vea correctamente
                pbImagenPersonaje.SizeMode = PictureBoxSizeMode.StretchImage;
                // abro la imagen

                Stream myStream = selectorImagen.OpenFile();
                using (MemoryStream ms= new MemoryStream())
                {
                    myStream.CopyTo(ms);
                    file=ms.GetBuffer();
                }
                
            }
        }

        private void btnCrearPersonaje_Click(object sender, EventArgs e)
        {
            // validamos las entradas
            if (validarDatos())
            {
                conexionDAL conexion = new conexionDAL();
                bool resultado = objPersonajesDAL.agregarNuevoPersonaje(recolectarDatos());
                if (resultado)
                {
                    //MessageBox.Show("PERSONAJE CREADO EXITOSAMENTE");
                    this.Hide();
                    frmAviso fAviso = new frmAviso(0); // 0=proceso exitoso
                    fAviso.ShowDialog();
                    this.Show();
                    pbImagenPersonaje.SizeMode = PictureBoxSizeMode.CenterImage;
                    pbImagenPersonaje.Image = Properties.Resources.foto;
                    borrarDatosDeLaPantalla();
                }
                else
                {
                    this.Hide();
                    frmAviso fAviso = new frmAviso(1); // 1=proceso fallido
                    fAviso.ShowDialog();
                    this.Show();
                    //MessageBox.Show("ERROR");
                }
            }
            else
            {
                this.Hide();
                frmAviso fAviso = new frmAviso(3); // 3=proceso con falta de datos
                fAviso.ShowDialog();
                this.Show();
            }

        }

        private personajeBLL recolectarDatos()
        {
            // creo un objeto personaje
            personajeBLL objPersonajeBLL = new personajeBLL();
            // obtengo la info de la interfaz
            objPersonajeBLL.nombre = txtNombre.Text;
            objPersonajeBLL.vida = Convert.ToInt32(txtVida.Text);
            objPersonajeBLL.ataque = Convert.ToInt32(txtAtaque.Text);
            objPersonajeBLL.defensa = Convert.ToInt32(txtDefensa.Text);
            // se guarda en una base de datos
            objPersonajeBLL.imagen = file;
            return objPersonajeBLL;
        }

        private bool validarDatos()
        {
            
            if (txtNombre.Text == "" || txtDefensa.Text == "" || txtAtaque.Text == "" || txtVida.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }


        private void borrarDatosDeLaPantalla()
        {
            txtAtaque.Text = "";
            txtDefensa.Text = "";
            txtNombre.Text = "";
            txtVida.Text = "";
            
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearPersonaje_MouseHover(object sender, EventArgs e)
        {
           btnCrearPersonaje.Text = botonSeleccionado(btnCrearPersonaje.Text, "★");
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.Text = botonSeleccionado(btnSalir.Text, "#");
        }

        public string botonSeleccionado(string textoBoton, string icono)
        {

            string seleccionado = icono + " " + textoBoton + " " + icono;
            return seleccionado;
        }

        private void btnCrearPersonaje_MouseLeave(object sender, EventArgs e)
        {
            btnCrearPersonaje.Text = crear;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Text = salir;
        }
    }
}

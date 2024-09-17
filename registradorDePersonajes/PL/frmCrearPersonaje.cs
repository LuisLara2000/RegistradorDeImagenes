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
            conexionDAL conexion = new conexionDAL();

            bool resultado = objPersonajesDAL.agregarNuevoPersonaje(recolectarDatos());
            if (resultado)
            {
                MessageBox.Show("PERSONAJE CREADO EXITOSAMENTE");
                borrarDatosDeLaPantalla();
            }
            else
            {
                MessageBox.Show("ERROR");
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
            // se guarda en una base de dtaos
            objPersonajeBLL.imagen = file;
            return objPersonajeBLL;
        }

        private void borrarDatosDeLaPantalla()
        {
            txtAtaque.Text = "";
            txtDefensa.Text = "";
            txtNombre.Text = "";
            txtVida.Text = "";
            pbImagenPersonaje.Image = null;
    
        }
    }
}

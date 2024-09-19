using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registradorDePersonajes.PL
{
    public partial class frmAviso : Form
    {
        public int e;
        public string entendido = "ENTENDIDO";
        public frmAviso(int estado)
        {
            e = estado;
            InitializeComponent();
            mensajeSegunEstado();
        }

        public void mensajeSegunEstado()
        {
            if(e==0)
            {
                pbImagen.Image = Properties.Resources.correcto;
                lablMensaje.Text = "!Personaje creado exitosamente¡";
            }
            else if (e==1)
            {
                pbImagen.Image = Properties.Resources.error;
                lablMensaje.Text = "No se creo el personaje";
            }
            else
            {
                pbImagen.Image = Properties.Resources.advertencia;
                lablMensaje.Text = "Faltan llenar algunos campos";
            }
        }

        private void btnCrearPersonaje_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string botonSeleccionado(string textoBoton, string icono)
        {

            string seleccionado = icono + " " + textoBoton + " " + icono;
            return seleccionado;
        }

        private void btnCrearPersonaje_MouseHover(object sender, EventArgs e)
        {
            btnEntendido.Text = botonSeleccionado(btnEntendido.Text, "#");
        }

        private void btnCrearPersonaje_MouseLeave(object sender, EventArgs e)
        {
            btnEntendido.Text = entendido;
        }
    }
}

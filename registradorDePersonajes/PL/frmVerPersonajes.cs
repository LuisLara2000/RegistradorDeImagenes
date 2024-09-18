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
using registradorDePersonajes.BLL;
using registradorDePersonajes.DAL;

namespace registradorDePersonajes.PL
{
    public partial class frmVerPersonajes : Form
    {
        public string salir = "SALIR";
        personajesDAL objPersonajesDAL;
        personajeBLL objPersonajeBLLRetornado;
        List<int> idTodosPersonaje;
        int indicePersonajeActual;
        int longitud;

        public frmVerPersonajes()
        {
            objPersonajesDAL = new personajesDAL();
            objPersonajeBLLRetornado = new personajeBLL();
            idTodosPersonaje = new List<int>();
            indicePersonajeActual = 0;   
            InitializeComponent();
        }
        /////////////
        // EVENTOS //
        /////////////
        
        // Ventana
        private void frmVerPersonajes_Load(object sender, EventArgs e)
        {
            idTodosPersonaje = objPersonajesDAL.idTodosLosPersonajes();
            longitud = idTodosPersonaje.Count-1;
            objPersonajeBLLRetornado = objPersonajesDAL.obtenerUnPersonaje(idTodosPersonaje[indicePersonajeActual]);
            cargarInformacionPersonajeActual();

        }
       
        // Botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (indicePersonajeActual++<longitud)
            {
                objPersonajeBLLRetornado = objPersonajesDAL.obtenerUnPersonaje(idTodosPersonaje[indicePersonajeActual]);
                cargarInformacionPersonajeActual();
            }
            else
            {
                indicePersonajeActual = 0;
                objPersonajeBLLRetornado = objPersonajesDAL.obtenerUnPersonaje(idTodosPersonaje[indicePersonajeActual]);
                cargarInformacionPersonajeActual();
            }


        }

        private void btnSiguiente_MouseUp(object sender, MouseEventArgs e)
        {
            btnSiguiente.Image = Properties.Resources.flechaAjustada;
        }

        private void btnSiguiente_MouseDown(object sender, MouseEventArgs e)
        {
            btnSiguiente.Image = Properties.Resources.flechaAjustadaAplastada;
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indicePersonajeActual-- > 0)
            {
                objPersonajeBLLRetornado = objPersonajesDAL.obtenerUnPersonaje(idTodosPersonaje[indicePersonajeActual]);
                cargarInformacionPersonajeActual();
            }
            else
            {
                indicePersonajeActual = longitud;
                objPersonajeBLLRetornado = objPersonajesDAL.obtenerUnPersonaje(idTodosPersonaje[indicePersonajeActual]);
                cargarInformacionPersonajeActual();
            }
        }

        /////////////
        // METODOS //
        /////////////
        
        public void cargarInformacionPersonajeActual()
        {
            lblNombre.Text = objPersonajeBLLRetornado.nombre.ToString();
            lblVida.Text = objPersonajeBLLRetornado.vida.ToString();
            lblAtaque.Text = objPersonajeBLLRetornado.ataque.ToString();
            lblDefensa.Text = objPersonajeBLLRetornado.defensa.ToString();
            MemoryStream ms = new MemoryStream(objPersonajeBLLRetornado.imagen);
            Bitmap bmp = new Bitmap(ms);
            pbImagenPersonaje.Image = bmp;
        }





        // metodos que no sirven
        private void label5_Click(object sender, EventArgs e)
        {

        }

        // no sirve
        private async void btnSiguiente_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void btnAnterior_MouseDown(object sender, MouseEventArgs e)
        {
            btnAnterior.Image = Properties.Resources.flechaAjustadaAplastada2;
        }

        private void btnAnterior_MouseUp(object sender, MouseEventArgs e)
        {
            btnAnterior.Image = Properties.Resources.flechaAjustada2;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
        }
        // BOTON SALIR
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string botonSeleccionado(string textoBoton, string icono)
        {

            string seleccionado = icono + " " + textoBoton + " " + icono;
            return seleccionado;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Text = botonSeleccionado(button2.Text, "#");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = salir;
        }
    }
}

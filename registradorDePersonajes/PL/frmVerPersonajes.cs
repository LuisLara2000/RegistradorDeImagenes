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
            if(indicePersonajeActual++<longitud)
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


    }
}

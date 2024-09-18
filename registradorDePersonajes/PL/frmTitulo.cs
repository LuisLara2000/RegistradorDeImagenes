using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using registradorDePersonajes.BLL;
using registradorDePersonajes.PL;
using registradorDePersonajes.DAL;
using System.Web;

namespace registradorDePersonajes
{
    public partial class frmTitulo : Form
    {
        public string ultimoNombreCrear="CREAR";
        public string ultimoNombreVer="VER";
        public string ultimoNombreSalir = "SALIR";
        public frmTitulo()
        {
            InitializeComponent();
        }

        // EVENTOS //

        // BOTON CREAR //
        private void btn_crear_Click(object sender, EventArgs e)
        {
            //frmCrearPersonaje 
            this.Hide();
            frmCrearPersonaje fCrearPersonaje = new frmCrearPersonaje();
            fCrearPersonaje.ShowDialog();
            this.Show();
        }
        private void btn_crear_MouseHover(object sender, EventArgs e)
        {
            btn_crear.Text = botonSeleccionado(btn_crear.Text, "★");
        }
        private void btn_crear_MouseLeave(object sender, EventArgs e)
        {
            btn_crear.Text = ultimoNombreCrear;
        }

        // BOTON VER //
        private void btn_ver_Click(object sender, EventArgs e)
        {
            // creo un objeto DAL para acceder a la informacion de la base de datos
            personajesDAL objPersonajesDAL = new personajesDAL();
            // reviso si existes personajes creados
            List<int> indicesPersonajes = objPersonajesDAL.idTodosLosPersonajes();
            //MessageBox.Show(indicesPersonajes.Count.ToString());
            if (indicesPersonajes.Count == 0)
            {
                MessageBox.Show("NO EXISTEN PERSONAJES, NECESITAS CREAR UNO PRIMERO");
            }
            else
            {
                this.Hide();
                frmVerPersonajes fVerPersonajes = new frmVerPersonajes();
                fVerPersonajes.ShowDialog();
                this.Show();
                //MessageBox.Show("ya vine");
            }

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Text = botonSeleccionado(button1.Text, "★");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = ultimoNombreVer;
        }
        // BOTON SALIR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btn_salir_MouseHover(object sender, EventArgs e)
        {
            btn_salir.Text = botonSeleccionado(btn_salir.Text, "#");
        }

        private void btn_salir_MouseLeave(object sender, EventArgs e)
        {
            btn_salir.Text = ultimoNombreSalir;
        }
        // SIN USAR

        private void frmTitulo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }






        // METODOS //★
        public string botonSeleccionado(string textoBoton,string icono)
        {
          
            string seleccionado = icono+ " " + textoBoton + " "+icono;
            return seleccionado;
        }


    }
}

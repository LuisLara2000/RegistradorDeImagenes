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

namespace registradorDePersonajes
{
    public partial class frmTitulo : Form
    {
        public frmTitulo()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //frmCrearPersonaje 
            frmCrearPersonaje fCrearPersonaje = new frmCrearPersonaje();
            fCrearPersonaje.ShowDialog();
        }

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
                frmVerPersonajes fVerPersonajes = new frmVerPersonajes();
                fVerPersonajes.ShowDialog();
            }

        }

        private void frmTitulo_Load(object sender, EventArgs e)
        {

        }
    }
}

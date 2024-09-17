using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// para sql
using System.Data;
using System.Data.SqlClient;
// para acceder a las clases
using registradorDePersonajes.BLL;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace registradorDePersonajes.DAL
{
    internal class personajesDAL
    {
        // declaro un objeto conexion de manera global
        conexionDAL conexionDAL;
        // constructor
        public personajesDAL()
        {
            // inicializo el objeto conexion 
            conexionDAL = new conexionDAL();
        }

        // ejecutar el procedimiento almacena para insertar un personaje
        // no retorna datos
        public bool agregarNuevoPersonaje(personajeBLL objPeronsajeBLL)
        {
            var conexion = conexionDAL.establecerConexion();
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_crearPersonaje", conexion);
                cmd.Parameters.AddWithValue("@nombre", objPeronsajeBLL.nombre);
                cmd.Parameters.AddWithValue("@vida ", objPeronsajeBLL.vida);
                cmd.Parameters.AddWithValue("@ataque ", objPeronsajeBLL.ataque);
                cmd.Parameters.AddWithValue("@defensa", objPeronsajeBLL.defensa);
                cmd.Parameters.AddWithValue("@imagen", objPeronsajeBLL.imagen);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return false;
            }


        }

        // retorna datos
        public personajeBLL obtenerUnPersonaje(int idPersonaje)
        {
            personajeBLL objPersonajeBLL = new personajeBLL();

            // establesco conexion 
            var conexion = conexionDAL.establecerConexion();
            try
            {
                // abro la conexion
                conexion.Open();
                // defino cual sp voy a usar
                SqlCommand cmd = new SqlCommand("sp_verPersonaje", conexion);
                // paso los parametros necesarios para el sp
                cmd.Parameters.AddWithValue("@personajeId", idPersonaje);
                // indico el tipo de comando
                cmd.CommandType = CommandType.StoredProcedure;
                //
                
                //
                // ejecuto el comando              
                using (var dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        objPersonajeBLL.nombre = dr["nombre"].ToString();
                        objPersonajeBLL.vida = Convert.ToInt32(dr["vida"]);
                        objPersonajeBLL.ataque = Convert.ToInt32(dr["ataque"]);
                        objPersonajeBLL.defensa = Convert.ToInt32(dr["defensa"]);
                        // aqui estaba el error de ayer (16/09/24)
                        objPersonajeBLL.imagen = (byte[])dr["imagen"];
                    }
                }
                return objPersonajeBLL;
            }
            catch (Exception ex) 
            {
                string msg = ex.Message;
                return objPersonajeBLL;
            }
           
        }
        public List<int> idTodosLosPersonajes()
        {
            List<int> idTodos= new List<int>();
            // establesco conexion 
            var conexion = conexionDAL.establecerConexion();
            try
            {
                // abro la conexion
                conexion.Open();
                // defino cual sp voy a usar
                SqlCommand cmd = new SqlCommand("sp_listaIdPersonajes", conexion);
                // indico el tipo de comando
                cmd.CommandType = CommandType.StoredProcedure;
                // ejecuto el comando              
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        idTodos.Add(Convert.ToInt32(dr["personajeId"]));
                    }
                }
                return idTodos;
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return idTodos;
            }
           
        }
    }
}

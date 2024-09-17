using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// para adiministrar la base de datos
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;



namespace registradorDePersonajes.DAL
{
    internal class conexionDAL
    {
        // cadena de conexion 
        private string cadenaConexion = "Data Source=DESKTOP-RFH04FU;Initial Catalog=dbPersonajes;Integrated Security=True;Encrypt=False";
        //
        SqlConnection conexion;

        public SqlConnection establecerConexion()
        {
            this.conexion = new SqlConnection(this.cadenaConexion);
            return this.conexion;
        }

        /*
        // insert,update,delete
        public bool cmdSinRetornoDatos(SqlCommand SqlComando)
        {
            try
            {
                SqlCommand comando = SqlComando;
                comando.Connection = this.establecerConexion();

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return false;
            }
        }

        // select 
        public DataSet cmdConRetornoDatos(SqlCommand SqlComando)
        {
            // como es retorno de datos,ocupo algo para contener los datos
            DataSet Ds = new DataSet();
            // ocupo un adaptador
            SqlDataAdapter Adaptador = new SqlDataAdapter();
            try
            {
                // creo un objeto de tipo sqlcomand
                SqlCommand cmd = new SqlCommand();
                // recibo el comando a ejecutar
                cmd = SqlComando;
                // me conecto a la base de datos
                cmd.Connection = this.establecerConexion();
                // ejecuto el comando (creo)
                Adaptador.SelectCommand = cmd;
                // abro la conexion 
                conexion.Open();
                // ingreso la informacion obtenida en el data set
                Adaptador.Fill(Ds);
                // cierro la conexion
                conexion.Close();
                // retorno los datos obtenidos
                return Ds;
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;
                return Ds;
            }
        }*/
    }
}

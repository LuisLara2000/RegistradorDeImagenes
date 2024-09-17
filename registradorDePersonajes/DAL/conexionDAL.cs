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
    }
}

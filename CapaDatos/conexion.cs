using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string conexionString;

        public Conexion()
        {
            //  conexionString = "Server=(Local); DataBase=EXAMEN_FINAL_SEMINARIO; integrated security=true";

            conexionString = "Server=GABY_LAPTOP\\SQLEXPRESS; Integrated Security=true; Database=EXAMEN_FINAL_SEMINARIO ";
            //conexionString = "Server=DESKTOP-3GC35CO\\EFI_SERVER; DataBase=EXF_SeminarioI; integrated security=true; User ID=sa; Password=sa";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }
    }
}
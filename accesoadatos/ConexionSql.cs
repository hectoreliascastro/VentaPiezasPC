using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Importamos la libreria SQL

namespace accesoadatos
{
    public abstract class ConexionSql //Clase Asbtracta
    {
        protected SqlConnection getConnection()
        {
            return new SqlConnection("Server=(local); DataBase=ventasdb; integrated security=true");
        }
    }
}

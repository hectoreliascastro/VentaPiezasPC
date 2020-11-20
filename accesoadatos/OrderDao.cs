using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace accesoadatos
{
    public class OrderDao:ConexionSql //Heredamos de la clase
    {
        public DataTable getSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select v.idCliente as ID, v.FechaVenta as Fecha, c.Nombres + ' ' + c.Apellidos as cliente, p.Nombre as products, v.Total as total_amount
                                            from Venta v
                                            inner join Cliente c on v.IdCliente = c.IdCliente
                                            inner join DetalleVenta dv on dv.IdVenta = v.IdVenta
                                            inner join Producto p on  p.IdProducto = dv.IdProducto
                                            where v.FechaVenta between @fromDate and @toDate
                                            order by v.IdCliente asc";

                    command.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate; //tipo de datos del parametro
                    command.CommandType = CommandType.Text; //Comando de tipo texto

                    var reader = command.ExecuteReader(); //Lector SQL ejecutmos metodo lector del comando
                    var table = new DataTable(); //Creamos instancia de tipo tabla de datos
                    table.Load(reader); //Cargamos la tabla con los datos de la tabla del lector
                    reader.Dispose(); //Desechamos el lector

                    return table; //Finalmente retornamos la tabla
                }
            }
        }
    }
}

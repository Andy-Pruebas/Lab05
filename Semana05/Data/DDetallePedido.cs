using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DDetallePedido
    {
        public List<DetallePedido> GetDetallePedidos(DetallePedido detallePedido)
        {

            SqlParameter[] parameters = null;
            string commandText = string.Empty;
            List<DetallePedido> detalles = null;

            try
            {
                commandText = "USP_DETALLE";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@IDPEDIDO", System.Data.SqlDbType.Int);
                parameters[0].Value = detallePedido.IdPedido;
                detalles = new List<DetallePedido>();

                using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.Connection, "USP_DETALLE",
                    System.Data.CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        detalles.Add(new DetallePedido
                        {
                            IdPedido = reader["idpedido"] != null ? Convert.ToInt32(reader["idpedido"]) : 0,
                            IdProducto = reader["idproducto"] != null ? Convert.ToInt32(reader["idproducto"]) : 0,
                            PrecioUnidad = reader["preciounidad"] != null ? Convert.ToInt32(reader["preciounidad"]) : 0,
                            Cantidad = reader["cantidad"] != null ? Convert.ToInt32(reader["cantidad"]) : 0,
                            Descuento = reader["descuento"] != null ? Convert.ToInt32(reader["descuento"]) : 0
                        });
                    }
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            return detalles;
        }    
    }
}

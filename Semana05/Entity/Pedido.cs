using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEnvio { get; set; }
        public int FormaEnvio { get; set; }
        public decimal Cargo { get; set; }
        public string Destinatario { get; set; }
        public String DireccionDestinatario { get; set; }
        public String CiudadDestinatario { get; set; }
        public String RegionDestinatario { get; set; }
        public String CodPostalDestinatario { get; set; }
        public String PaisDestinatario { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}

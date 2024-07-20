using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.Entidades
{
    public class DetallePedido
    {
        public string DetalleId { get; set; }
        public int PedidoId { get; set; }
        public int FacturaId { get; set; }
        public string ProductoId { get; set; }
        public string CantidadPedido { get; set; }

    }
}

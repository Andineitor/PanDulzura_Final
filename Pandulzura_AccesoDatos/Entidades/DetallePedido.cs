using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.Entidades
{
    public class DetallePedido
    {
        public string IdDetalle { get; set; }
        public int? IdPedido { get; set; }
        public int? IdFactura { get; set; }
        public int? IdProducto { get; set; }
        public int CantidadPedido { get; set; }
    }
}

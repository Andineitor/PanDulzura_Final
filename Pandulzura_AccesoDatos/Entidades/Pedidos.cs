using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.Entidades
{
    public class Pedidos
    {
        public int PedidoId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaPedido { get; set; }
        public Estado EstadoPedido { get; set; }

        public enum Estado
        {
            Enviado = 1,
            Entregado = 2,
            Pendiente = 3,
            Cancelado = 4
        }
    }
}
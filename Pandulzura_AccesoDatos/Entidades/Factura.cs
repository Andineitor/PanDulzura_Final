using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.Entidades
{
    public class Factura
    {
        public string FACTURAID { get; set; }
        public string TOTAL_FINAL { get; set; }
        public DateTime FECHA_FACT { get; set; }
    }
}

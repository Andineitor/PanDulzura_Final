using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.Entidades
{
    public class Producto
    {
        public string IdProd { get; set; }
        //public int? IdCategoria { get; set; }
        public string NombreProd { get; set;}
        public string DescripcionProd { get;set;}
        public double PrecioProd { get; set;}
        public int DisponibilidadProd { get; set; }

    }
}

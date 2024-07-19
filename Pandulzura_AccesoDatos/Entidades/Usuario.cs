using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandulzura_AccesoDatos.Entidades
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public int? RolesId { get; set; }
        public string NombreUser { get; set; }
        public long? CedulaUser { get; set; }
        public string MailUser { get; set; }
        public long? TelefonoUser { get; set; }
        public string DireccionUser { get; set; }
        public string ContrasenaUser { get; set; }

    }
}

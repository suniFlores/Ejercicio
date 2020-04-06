using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ContactosEntity
    {

        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Puesto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdCliente { get; set; }

    }
}

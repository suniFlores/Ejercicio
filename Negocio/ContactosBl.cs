using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Entidad;
using System.Data;

namespace BL
{
    public class ContactosBl
    {
        ContactoRepository ContactoRepository = new ContactoRepository();

        // Método que retorna un listado de Contactos.
        public DataTable ListadoContactoPorID(int nCliente)
        {
            return ContactoRepository.ListadoContactoPorID(nCliente);
        }

        // Método que Inserta un Contacto.
        public string InsertarContacto(ContactosEntity oContactos)
        {
            return ContactoRepository.InsertarContacto(oContactos);
        }

        // Método que Elimina un Contacto.
        public string EliminarContacto(string sIdContacto)
        {
            return ContactoRepository.EliminarContacto(Convert.ToInt32(sIdContacto));
        }

        // Método que Actualiza un Contacto.
        public string ActualizarContactos(ContactosEntity oContactos)
        {
            return ContactoRepository.ActualizarContacto(oContactos);
        }
    }
}

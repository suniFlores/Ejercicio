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
    public class ClientesBl
    {
        ClientesRepository ClientesRepository = new ClientesRepository();

        // Método que retorna un listado de Clientes.
        public DataTable ListadoClientes()
        {
            return ClientesRepository.ListadoClientes();
        }

        // Método que Inserta un Clientes.
        public string InsertarCliente(ClientesEntity oClientes)
        {
            return ClientesRepository.InsertarCliente(oClientes);
        }

        // Método que Elimina un Cliente.
        public string EliminarCliente(string sIdCliente)
        {
            return ClientesRepository.EliminarCliente(Convert.ToInt32(sIdCliente));
        }

        // Método que Actualiza un Cliente.
        public string ActualizarCliente(ClientesEntity oClientes)
        {
            return ClientesRepository.ActualizarCliente(oClientes);
        }
    }
}

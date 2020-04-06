using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repositorio
{
    // Método que consume el SP: sp_RClientes, que obtiene un listado de Clientes.
    public class ClientesRepository
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BD1G"].ConnectionString);

        // Obtiene un listado de Clientes
        public DataTable ListadoClientes()
        {
            SqlCommand cmd = new SqlCommand("sp_RClientes", conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            

            da.Fill(dataTable);

            return dataTable;
        }

        // Método que consume el SP: sp_CClientes, que registra un nuevo Cliente.
        public string InsertarCliente(ClientesEntity clientes)
        {
            string Respuesta = string.Empty;
            SqlCommand cmd = new SqlCommand("sp_CClientes", conexion);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sRazonSocial", clientes.RazonSocial);
                cmd.Parameters.AddWithValue("@sNombreComercial", clientes.NombreComercial);
                cmd.Parameters.AddWithValue("@sRFC", clientes.RFC);
                cmd.Parameters.AddWithValue("@sCURP", clientes.CURP);
                cmd.Parameters.AddWithValue("@sDireccion", clientes.Direccion);

                conexion.Open();

                cmd.ExecuteNonQuery();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }

          

            return Respuesta;
        }

        // Método que consume el SP: sp_DClientes, que elimina un Cliente de acuerdo al id recibido.
        public string EliminarCliente(int nIdCliente)
        {
            string Respuesta = string.Empty;

            SqlCommand cmd = new SqlCommand("sp_DClientes", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nIdClientes", nIdCliente);

                cmd.Parameters.Add("@sMensajeRespuesta", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                conexion.Open();

                cmd.ExecuteNonQuery();

                Respuesta = cmd.Parameters["@sMensajeRespuesta"].Value.ToString();

                conexion.Close();

            }
            catch (Exception ex)
            {

                Respuesta = ex.Message;
            }
            return Respuesta;
        }

        // Método que consume el SP: sp_UClientes, que actualiza la información del Cliente.
        public string ActualizarCliente(ClientesEntity oClientes)
        {
            string Respuesta = string.Empty;

            SqlCommand cmd = new SqlCommand("sp_UClientes", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nIdClientes", oClientes.Id);
                cmd.Parameters.AddWithValue("@sRazonSocial", oClientes.RazonSocial);
                cmd.Parameters.AddWithValue("@sNombreComercial", oClientes.NombreComercial);
                cmd.Parameters.AddWithValue("@sRFC", oClientes.RFC);
                cmd.Parameters.AddWithValue("@sCURP", oClientes.CURP);
                cmd.Parameters.AddWithValue("@sDireccion", oClientes.Direccion);
                cmd.Parameters.Add("@sMensajeRespuesta", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                conexion.Open();

                cmd.ExecuteNonQuery();

                Respuesta = cmd.Parameters["@sMensajeRespuesta"].Value.ToString();

                conexion.Close();

            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }

            return Respuesta;
        }
    }
}

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
    public class ContactoRepository
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["BD1G"].ConnectionString);

        // Método que consume el SP: sp_RContactosPorIdCliente, que obtiene un listado de Contactos por ID.
        public DataTable ListadoContactoPorID(int nContacto)
        {

            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_RContactosPorIdCliente", conexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nIdCliente", nContacto);

                cmd.Parameters.Add("@sMensajeRespuesta", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dataTable);

            }
            catch (Exception ex)
            {
                throw;
            }

            return dataTable;
        }

        // Método que consume el SP: sp_RContactosPorIdContacto, que valida si existe un contacto.
        public bool ExisteContacto(int nIdContacto)
        {
            SqlCommand cmd = new SqlCommand("sp_RContactosPorIdContacto", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nIdContacto", nIdContacto);

                cmd.Parameters.Add("@nIdContacto", SqlDbType.Int).Direction = ParameterDirection.Output;

                conexion.Open();

                cmd.ExecuteNonQuery();

                var Respuesta = cmd.Parameters["@nIdContacto"].Value.ToString();

            }
            catch (Exception ex)
            {

                throw;
            }

            return true;
        }

        // Método que consume el SP: sp_CContactos, que registra un nuevo Contacto.
        public string InsertarContacto(ContactosEntity contacto)
        {
            string Respuesta = string.Empty;

            SqlCommand cmd = new SqlCommand("sp_CContactos", conexion);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sNombre", contacto.Nombre);
                cmd.Parameters.AddWithValue("@sApellidoPaterno", contacto.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@sApellidoMaterno", contacto.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@sPuesto", contacto.Puesto);
                cmd.Parameters.AddWithValue("@sDireccion", contacto.Direccion);
                cmd.Parameters.AddWithValue("@sTelefono", contacto.Telefono);
                cmd.Parameters.AddWithValue("@nIdCliente", contacto.IdCliente);

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

        // Método que consume el SP: sp_DContactos, que elimina un Contacto de acuerdo al id recibido.
        public string EliminarContacto(int nIdContacto)
        {
            string Respuesta = string.Empty;

            SqlCommand cmd = new SqlCommand("sp_DContactos", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nIdContacto", nIdContacto);

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

        // Método que consume el SP: sp_UContactos, que actualiza la información del Contacto.
        public string ActualizarContacto(ContactosEntity oContacto)
        {
            string Respuesta = string.Empty;

            //var result = ExisteContacto(contacto.nIdContacto);

            SqlCommand cmd = new SqlCommand("sp_UContactos", conexion);

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nIdContacto", oContacto.IdContacto);
                cmd.Parameters.AddWithValue("@sNombre", oContacto.Nombre);
                cmd.Parameters.AddWithValue("@sApellidoPaterno", oContacto.ApellidoPaterno);
                cmd.Parameters.AddWithValue("@sApellidoMaterno", oContacto.ApellidoMaterno);
                cmd.Parameters.AddWithValue("@sPuesto", oContacto.Puesto);
                cmd.Parameters.AddWithValue("@sDireccion", oContacto.Direccion);
                cmd.Parameters.AddWithValue("@sTelefono", oContacto.Telefono);
                cmd.Parameters.AddWithValue("@nIdCliente", oContacto.IdCliente);

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entidad;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        ClientesBl ClientesBl = new ClientesBl();
        ClientesEntity ClientesEntity = new ClientesEntity();

        ContactosBl ContactosBl = new ContactosBl();
        ContactosEntity ContactosEntity = new ContactosEntity();

        public int bEdicion = 0;    // Esta variable se utiliza para indicar cuando esta en modo edición

        #region Métodos: Clientes
        public FrmClientes()
        {
            InitializeComponent();
        }

        // Método de Inicio
        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            ListarClientes();

            
        }

        // Método que llena el Grid de CLIENTES
        void ListarClientes()
        {
            DataTable datatable = ClientesBl.ListadoClientes();

            dataGridView1.DataSource = datatable;
        }

        // Botón: Nuevo Cliente, consume el método NuevoCliente
        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente();
        }

        // Método que alimenta la clase: Cliente y la envia al BL
        void NuevoCliente()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                {
                    MessageBox.Show("Capture la razon social y vuelva a intentarlo...");
                    return;
                }
                ClientesEntity clientes = new ClientesEntity()
                {
                    RazonSocial = txtRazonSocial.Text,

                    NombreComercial = txtNombreComercial.Text,

                    RFC = txtRFC.Text,

                    CURP = txtCURP.Text,

                    Direccion = txtDireccion.Text

                };

                ClientesBl.InsertarCliente(clientes);

                ListarClientes();

                BlanquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

          // Botón: Realiza la acción de eliminar a un Cliente. Consume el método: EliminarCliente()
          private void btnBorrar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }

        // Méotodo que consume: EliminarCliente de la BL
        void EliminarCliente()
        {
            var sIdCliente = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (string.IsNullOrWhiteSpace(sIdCliente))
            {
                MessageBox.Show("Para continuar seleccione un Cliente...");
            }
            else
            {
                ClientesBl.EliminarCliente(sIdCliente);

                ListarClientes();
            }
        }

        // Método que limpia los controles.
        void BlanquearCampos()
        {
            txtRazonSocial.Text = "";

            txtNombreComercial.Text = "";

            txtRFC.Text = "";

            txtCURP.Text = "";

            txtDireccion.Text = "";
        }

        // Botón: Actualizar. Consume ActualizarCliente().
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarCliente();
        }

        // Método que alimenta la clase: Clientes y realiza el envío a ActualizarCliente() de la BL.
        // Una vez actualiza el contacto, actualiza el grid de Contactos.
        void ActualizarCliente()
        {
            ClientesEntity clientes = new ClientesEntity()
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),

                RazonSocial = dataGridView1.CurrentRow.Cells[1].Value.ToString(),

                NombreComercial = dataGridView1.CurrentRow.Cells[2].Value.ToString(),

                RFC = dataGridView1.CurrentRow.Cells[3].Value.ToString(),

                CURP = dataGridView1.CurrentRow.Cells[4].Value.ToString(),

                Direccion = dataGridView1.CurrentRow.Cells[5].Value.ToString(),

            };

            ClientesBl.ActualizarCliente(clientes);

            ListarClientes();
        }

        // Método que refresca el Grid de Contactos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarContactosPorID();
        }

        #endregion Métodos: Clientes

        #region Métodos Contactos

        // Botón: que realiza la acción de Guardar. Verifica si es una edción o un nuevo Contacto.
        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            if (bEdicion == 0)
            {
                NuevoContacto();
            }
            else
            {
                ActualizarContacto();

                BlanquearCamposContactos();

                bEdicion = 0;
            }
        }

        // Método que alimenta la clase: Contacto y consume el método: InsertarContacto() de la BL.
        // Una vez agregado el contacto, actualiza el grid de Contactos.
        void NuevoContacto()
        {

            try
            {
               
                {
                    // Si no existe id entonces es nuevo Registro

                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    {
                        MessageBox.Show("Capture el nombre del contacto y vuelva a intentarlo...");
                        return;
                    }
                    ContactosEntity contactos = new ContactosEntity()
                    {
                        Nombre = txtNombre.Text,

                        ApellidoPaterno = txtApPaterno.Text,

                        ApellidoMaterno = txtApMaterno.Text,

                        Puesto = txtPuesto.Text,

                        Telefono = txtTelefono.Text,

                        Direccion = txtDireccionContacto.Text,

                        IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)

                    };

                    ContactosBl.InsertarContacto(contactos);

                    BlanquearCamposContactos();

                    ListarContactosPorID();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        
        // Método que limpia los controles de Contactos.
        void BlanquearCamposContactos()
        {
            txtNombre.Text = "";

            txtApPaterno.Text = "";

            txtApMaterno.Text = "";

            txtPuesto.Text = "";

            txtTelefono.Text = "";

            txtDireccionContacto.Text = "";
        }

        // Método que asigna a los controles de contactos los valores cuando esta en modo Edición
        void EditarContacto()
        {
            txtNombre.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

            txtApPaterno.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

            txtApMaterno.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

            txtPuesto.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

            txtDireccionContacto.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();

            txtTelefono.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        // Método que obtiene los Contactos por Id de Cliente y los refleja en el Grid de Contactos.
        void ListarContactosPorID()
        {
            DataTable datatable = ContactosBl.ListadoContactoPorID(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            dataGridView2.DataSource = datatable;
        }

        // Botón: Realiza la acción de guardar, indicando que es una edición.
        private void btnActualizarContacto_Click(object sender, EventArgs e)
        {
            bEdicion = 1;

            EditarContacto();
            //ActualizarContacto();
        }

        // Método que alimenta la clase: Contactos y la envia al método: ActualizarContactos() de la BL.
        // Una vez actualizado, actualiza el grid de Contactos.
        void ActualizarContacto()
        {
            ContactosEntity contactos = new ContactosEntity()
            {
                IdContacto = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value),

                Nombre = txtNombre.Text,

                ApellidoPaterno = txtApPaterno.Text,

                ApellidoMaterno = txtApMaterno.Text,

                Puesto = txtPuesto.Text,

                Telefono = txtTelefono.Text,

                Direccion = txtDireccionContacto.Text,

                IdCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            };

            ContactosBl.ActualizarContactos(contactos);

            ListarContactosPorID();
        }

        // Botón: Realiza la acción de eliminar a un Contacto. Consume el método: EliminarContacto()
        private void btnBorrarContacto_Click(object sender, EventArgs e)
        {
            EliminarContacto();
        }

        // Méotodo que consume: EliminarContacto() de la BL
        // Una vez borrado, actualiza el grid de Contactos.
        void EliminarContacto()
        {
            var sIdContacto = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            if (string.IsNullOrWhiteSpace(sIdContacto))
            {
                MessageBox.Show("Para continuar seleccione un Contacto...");
            }
            else
            {
                ContactosBl.EliminarContacto(sIdContacto);

                ListarContactosPorID();
            }
        }

        // Botón: Realiza la acción de cancelar una edición. 
        private void button2_Click(object sender, EventArgs e)
        {
            // Boton que Cancela la Edición
            BlanquearCamposContactos();

            bEdicion = 0;
        }
        #endregion Métodos Contactos

    }
}

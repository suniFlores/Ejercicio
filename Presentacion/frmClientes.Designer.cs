namespace Presentacion
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtCURP = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnActualizarContacto = new System.Windows.Forms.Button();
            this.btnBorrarContacto = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnNuevoContacto = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccionContacto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 139);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(814, 68);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(178, 22);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(822, 99);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(170, 22);
            this.txtNombreComercial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Comercial";
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(757, 130);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(79, 22);
            this.txtRFC.TabIndex = 5;
            // 
            // txtCURP
            // 
            this.txtCURP.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCURP.Location = new System.Drawing.Point(883, 130);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(110, 22);
            this.txtCURP.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(778, 164);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(215, 22);
            this.txtDireccion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(720, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(843, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "CURP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dirección";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(120, 205);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(35, 205);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Clientes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Contactos";
            // 
            // btnActualizarContacto
            // 
            this.btnActualizarContacto.Location = new System.Drawing.Point(40, 430);
            this.btnActualizarContacto.Name = "btnActualizarContacto";
            this.btnActualizarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarContacto.TabIndex = 20;
            this.btnActualizarContacto.Text = "Editar";
            this.btnActualizarContacto.UseVisualStyleBackColor = true;
            this.btnActualizarContacto.Click += new System.EventHandler(this.btnActualizarContacto_Click);
            // 
            // btnBorrarContacto
            // 
            this.btnBorrarContacto.Location = new System.Drawing.Point(163, 430);
            this.btnBorrarContacto.Name = "btnBorrarContacto";
            this.btnBorrarContacto.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarContacto.TabIndex = 19;
            this.btnBorrarContacto.Text = "Borrar";
            this.btnBorrarContacto.UseVisualStyleBackColor = true;
            this.btnBorrarContacto.Click += new System.EventHandler(this.btnBorrarContacto_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(864, 362);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(26, 16);
            this.lblTelefono.TabIndex = 27;
            this.lblTelefono.Text = "Tel.";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(720, 362);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 16);
            this.lblPuesto.TabIndex = 26;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApMaterno.Location = new System.Drawing.Point(720, 334);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(87, 16);
            this.lblApMaterno.TabIndex = 25;
            this.lblApMaterno.Text = "Apellido Materno";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(894, 362);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(88, 22);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(768, 362);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(90, 22);
            this.txtPuesto.TabIndex = 13;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApMaterno.Location = new System.Drawing.Point(807, 334);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(175, 22);
            this.txtApMaterno.TabIndex = 12;
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApPaterno.Location = new System.Drawing.Point(720, 305);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(85, 16);
            this.lblApPaterno.TabIndex = 21;
            this.lblApPaterno.Text = "Apellido Paterno";
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApPaterno.Location = new System.Drawing.Point(808, 305);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(174, 22);
            this.txtApPaterno.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(768, 275);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.Location = new System.Drawing.Point(768, 453);
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoContacto.TabIndex = 18;
            this.btnNuevoContacto.Text = "Guardar";
            this.btnNuevoContacto.UseVisualStyleBackColor = true;
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(35, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(663, 128);
            this.dataGridView2.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(720, 278);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 16);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(720, 395);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 16);
            this.lblDireccion.TabIndex = 31;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccionContacto
            // 
            this.txtDireccionContacto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionContacto.Location = new System.Drawing.Point(774, 394);
            this.txtDireccionContacto.Name = "txtDireccionContacto";
            this.txtDireccionContacto.Size = new System.Drawing.Size(208, 22);
            this.txtDireccionContacto.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(883, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccionContacto);
            this.Controls.Add(this.btnActualizarContacto);
            this.Controls.Add(this.btnBorrarContacto);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblApMaterno);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtApMaterno);
            this.Controls.Add(this.lblApPaterno);
            this.Controls.Add(this.txtApPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnNuevoContacto);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Catálogo";
            this.Load += new System.EventHandler(this.frmClientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtCURP;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnActualizarContacto;
        private System.Windows.Forms.Button btnBorrarContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnNuevoContacto;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccionContacto;
        private System.Windows.Forms.Button button2;
    }
}


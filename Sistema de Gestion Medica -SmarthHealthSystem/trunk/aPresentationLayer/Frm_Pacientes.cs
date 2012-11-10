using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using System.Xml;
using BussinesLogicLayer;
using DevExpress.XtraEditors;
using EntidadesLayer;



namespace aPresentationLayer
{
    public partial class Frm_Pacientes : DevExpress.XtraEditors.XtraForm
    {
        //Entidades
        readonly Ent_Paciente paciente = new Ent_Paciente();
        readonly Ent_Direcciones direcciones = new Ent_Direcciones();
        readonly Ent_Telefono telefonos = new Ent_Telefono();
        readonly Ent_Contacto contacto = new Ent_Contacto();

        //variables del Frm_Paciente
        private static bool NUEVO;
        private static bool EDITANDO;
        private static bool CONSULTANDO;

                  //para saber si ocurrio un error en las tablas
                                            bool seGuardoDirecciones = true;
                                            bool seGuardoTelefonos = true;
                                            bool seGuardoContactos = true;

        private static Frm_Pacientes frm_pacientes; // Referencia estática al mismo formulario

        public static Frm_Pacientes frm_Pacientes() // Método estatico que hace referencia a el mismo
        {
            if (frm_pacientes == null || frm_pacientes.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_pacientes = new Frm_Pacientes(); // Se crea instancia
            }
            else
            {
                frm_pacientes.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_pacientes; // Retornamos el valor
        }//fin del metodo

        public Frm_Pacientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Si tengo seleccionado el tabPacientes entonces que se realice 
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes && !NUEVO == true)
            {
                /*Cambio las variable del sistema a Nuevo = True (indicando que es un nuevo registro) y 
                Editando = False (me aseguro que este en false)*/

                NUEVO = true;
                EDITANDO = false;

                //Limpio los Txt
                Bl_AdministrarControles.VaciarText(frm_pacientes);

                //Limpio los DatagriedView
                Bl_AdministrarControles.VaciarDGV(frm_pacientes);

                //Habilitos los Txt
                Bl_AdministrarControles.HabilitarText(frm_pacientes);


                //Desabilito el txtIDPaciente
                txtIDPaciente.Enabled = false;
                //Paso el Foco Al Nombre
                txtNombres.Focus();

                //Hago las columnas de los datagrid visibles

                Direccion.Visible = true;
                Telefono.Visible = true;
                NombreContacto.Visible = true;
                TelefonoContacto.Visible = true;

                //Agrego una descripcion para el control

                txtDireccion.Text = "Agregar una direccion para el paciente";
                txtDireccion.ForeColor = Color.DarkGray;
                txtNombreContacto.Text = "Agregar nombre de contacto";
                txtNombreContacto.ForeColor = Color.DarkGray;

            }//fin del If 
        }//fin del Boton Nuevo

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Si tengo seleccionado el tabPacientes y mi capo IDPaciente esta lleno entonces que se realice 
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes &&  !string.IsNullOrEmpty(txtIDPaciente.Text))
            {
                /*Cambio las variable del sistema a Nuevo = false (me aseguro que este en false) y 
                  Editando = False (indicando que el registro existe) */

                EDITANDO = true;
                NUEVO = false;


                //Habilitos los Txt
                Bl_AdministrarControles.HabilitarText(frm_pacientes);

                //Habilitos los Txt
                Bl_AdministrarControles.HabilitarDGV(frm_pacientes);

                //Deshabilito el CampoIDPaciente
                txtIDPaciente.Enabled = false;

                //Paso el Foco Al Nombre
                txtNombres.Focus();
            }//fin del if

        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes && txtNombres.Enabled == true)
            {
                DialogResult Respuesta = MessageBox.Show("Desea realmente cancelar los cambios?", "Smarth Health Care", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes) 
                {
                    NUEVO = false;
                    EDITANDO = false;
                    CONSULTANDO = false;

                    //Deshabilito los Txt
                    Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                    //Deshabilito los Datagried
                    Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);

                    //Limpio los Txt
                    Bl_AdministrarControles.VaciarText(frm_pacientes);

                    //Limpio los DatagriedView
                    Bl_AdministrarControles.VaciarDGV(frm_pacientes);



                }
             
            }// fin del if


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Hago que mi datagrid sea enable true
            dtgListaPacientes.Enabled = true;
            try
            {
            //Busco todos los pacientes
                dtgListaPacientes.DataSource = Bl_Paciente.SearchAll();
            
            for (int i = 8; i <dtgListaPacientes.Columns.Count; i++)
            {
                dtgListaPacientes.Columns[i].Visible = false;    
            }
            btnCargar.Text = "Filtrar";
            txtFiltro.Enabled = true;
            txtFiltro.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo problemas para devolver los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (dtgListaPacientes.Rows.Count != 0) 
                {
                    string filtro = Convert.ToString(txtFiltro.Text.Trim());

                    ((DataTable)this.dtgListaPacientes.DataSource).DefaultView.RowFilter = @"Paciente Like '%" + filtro + "%'" + "OR Nombres Like '%" + filtro + "%'" + "OR Nombres Like '%" + filtro + "%'"
                        + "OR Identificacion Like '%" + filtro + "%'" + "OR Genero Like '%" + filtro + "%'" + "OR Email Like '%" + filtro + "%'"
                        + "OR NSS Like '%" + filtro + "%'";
                    dtgListaPacientes.Refresh();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(" Hubo problemas para filtrar la data, comuniquese con el administrador del sistema, disculpe los inconvenientes" + error.Message);
            }


        }


        private void dtgListaPacientes_Click(object sender, EventArgs e)
        {
            if (dtgListaPacientes.Rows.Count != 0) 
           {
               try
               {

             
               //Obtengo el indice de la fila seleccionada
                   int fila = dtgListaPacientes.CurrentRow.Index;

               txtIDPaciente.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[0].Value);
               txtNombres.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[1].Value);
               txtApellidos.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[2].Value);
               cmbTipoIdentificacion.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[3].Value);
               txtIdentificacion.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[4].Value);
               cmbTipoPaciente.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[5].Value);
               cmbGenero.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[6].Value);
               txtEmail.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[7].Value);
               txtFechaNacimiento.Value = Convert.ToDateTime(dtgListaPacientes.Rows[fila].Cells[8].Value);
               cmbOcupacion.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[9].Value);
               cmbEstadoCivil.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[10].Value);
               cmbTipoSangre.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[11].Value);
                txtNSS.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[12].Value);
                txtFechaIngreso.Value = Convert.ToDateTime(dtgListaPacientes.Rows[fila].Cells[13].Value);
                txtPeso.Value = Convert.ToDecimal(dtgListaPacientes.Rows[fila].Cells[14].Value);
                txtAltura.Value = Convert.ToDecimal(dtgListaPacientes.Rows[fila].Cells[15].Value);
                chkActivo.Checked = Convert.ToBoolean(dtgListaPacientes.Rows[fila].Cells[16].Value);
                chkEnviarEmail.Checked = Convert.ToBoolean(dtgListaPacientes.Rows[fila].Cells[17].Value);
                txtObservaciones.Text = Convert.ToString(dtgListaPacientes.Rows[fila].Cells[18].Value);

                //Direcciones
                Direccion.Visible = false;
                
                dtgDirecciones.DataSource = Bl_Direcciones.SearchDireccionesporIDPaciente(Convert.ToInt32(dtgListaPacientes.Rows[fila].Cells[0].Value));
                dtgDirecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               
                //Telefonos
                Telefono.Visible = false;
                
                dtgTelefonos.DataSource = Bl_Telefono.SearchTelefonosporIDPaciente(Convert.ToInt32(dtgListaPacientes.Rows[fila].Cells[0].Value));
                dtgTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                //Contactos
                NombreContacto.Visible = false;
                TelefonoContacto.Visible = false;
                
                dtgContactos.DataSource = Bl_Contacto.SearchContactosporIDPaciente(Convert.ToInt32(dtgListaPacientes.Rows[fila].Cells[0].Value));
                dtgContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

               }
               catch (Exception)
               {
                   MessageBox.Show("Hubo problemas para devolver los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
        }

        private void cmbTipoIdentificacion_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipoIdentificacion.Text == "NA(Menor Edad)")
            {
                txtIdentificacion.Enabled = false;
            }
            else if (cmbTipoIdentificacion.Text == "Cedula")
            {
                txtIdentificacion.Mask = "000-0000000-0";
                txtIdentificacion.Enabled = true;
                txtIdentificacion.Focus();
               
            }
            else 
            {
                txtIdentificacion.Mask = null;
               txtIdentificacion.Enabled = true;
                txtIdentificacion.Focus();
            }
        }

        private void dtgListaPacientes_DoubleClick(object sender, EventArgs e)
        {
            if (dtgListaPacientes.Rows.Count != 0) 
            {
                tbpPrincipalPacientes.SelectedTabPage = tabPacientes;
                txtIdentificacion.Enabled = false;
            }
           
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //si tenemos el tabpaciente activo y textID no esta vacio y no se esta editando entonces borra.
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes && !string.IsNullOrEmpty(txtIDPaciente.Text) && !EDITANDO == true)
            {
                DialogResult Respuesta = MessageBox.Show("Desea realmente eliminar el registro?", "Smarth Health Care", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Respuesta == DialogResult.Yes) 
                {
               
                using (TransactionScope scope = new TransactionScope())
                {

                    try
                    {
                        
                        //Si nunguno de los metodos de borrar emite un error entonces borra

                        if (!Bl_Paciente.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim())) && !Bl_Direcciones.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim()))
                            && !Bl_Telefono.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim())) && !Bl_Contacto.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim())))
                        {

                            MessageBox.Show("Hubo problemas eliminando los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        
                        {

                            //Limpio los Txt
                            Bl_AdministrarControles.VaciarText(frm_pacientes);

                            //Limpio los DatagriedView
                            Bl_AdministrarControles.VaciarDGV(frm_pacientes);

                            //Deshabilito los Txt
                            Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                            //Deshabilito los Datagried
                            Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);
                        
                        }

                  
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                 

                    scope.Complete();
                
                }//fin del Scope
                }

            }// fin del if

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si presinoo backspace y no esta vacio entonces que filte nuevamente.
            if (e.KeyChar == 8 && !string.IsNullOrEmpty(txtFiltro.Text) ) 
            {
                string filtro = Convert.ToString(txtFiltro.Text.Trim());

                ((DataTable)this.dtgListaPacientes.DataSource).DefaultView.RowFilter = @"Paciente Like '%" + filtro + "%'" + "OR Nombres Like '%" + filtro + "%'" + "OR Nombres Like '%" + filtro + "%'"
                    + "OR Identificacion Like '%" + filtro + "%'" + "OR Genero Like '%" + filtro + "%'" + "OR Email Like '%" + filtro + "%'"
                    + "OR NSS Like '%" + filtro + "%'";
                dtgListaPacientes.Refresh();
            }
        }


        private void Frm_Pacientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //vuelvo a poner los estados del sistema
            NUEVO = false;
            EDITANDO = false;
            CONSULTANDO = false;

        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //utilizo un objeto de tipo transacction scope para que se ejecute todo al mismo tiempo solo si no existe problemas

            using (TransactionScope scope = new TransactionScope())
            {
                //si la conexcion esta disponible
                if (Bl_Paciente.VerificarConecxion())
                {
                    //Si tengo seleccionado el tabPacientes, los botones estan enable false  
                    if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes && txtNombres.Enabled == true)
                    {
                        //Validar los datos importantes

                        if (String.IsNullOrEmpty(txtNombres.Text) || String.IsNullOrEmpty(txtApellidos.Text) ||
                            String.IsNullOrEmpty(cmbTipoIdentificacion.Text) || String.IsNullOrEmpty(txtIdentificacion.Text) ||
                            String.IsNullOrEmpty(cmbGenero.Text))
                        {
                            MessageBox.Show("Campos en negrita son obligatorios", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        }
                        else if (!Bl_ValidarControles.ValidaCedula(txtIdentificacion) && cmbTipoIdentificacion.Text == "Cedula")
                        {
                            MessageBox.Show("La cedula proporcionada no es valida", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtIdentificacion.Focus();
                        }
                        else if (!Bl_ValidarControles.ValidarEmail(txtEmail) && txtEmail.Text != string.Empty)
                        {
                            MessageBox.Show("El email no es valido, favor verifique", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtEmail.Focus();

                        }


                        else
                        {
                            try
                            {

                                //Valores Entidad Paciente
                              //  txtIDPaciente.Text = Bl_Paciente.SearchIDPaciente().ToString();//para actualizar
                                paciente.IDPaciente = txtIDPaciente.Text.Trim();
                                paciente.Nombres = txtNombres.Text;
                                paciente.Apellidos = txtApellidos.Text;
                                paciente.IDTipoIdentifacion = cmbTipoIdentificacion.SelectedIndex;
                                paciente.Identificacion = txtIdentificacion.Text;
                                paciente.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                                paciente.IDNivelAcademico = cmbNivelAcademico.SelectedIndex;
                                paciente.IDOcupacion = cmbOcupacion.SelectedIndex;
                                paciente.Genero = cmbGenero.Text;
                                paciente.EstadoCivil = cmbEstadoCivil.Text.Trim();
                                paciente.TipoSangre = cmbTipoSangre.Text.Trim();
                                paciente.TipoPaciente = cmbTipoPaciente.SelectedIndex;
                                paciente.NSS = txtNSS.Text;
                                paciente.Email = txtEmail.Text;
                                paciente.IDNacionalidad = cmbNacionalidad.SelectedIndex;
                                paciente.IDPais = cmbPais.SelectedIndex;
                                paciente.IDRegion = cmbRegion.SelectedIndex;
                                paciente.IDSector = cmbRegion.SelectedIndex;
                                paciente.FechaIngrero = Convert.ToDateTime(txtFechaIngreso.Value.ToString("yyyy-MM-dd"));
                                paciente.Peso = txtPeso.Value;
                                paciente.Altura = txtAltura.Value;
                                paciente.Activo = chkActivo.Checked;
                                paciente.EnvioEmail = chkEnviarEmail.Checked;
                                paciente.Observaciones = txtObservaciones.Text;



                                //-----------------------------------------------------INSERT--------------------------------------------------------------------//

                                if (NUEVO == true)
                                {
                          

                                    //Valores Entidad Direcciones
                                    if (dtgDirecciones.Rows.Count > 1)
                                    {
                                        for (int i = 0; i < dtgDirecciones.RowCount - 1; i++)
                                        {

                                            //paso el valor de la columna a la entidad
                                            direcciones.Direccion = Convert.ToString(dtgDirecciones.Rows[i].Cells[0].Value).Trim();

                                            if (!Bl_Direcciones.Insert(direcciones))
                                            {
                                                seGuardoDirecciones = false;
                                                MessageBox.Show("Hay problemas para insertar las direcciones del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }

                                        }//fin del for dtgDirecciones


                                    }//fin insert direcciones

                                    if (dtgTelefonos.Rows.Count > 1 && seGuardoDirecciones == true)
                                    {
                                        for (int i = 0; i < dtgTelefonos.RowCount - 1; i++)
                                        {

                                            telefonos.Telefono = Convert.ToString(dtgTelefonos.Rows[i].Cells[0].Value).Trim();

                                            if (!Bl_Telefono.Insert(telefonos))
                                            {
                                                seGuardoTelefonos = false;
                                                MessageBox.Show("Hay problemas para insertar los telefonos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }

                                        }//fin del for dtgTelefonos


                                    }//fin insert Telefonos
                                    
                                    if (dtgContactos.Rows.Count > 1 && seGuardoTelefonos == true)
                                    {
                                        for (int i = 0; i < dtgContactos.RowCount - 1; i++)
                                        {

                                            contacto.Contacto = Convert.ToString(dtgContactos.Rows[i].Cells[0].Value).Trim();
                                            contacto.Telefono = Convert.ToString(dtgContactos.Rows[i].Cells[1].Value).Trim();

                                            if (!Bl_Contacto.Insert(contacto))
                                            {
                                                seGuardoContactos = false;
                                                MessageBox.Show("Hay problemas para insertar los contactos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }


                                        }//fin del for dtgContactos

                                    }//fin insert Contactos

                                    if (seGuardoDirecciones == true && seGuardoTelefonos == true && seGuardoContactos == true)
                                    {
                                        if (Bl_Paciente.Insert(paciente)) 
                                        {
                                            txtIDPaciente.Text = Bl_Paciente.SearchIDPaciente().ToString();
                                            //Si todo paso bien

                                            MessageBox.Show("Los datos del paciente fueron insertados correctamente", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            NUEVO = false;

                                            //Deshabilito los Txt
                                            Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                                            //Deshabilito los Datagried
                                            Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);
                                            
                                            //Si se inserto el paciente bien 
                                            seGuardoDirecciones = false;
                                            seGuardoTelefonos = false;
                                            seGuardoTelefonos = false;
                                        }
                                        else
                                            MessageBox.Show("Hay problemas para insertar los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                     

                                    }//fin del insert Bl_Contacto.Inserts
                                       
                                    else
                                    {
                                        MessageBox.Show("Hay problemas para insertar los datos en general del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }



                                }//fin de todos los insert con Nuevo

                                    //-----------------------------------------------------UPDATE--------------------------------------------------------------------//

                                    //si existe un problema entonces muestro un mensaje de aviso al usuario.
                                else if (EDITANDO == true)
                                {

                                    //Valores Entidad Direcciones
                                    if (dtgDirecciones.Rows.Count > 1)
                                    {
                                        if (Bl_Direcciones.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim()))) 
                                        {

                                            for (int i = 0; i < dtgDirecciones.RowCount - 1; i++)
                                            {
                                                direcciones.IDPaciente = txtIDPaciente.Text.Trim();
                                                direcciones.Direccion = Convert.ToString(dtgDirecciones.Rows[i].Cells[0].Value);

                                                if (!Bl_Direcciones.Update(direcciones))
                                                {
                                                    seGuardoDirecciones = false;
                                                    MessageBox.Show("Hay problemas para actualizar las direcciones del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }

                                            }
                                        
                                        }

                                    }

                                    if (dtgTelefonos.Rows.Count > 1 && seGuardoDirecciones == true)
                                    {
                                        if (Bl_Telefono.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim()))) 
                                        {
                                            for (int i = 0; i < dtgTelefonos.RowCount - 1; i++)
                                            {
                                                telefonos.IDPaciente = txtIDPaciente.Text.Trim();
                                                telefonos.Telefono = Convert.ToString(dtgTelefonos.Rows[i].Cells[0].Value);

                                                if (!Bl_Telefono.Update(telefonos)) 
                                                {
                                                    seGuardoTelefonos = false;
                                                    MessageBox.Show("Hay problemas para actualizar los telefonos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                
                                                }

                                            }
                                        
                                        }

                                    }

                                    if (dtgContactos.Rows.Count > 1 && seGuardoTelefonos == true)
                                    {

                                        if (Bl_Contacto.Delete(Convert.ToInt32(txtIDPaciente.Text.Trim()))) 
                                        {
                                            for (int i = 0; i < dtgContactos.RowCount - 1; i++)
                                            {
                                                contacto.IDContacto = txtIDPaciente.Text.Trim();
                                                contacto.Contacto = Convert.ToString(dtgContactos.Rows[i].Cells[0].Value);
                                                contacto.Telefono = Convert.ToString(dtgContactos.Rows[i].Cells[1].Value);

                                                if (!Bl_Contacto.Update(contacto)) 
                                                {
                                                    seGuardoContactos = false;
                                                    MessageBox.Show("Hay problemas para actualizar los contactos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                
                                                }

                                            }//fin del for dtgContactos
                                        
                                        }
                                    }

                                    if (seGuardoDirecciones == true && seGuardoTelefonos == true && seGuardoContactos == true)
                                    {
                                        if (Bl_Paciente.Update(paciente)) 
                                        {

                                            MessageBox.Show("La edición se realizó correctamente", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            //Deshabilito los Txt
                                            Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                                            //Deshabilito los Datagried
                                            Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);

                                            NUEVO = true;
                                            EDITANDO = false;
                                            CONSULTANDO = true;

                                            //si todo anduvo bien
                                            seGuardoDirecciones = false;
                                            seGuardoTelefonos = false;
                                            seGuardoContactos = false;
                                        }

                                    }

                                }//fin del if UPDATE



                            }//FIN DEL TRY
                            catch (Exception)
                            {
                                MessageBox.Show("Hubo un error para obtener los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }


                        }//fin del Else ya se asignaron los valores a la entidad Paciente


                    }//Fin del If TabControl
              

                //si todo esta bien y es el fin del If Tabcontrol envia los datos al sevidor
             
                }
                else if (!Bl_Paciente.VerificarConecxion() && txtNombres.Enabled ==  true)
                {
                    //si no hay una conexcion a la base de datos entonces emitira este mensaje.
                    MessageBox.Show("Hay problemas de conexión a la base de datos, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                scope.Complete();
            }//fin del Using Scope

        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            if (txtDireccion.TextLength != 0 && txtDireccion.Text != string.Empty 
                && txtDireccion.Text != "Agregar una direccion para el paciente" && txtDireccion.Enabled == true) 
            {
                dtgDirecciones.Rows.Add(txtDireccion.Text.Trim());
                txtDireccion.Text = string.Empty;
                txtDireccion.Focus();
            }
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {

            if (dtgDirecciones.Rows.Count != 0 && dtgDirecciones.Rows.Count != 1 && txtDireccion.Enabled ==true)
            {
                dtgDirecciones.Rows.Remove(dtgDirecciones.CurrentRow);
            }

        }

        private void btnAgregarTelefonos_Click(object sender, EventArgs e)
        {
          

            if (Bl_ValidarControles.ValidarTelefono(txtTelefonos) && txtTelefonos.Text != string.Empty)
            {
                txtTelefonos.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                dtgTelefonos.Rows.Add(txtTelefonos.Text.Trim());
                txtTelefonos.Text = string.Empty;
                txtTelefonos.Focus();

            }
         
        }

        private void btnEliminarTelefonos_Click(object sender, EventArgs e)
        {
            if (dtgTelefonos.Rows.Count != 0 && dtgTelefonos.Rows.Count != 1 && txtTelefonos.Enabled == true)
            {
                dtgTelefonos.Rows.Remove(dtgTelefonos.CurrentRow);
            } 
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            if (txtNombreContacto.TextLength != 0 && txtNombreContacto.Text != string.Empty && txtTelefonoContacto.TextLength != 0
                && Bl_ValidarControles.ValidarTelefono(txtTelefonoContacto) && txtNombreContacto.Text != "Agregar nombre de contacto"
                && txtNombreContacto.Enabled == true)
            {
                txtTelefonoContacto.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                dtgContactos.Rows.Add(txtNombreContacto.Text.Trim(),txtTelefonoContacto.Text.Trim());
                txtNombreContacto.Text = string.Empty;
                txtTelefonoContacto.Text = string.Empty;
                txtNombreContacto.Focus();
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            if (dtgContactos.Rows.Count != 0 && dtgContactos.Rows.Count != 1 && txtNombreContacto.Enabled == true)
            {
                dtgContactos.Rows.Remove(dtgContactos.CurrentRow);
            } 
        }


        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == string.Empty) 
            
            {
                txtDireccion.Text = "Agregar una direccion para el paciente";
                txtDireccion.ForeColor = Color.DarkGray;
            }
               
            
        }


        private void txtNombreContacto_Leave(object sender, EventArgs e)
        {
            if (txtNombreContacto.Text == string.Empty)
            {

                txtNombreContacto.Text = "Agregar nombre de contacto";
                txtNombreContacto.ForeColor = Color.DarkGray;
            }
            
        }

        private void Frm_Pacientes_Load(object sender, EventArgs e)
        {
            CONSULTANDO = true;
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtDireccion.Text = string.Empty;
            txtDireccion.ForeColor = Color.Black;
        }

        private void txtNombreContacto_Enter(object sender, EventArgs e)
        {
            txtNombreContacto.Text = string.Empty;
            txtNombreContacto.ForeColor = Color.Black;
        }

   
    }
}
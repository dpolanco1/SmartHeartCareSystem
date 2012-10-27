using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinesLogicLayer;
using EntidadesLayer;
using System.Xml;
using System.Transactions;



namespace aPresentationLayer
{
    public partial class Frm_Pacientes : DevExpress.XtraEditors.XtraForm
    {
        //Entidades
        Ent_Paciente paciente = new Ent_Paciente();
        Ent_Direcciones direcciones = new Ent_Direcciones();
        Ent_Telefono telefonos = new Ent_Telefono();
        Ent_Contacto contacto = new Ent_Contacto();

        //variables del Sistema
        private static bool NUEVO { get; set; }
        private static bool EDITANDO { get; set; }


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
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes)
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

                //Habilitos los Txt
                Bl_AdministrarControles.HabilitarDGV(frm_pacientes);

                //Botones habilitados y Deshabilitados

                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
                btnImprimir.Enabled = false;
                btnEnviar.Enabled = false;
                btnEliminar.Enabled = false;

                //Desabilito el txtIDPaciente
                txtIDPaciente.Enabled = false;
                //Paso el Foco Al Nombre
                txtNombres.Focus();


            }//fin del If 
        }//fin del Boton Nuevo


        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            //utilizo un objeto de tipo transacction scope para que se ejecute todo al mismo tiempo solo si no existe problemas

            using (TransactionScope scope = new TransactionScope())
            {

                //Si tengo seleccionado el tabPacientes, los botones estan enable true y estoy en un registro Nuevo entonces que se realice 
                if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes && txtNombres.Enabled == true)
                {
                    //Validar los datos importantes

                    if (String.IsNullOrEmpty(txtNombres.Text) || String.IsNullOrEmpty(txtApellidos.Text) ||
                        String.IsNullOrEmpty(cmbTipoIdentificacion.Text) || String.IsNullOrEmpty(txtIdentificacion.Text) ||
                        String.IsNullOrEmpty(cmbGenero.Text))
                    {
                        MessageBox.Show("Campos en negrita son obligatorios", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    else
                    {
                        try
                        {

                            //Valores Entidad Paciente
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

                                Bl_Paciente.Insert(paciente);
                                txtIDPaciente.Text = Bl_Paciente.SearchIDPaciente().ToString();

                                //Valores Entidad Direcciones
                                if (dtgDirecciones.Rows.Count != 0)
                                {
                                    for (int i = 0; i < dtgDirecciones.RowCount - 1; i++)
                                    {

                                        direcciones.Direccion = Convert.ToString(dtgDirecciones.Rows[i].Cells[0].Value);
                                        Bl_Direcciones.Insert(direcciones);


                                    }//fin del for dtgDirecciones


                                }

                                if (dtgTelefonos.Rows.Count != 0)
                                {
                                    for (int i = 0; i < dtgTelefonos.RowCount - 1; i++)
                                    {

                                        telefonos.Telefono = Convert.ToString(dtgTelefonos.Rows[i].Cells[0].Value);
                                        Bl_Telefono.Insert(telefonos);


                                    }//fin del for dtgTelefonos


                                }

                                if (dtgContactos.Rows.Count != 0)
                                {
                                    for (int i = 0; i < dtgContactos.RowCount - 1; i++)
                                    {

                                        contacto.Contacto = Convert.ToString(dtgContactos.Rows[i].Cells[0].Value);
                                        contacto.Telefono = Convert.ToString(dtgContactos.Rows[i].Cells[1].Value);
                                        Bl_Contacto.Insert(contacto);

                                    }//fin del for dtgContactos

                                }//fin del insert Bl_Contacto.Insert


                                MessageBox.Show("Los datos del paciente fueron insertados correctamente", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Botones habilitados y Deshabilitados

                                btnNuevo.Enabled = true;
                                btnGuardar.Enabled = false;
                                btnEditar.Enabled = true;
                                btnCancelar.Enabled = false;
                                btnImprimir.Enabled = true;
                                btnEnviar.Enabled = true;
                                btnEliminar.Enabled = true;

                                //Deshabilito los Txt
                                Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                                //Deshabilito los Datagried
                                Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);


                            }//fin de todos los insert con Nuevo

                                //-----------------------------------------------------UPDATE--------------------------------------------------------------------//

                                //si existe un problema entonces muestro un mensaje de aviso al usuario.
                            else if (EDITANDO == true)
                            {

                                txtIDPaciente.Text = Bl_Paciente.SearchIDPaciente().ToString();
                                Bl_Paciente.Update(paciente);


                                //Valores Entidad Direcciones
                                if (dtgDirecciones.Rows.Count != 0)
                                {
                                    direcciones.IDPaciente = txtIDPaciente.Text.Trim();
                                    Bl_Direcciones.Delete(direcciones);

                                    for (int i = 0; i < dtgDirecciones.RowCount - 1; i++)
                                    {

                                        direcciones.Direccion = Convert.ToString(dtgDirecciones.Rows[i].Cells[0].Value);
                                        Bl_Direcciones.Insert(direcciones);

                                    }


                                }//fin del Bl_Direcciones.Insert


                                //   Valores Entidad Telefonos
                                if (dtgTelefonos.Rows.Count != 0)
                                {
                                    telefonos.IDPaciente = txtIDPaciente.Text.Trim();
                                    Bl_Telefono.Delete(telefonos);

                                    for (int i = 0; i < dtgTelefonos.RowCount - 1; i++)
                                    {
                                        telefonos.Telefono = Convert.ToString(dtgTelefonos.Rows[i].Cells[0].Value);
                                        Bl_Telefono.Insert(telefonos);
                                    }


                                }//fin del insert Bl_Telefono.Insert


                                // Valores Entidad Conctacto
                                if (dtgContactos.Rows.Count != 0)
                                {
                                    contacto.IDPaciente = txtIDPaciente.Text.Trim();
                                    Bl_Contacto.Delete(contacto);

                                    for (int i = 0; i < dtgContactos.RowCount - 1; i++)
                                    {

                                        contacto.Contacto = Convert.ToString(dtgContactos.Rows[i].Cells[0].Value);
                                        contacto.Telefono = Convert.ToString(dtgContactos.Rows[i].Cells[1].Value);
                                        Bl_Contacto.Insert(contacto);

                                    }//fin del for dtgContactos
                                }//fin del insert Bl_Contacto.Insert

                                MessageBox.Show("La edición se realizó correctamente", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Botones habilitados y Deshabilitados

                                btnNuevo.Enabled = true;
                                btnGuardar.Enabled = false;
                                btnEditar.Enabled = true;
                                btnCancelar.Enabled = false;
                                btnImprimir.Enabled = true;
                                btnEnviar.Enabled = true;
                                btnEliminar.Enabled = true;

                                //Deshabilito los Txt
                                Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                                //Deshabilito los Datagried
                                Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);



                            }//fin del if
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hubo problemas para insertar los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }//fin del Else ya se asignaron los valores a la entidad Paciente




                }//Fin del If TabControl


                //si todo esta bien y es el fin del If Tabcontrol envia los datos al sevidor
                scope.Complete();

            }//fin del Using Scope

        }//fin del Boton Guardar

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Si tengo seleccionado el tabPacientes entonces que se realice 
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes)
            {
                /*Cambio las variable del sistema a Nuevo = false (me aseguro que este en false) y 
                  Editando = False (indicando que el registro existe) */

                EDITANDO = true;
                NUEVO = false;

                //Botones habilitados y Deshabilitados

                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;
                btnImprimir.Enabled = true;
                btnEnviar.Enabled = true;
                btnEliminar.Enabled = false;


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
            if (tbpPrincipalPacientes.SelectedTabPage == tabPacientes)
            {

                //Botones habilitados y Deshabilitados

                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnImprimir.Enabled = true;
                btnEnviar.Enabled = true;
                btnEliminar.Enabled = true;

                //Limpio los Txt
                Bl_AdministrarControles.VaciarText(frm_pacientes);

                //Limpio los DatagriedView
                Bl_AdministrarControles.VaciarDGV(frm_pacientes);

                //Deshabilito los Txt
                Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                //Deshabilito los Datagried
                Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);

            }// fin del if


        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dtgListaPacientes.DataSource = Bl_Paciente.SearchAll();
            btnCargar.Text = "Filtrar";
            txtFiltro.Enabled = true;
            txtFiltro.Focus();

        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                string filtro = Convert.ToString(txtFiltro.Text.Trim());

                ((DataTable)this.dtgListaPacientes.DataSource).DefaultView.RowFilter = @"Paciente Like '%" + filtro + "%'" + "OR Nombres Like '%" + filtro + "%'" + "OR Nombres Like '%" + filtro + "%'"
                    + "OR Identificacion Like '%" + filtro + "%'" + "OR Genero Like '%" + filtro + "%'" + "OR Email Like '%" + filtro + "%'"
                    + "OR NSS Like '%" + filtro + "%'";
                dtgListaPacientes.Refresh();

            }
            catch (Exception error)
            {
                MessageBox.Show(" Hubo problemas para filtrar la data, comuniquese con el administrador del sistema, disculpe los inconvenientes" + error.Message);
            }


        }

        private void btnBuscar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Buscar.frm_Buscar().Show(this);
        }

        private void dtgListaPacientes_Click(object sender, EventArgs e)
        {
            if (dtgListaPacientes.Rows.Count != 0) 
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

      
            }
        }

    }
}
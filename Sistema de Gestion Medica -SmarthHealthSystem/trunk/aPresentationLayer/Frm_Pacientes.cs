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
                //Limpio los Txt
                Bl_AdministrarControles.VaciarText(frm_pacientes);

                //Limpio los DatagriedView
                Bl_AdministrarControles.VaciarDGV(frm_pacientes);

                //Habilitos los Txt
                Bl_AdministrarControles.HabilitarText(frm_pacientes);

                //Habilitos los Txt
                Bl_AdministrarControles.HabilitarDGV(frm_pacientes);

                //Deshabilito el CampoIDPaciente
                txtIDPaciente.Enabled = false;

                //Paso el Foco Al Nombre
                txtNombres.Focus();
            
            }//fin del If 
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                //Si tengo seleccionado el tabPacientes y los botones estan enable true entonces que se realice 
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
                    //Valores Entidad Paciente
                    paciente.IDPaciente = txtIDPaciente.Text;
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

                    //utilizo un objeto de tipo transacction scope para que se ejecute todo al mismo tiempo solo si no existe problemas

                    using (TransactionScope scope = new TransactionScope())
                    {

                        if (Bl_Paciente.Insert(paciente))
                        {

                            //Valores Entidad Direcciones
                            if (dtgDirecciones.Rows.Count != 0)
                            {
                                for (int i = 0; i < dtgDirecciones.RowCount - 1; i++)
                                {

                                    direcciones.Direccion = Convert.ToString(dtgDirecciones.Rows[i].Cells[0].Value);
                                    Bl_Direcciones.Insert(direcciones);
                                }


                            }//fin del Bl_Direcciones.Insert


                            //   Valores Entidad Telefonos
                            if (dtgTelefonos.Rows.Count != 0)
                            {
                                for (int i = 0; i < dtgTelefonos.RowCount - 1; i++)
                                {

                                    telefonos.Telefono = Convert.ToString(dtgTelefonos.Rows[i].Cells[0].Value);
                                    Bl_Telefono.Insert(telefonos);
                                }


                            }//fin del insert Bl_Telefono.Insert


                            // Valores Entidad Conctacto
                            if (dtgContactos.Rows.Count != 0)
                            {
                                for (int i = 0; i < dtgContactos.RowCount - 1; i++)
                                {

                                    contacto.Contacto = Convert.ToString(dtgContactos.Rows[i].Cells[0].Value);
                                    contacto.Telefono = Convert.ToString(dtgContactos.Rows[i].Cells[1].Value);
                                    Bl_Contacto.Insert(contacto);
                                }
                            }//fin del insert Bl_Contacto.Insert

                            //completo el rango de Metodos enviado los valores.
                            scope.Complete();

                            MessageBox.Show("El paciente fue insertado correctamente", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Limpio los Txt
                            Bl_AdministrarControles.VaciarText(frm_pacientes);

                            //Limpio los DatagriedView
                            Bl_AdministrarControles.VaciarDGV(frm_pacientes);

                            //Deshabilito los Txt
                            Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

                            //Deshabilito los Datagried
                            Bl_AdministrarControles.DeshabilitarDGV(frm_pacientes);

                        }//fin de todos los insert

                            //si existe un problema entonces muestro un mensaje de aviso al usuario.
                        else
                        {

                            MessageBox.Show("Hubo problemas para la inserccion de los datos del paciente, comuniquese con el administrador del sistema, disculpe los inconvenientes", "Smarth Health Care", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }//fin del Scope Transacction

                }//fin del else comprobando los campos obligatorios.

            }//fin del If Tabcontrol
            
        }//fin del metodo del Boton Guardar

    }
}
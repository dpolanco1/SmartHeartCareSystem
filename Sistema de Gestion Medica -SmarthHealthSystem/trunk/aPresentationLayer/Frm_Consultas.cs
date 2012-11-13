using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EntidadesLayer;
using BussinesLogicLayer;
using System.Transactions;

namespace aPresentationLayer
{
    public partial class Frm_Consultas : DevExpress.XtraEditors.XtraForm
    {
        readonly Ent_Consultas consulta = new Ent_Consultas();
        int flag = 0, flag2 = 0;

        private static Frm_Consultas frm_consultas; // Referencia estática al mismo formulario

        public static Frm_Consultas frm_Consultas()// Método estatico que hace referencia a el mismo
        {
            if (frm_consultas == null || frm_consultas.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_consultas = new Frm_Consultas(); // Se crea instancia
            }
            else
            {
                frm_consultas.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_consultas; // Retornamos el valor
        }//fin del metodo
        public Frm_Consultas()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabPrincipalConsultas.SelectedTabPage == tabConsultas)
            {
                searchMedico.Enabled = true;
                searchPaciente.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEnviar.Enabled = true;
                btnImprimir.Enabled = true;
                txtMotivo.Enabled = true;
                txtdiagnostico.Enabled = true;
                txtMotivo.Text = "Agregue motivo de la consulta";
                txtdiagnostico.Text = "Agregue diagnostico de la consulta";
                txtMotivo.ForeColor = Color.DarkGray;
                txtdiagnostico.ForeColor = Color.DarkGray;
                flag = 0;
                flag2 = 0;
            }
        }


        private void txtMotivo_Enter(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                txtMotivo.Text = string.Empty;
                txtMotivo.ForeColor = Color.Black;
                flag = 1;
            }
        }

        private void txtMotivo_Leave(object sender, EventArgs e)
        {
            if (txtMotivo.TextLength <= 0)
            {
                txtMotivo.Text = "Agregue motivo de la consulta";
                txtMotivo.ForeColor = Color.DarkGray;
                flag = 0;
            }
        }

        private void txtdiagnostico_Enter(object sender, EventArgs e)
        {
            if (flag2 == 0)
            {
                txtdiagnostico.Text = string.Empty;
                txtdiagnostico.ForeColor = Color.Black;
                flag2 = 1;
            }
        }

        private void txtdiagnostico_Leave(object sender, EventArgs e)
        {
            if (txtdiagnostico.TextLength <= 0)
            {
                txtdiagnostico.Text = "Agregue diagnostico de la consulta";
                txtdiagnostico.ForeColor = Color.DarkGray;
                flag2 = 0;
            }
        }

        private void searchLookUpEdit1View_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtNombremedico.Text = searchMedico.Properties.View.GetFocusedRowCellValue("Medico").ToString();
            txtespacialidad.Text = searchMedico.Properties.View.GetFocusedRowCellValue("Especialidad").ToString();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtNombrePaciente.Text = searchPaciente.Properties.View.GetFocusedRowCellValue("Paciente").ToString();
            txtedad.Text = Edad(Convert.ToDateTime(searchPaciente.Properties.View.GetFocusedRowCellValue("fechanacimiento"))).ToString();
            txtpeso.Text = searchPaciente.Properties.View.GetFocusedRowCellValue("peso").ToString();
            txtaltura.Text = searchPaciente.Properties.View.GetFocusedRowCellValue("altura").ToString();
            txttiposangre.Text = searchPaciente.Properties.View.GetFocusedRowCellValue("tiposangre").ToString();
        }
        #region Funcion obtener edad
        private static int Edad(DateTime fechaNacimiento)
        {
            //Obtengo la diferencia en años.
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            //Obtengo la fecha de cumpleaños de este año.
            DateTime nacimientoAhora = fechaNacimiento.AddYears(edad);
            //Le resto un año si la fecha actual es anterior 
            //al día de nacimiento.
            if (DateTime.Now.CompareTo(nacimientoAhora) < 0)
                edad--;

            return edad;
        }
        #endregion

        private void btnGuardar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                if (BL_Consultas.VerificarConexion())
                {
                    if (tabPrincipalConsultas.SelectedTabPage == tabConsultas)
                    {
                        consulta.IDPaciente = Convert.ToInt32(searchPaciente.Properties.View.GetFocusedRowCellValue("idpaciente"));
                        consulta.IDMedico = Convert.ToInt32(searchMedico.Properties.View.GetFocusedRowCellValue("idmedico"));
                        consulta.Motivo = txtMotivo.Text;
                        consulta.Diagnostico = txtdiagnostico.Text;
                        if (BL_Consultas.Insert(consulta) && flag == 1 && flag2 == 1)
                        {
                            MessageBox.Show("Consulta registrada", "SmartHealthCare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Bl_AdministrarControles.DeshabilitarText(this);
                            Bl_AdministrarControles.VaciarText(this);
                            searchMedico.Enabled = false;
                            searchPaciente.Enabled = false;
                        }
                        else
                            MessageBox.Show("Error guardando la consulta, verifique campos", "SmartHealthCare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Erro en conexion a base de datos, comuniquese con su administrador", "SmartHealthCare", MessageBoxButtons.OK, MessageBoxIcon.Error);

                scope.Complete();
            }
        }

        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bl_AdministrarControles.DeshabilitarText(this);
            Bl_AdministrarControles.VaciarText(this);
            searchMedico.Enabled = false;
            searchPaciente.Enabled = false;
        }

        private void Frm_Consultas_Activated(object sender, EventArgs e)
        {
            searchMedico.Properties.DataSource = BL_Consultas.GetAllMedicos();
            searchMedico.Properties.ValueMember = "idmedico";
            searchMedico.Properties.DisplayMember = "Medico";


            searchPaciente.Properties.DataSource = BL_Consultas.GetAllPacientes();
            searchPaciente.Properties.ValueMember = "idpaciente";
            searchPaciente.Properties.DisplayMember = "Paciente";
        }

  
    }
}

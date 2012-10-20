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


namespace aPresentationLayer
{
    public partial class Frm_Pacientes : DevExpress.XtraEditors.XtraForm
    {

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
            Bl_AdministrarControles.VaciarText(frm_pacientes);
            Bl_AdministrarControles.HabilitarText(frm_pacientes);
            dtgDirecciones.DataSource = Bl_Paciente.SearchID();
            txtIDPaciente.Focus();
         
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Bl_AdministrarControles.VaciarText(frm_pacientes);
            Bl_AdministrarControles.DeshabilitarText(frm_pacientes);

            
        }

    }
}
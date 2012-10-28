using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinesLogicLayer;

namespace aPresentationLayer
{
    public partial class Frm_HistorialClinico : DevExpress.XtraEditors.XtraForm
    {
        EntidadesLayer.Ent_HistorialClinico entHistorial = new EntidadesLayer.Ent_HistorialClinico();
      
   

        //Hago que el formulario sea singleton....

        private static Frm_HistorialClinico frm_historialclinico; // Referencia estática al mismo formulario

        public static Frm_HistorialClinico frm_HistorialClinico() // Método estatico que hace referencia a el mismo
        {
            if (frm_historialclinico == null || frm_historialclinico.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_historialclinico = new Frm_HistorialClinico(); // Se crea instancia
            }
            else
            {
                frm_historialclinico.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_historialclinico; // Retornamos el valor
        }//fin del metodo

        public Frm_HistorialClinico()
        {
            InitializeComponent();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            entHistorial.IDPaciente = Convert.ToInt32( txtIDpaciente.Text);
            entHistorial.RemitidoPor = txtRemitidoPor.Text;
            entHistorial.SintomasEvoluciones = txtSintomas.Text;



            BussinesLogicLayer.Bl_HistorialClinico.Insert(entHistorial);

        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Bl_AdministrarControles.VaciarText(frm_historialclinico);
            Bl_AdministrarControles.HabilitarText(frm_historialclinico);
            //txtHistorial.Enabled = false;
            //txtIDpaciente.Enabled = false;
            txtNombre.Focus();
        }

        private void grpDatosGenerales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
          
            //Busco todos los pacientes
           
                  

        }
    }
}
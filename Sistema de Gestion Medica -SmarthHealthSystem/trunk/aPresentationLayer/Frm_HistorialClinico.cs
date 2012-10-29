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


namespace aPresentationLayer
{
    public partial class Frm_HistorialClinico : DevExpress.XtraEditors.XtraForm
    {
        Ent_HistorialClinico entHistorial = new Ent_HistorialClinico();
        Ent_AntecedentesPersonales entAntecedes = new Ent_AntecedentesPersonales();
      
   

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

            entAntecedes.InfartoMiocardioPrevio = chkInfartoMioPrev.Checked;
            entAntecedes.InsuficienciaCardiaca = chkInsuficienciaCardiaca.Checked;
            entAntecedes.HipertensionArterial = chkHipertensionArterial.Checked;
            entAntecedes.Valvulopatia = chkValvulopatia.Checked;
            entAntecedes.Arritmia = chkArritmia.Checked;
            entAntecedes.DiabetisMellitas =  chkDiabetesMellitas.Checked;
            entAntecedes.EnfermedadRenal = chkEnfermedadRenal.Checked;
            entAntecedes.EnfermedadHepatica = chkEnfermedadHepatica.Checked;
            entAntecedes.EnfermedadPulmonar = chkEnfermedadPulmonar.Checked;
            entAntecedes.Tiroides = chkTiroides.Checked;
            entAntecedes.ACV = chkACV.Checked;
            entAntecedes.ASMA = chkASMA.Checked;
            entAntecedes.Gastritis = chkGastritis.Checked;
            entAntecedes.UlceraPeptica = chkUlceraPeptica.Checked;
            entAntecedes.Amigdalitis = chkAmigdalitis.Checked;
            entAntecedes.DoloresCronicosCabeza = chkDolorCabeza.Checked;
            entAntecedes.EnfermedadesRinon = chkEnfermedadRinon.Checked;
            entAntecedes.Convulsiones = chkConvusliones.Checked;
            entAntecedes.SentidoDevilOlfato = chkSentidoOlfato.Checked;
            entAntecedes.Obesidad = chkObesidad.Checked;
            entAntecedes.EnfermedadesHigado = chkEnferdadHigado.Checked;
            entAntecedes.EnfermedadesTransmisionSexual = chkEnferTransSexual.Checked;
            entAntecedes.Cancer = chkCancer.Checked;
            entAntecedes.Alergias = chkAlergias.Checked;
            entAntecedes.Descripcion = txtDescripcionAntecedentes.Text;




            BussinesLogicLayer.Bl_HistorialClinico.Insert(entHistorial);
            BussinesLogicLayer.Bl_AntecedentesPersonales.Insert(entAntecedes);


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

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
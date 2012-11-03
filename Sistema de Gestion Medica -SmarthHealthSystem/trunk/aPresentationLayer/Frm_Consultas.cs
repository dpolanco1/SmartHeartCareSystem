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

namespace aPresentationLayer
{
    public partial class Frm_Consultas : DevExpress.XtraEditors.XtraForm
    {
        readonly Ent_Consultas consulta;

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

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          /*  string error ="";
            consulta.IDMedico = searchMedico. // corra la aplicacion ook
     entonces lo que usted quiere es el ID o el valor de la celda del ID?? Observe esto      
           if(BL_Consultas.Insert(*/
            MessageBox.Show("" + searchLookUpEdit1View.GetFocusedValue()); //YAajejejejejej
        }

        private void Frm_Consultas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartHearthCareDbDataSet1.tbl_pacientes' table. You can move, or remove it, as needed.
            this.tbl_pacientesTableAdapter.Fill(this.smartHearthCareDbDataSet1.tbl_pacientes);
            // TODO: This line of code loads data into the 'smartHearthCareDbDataSet.tbl_medicos' table. You can move, or remove it, as needed.
            this.tbl_medicosTableAdapter.Fill(this.smartHearthCareDbDataSet.tbl_medicos);

        }
    }
}
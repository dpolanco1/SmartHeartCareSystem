using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace aPresentationLayer
{
    public partial class Frm_Agenda : DevExpress.XtraEditors.XtraForm
    {
        //Hago que el formulario sea singleton....

        private static Frm_Agenda frm_agenda; // Referencia estática al mismo formulario

        public static Frm_Agenda frm_Agenda() // Método estatico que hace referencia a el mismo
        {
            if (frm_agenda == null || frm_agenda.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_agenda = new Frm_Agenda(); // Se crea instancia
            }
            else
            {
                frm_agenda.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_agenda; // Retornamos el valor
        }//fin del metodo


        public Frm_Agenda()
        {
            InitializeComponent();
            schedulerControl1.Start = System.DateTime.Now;
        }
    }
}
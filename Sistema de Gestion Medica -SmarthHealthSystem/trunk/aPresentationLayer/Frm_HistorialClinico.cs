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
    public partial class Frm_HistorialClinico : DevExpress.XtraEditors.XtraForm
    {
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
    }
}
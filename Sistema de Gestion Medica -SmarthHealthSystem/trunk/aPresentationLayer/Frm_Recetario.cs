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
    public partial class Frm_Recetario : DevExpress.XtraEditors.XtraForm
    {


        private static Frm_Recetario frm_recetario; // Referencia estática al mismo formulario

        public static Frm_Recetario frm_Recetario()// Método estatico que hace referencia a el mismo
        {
            if (frm_recetario == null || frm_recetario.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_recetario = new Frm_Recetario(); // Se crea instancia
            }
            else
            {
                frm_recetario.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_recetario; // Retornamos el valor
        }//

        public Frm_Recetario()
        {
            InitializeComponent();
        }
    }
}
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
    public partial class Frm_Empleados : DevExpress.XtraEditors.XtraForm
    {
        //Hago que el formulario sea singleton....

        private static Frm_Empleados frm_empleados; // Referencia estática al mismo formulario

        public static Frm_Empleados frm_Empleados() // Método estatico que hace referencia a el mismo
        {
            if (frm_empleados == null || frm_empleados.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_empleados = new Frm_Empleados(); // Se crea instancia
            }
            else
            {
                frm_empleados.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_empleados; // Retornamos el valor
        }//fin del metodo

        public Frm_Empleados()
        {
            InitializeComponent();
        }
    }
}
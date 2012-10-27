using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aPresentationLayer
{
    public partial class Frm_Buscar : Form
    {


        private static Frm_Buscar frm_buscar; // Referencia estática al mismo formulario

        public static Frm_Buscar frm_Buscar() // Método estatico que hace referencia a el mismo
        {
            if (frm_buscar == null || frm_buscar.IsDisposed) // Comprobar si el form esta Null (No ejecutado)
            {
                frm_buscar = new Frm_Buscar(); // Se crea instancia
            }
            else
            {
                frm_buscar.BringToFront(); // De lo contrario, se pasa al frente
            }

            return frm_buscar; // Retornamos el valor
        }//fin del metodo

        public Frm_Buscar()
        {
            InitializeComponent();
        }
    }
}

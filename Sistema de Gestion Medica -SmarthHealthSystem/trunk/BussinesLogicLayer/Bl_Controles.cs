using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BussinesLogicLayer
{
  public  abstract class Bl_Controles
    {

        public bool ValidarEmail(string email)
        {
            if (email == string.Empty)
                return false;

            if (System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                return true;
            else
                return false;
        }

        public static void LimipiarFormulario(Control formulario) {

            foreach  (Control controles in formulario.Controls)
            {
                if (controles is TextBox) {

                    controles.Text = "";
                
                }
            }

        }

    }
}

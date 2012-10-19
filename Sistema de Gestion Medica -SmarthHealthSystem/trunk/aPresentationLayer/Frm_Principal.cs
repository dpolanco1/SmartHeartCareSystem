using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using aPresentationLayer;


namespace WindowsApplication1
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void itemHistorialClinico_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Frm_HistorialClinico.frm_HistorialClinico().MdiParent = this;
            Frm_HistorialClinico.frm_HistorialClinico().Show();
        }

        private void ItemPacientes_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
          
            Frm_Pacientes.frm_Pacientes().MdiParent = this;
            Frm_Pacientes.frm_Pacientes().Show();
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen_GL_Groupe01._4._Connexion;
using Examen_GL_Groupe01._1.Classes;
using System.Data.SqlClient;
using Examen_GL_Groupe01._2._Users_Controls;

namespace Examen_GL_Groupe01._3._Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            SidePanel.Height = btnPersonne.Height;
            SidePanel.Top = btnPersonne.Top;
            frmPersonne1.BringToFront();
        }

        private void btnPersonne_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPersonne.Height;
            SidePanel.Top = btnPersonne.Top;
            frmPersonne1.BringToFront();
        }

        private void btnAdresse_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAdresse.Height;
            SidePanel.Top = btnAdresse.Top;
            frmAdresse1.BringToFront();
        }

        private void btnDomicile_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDomicile.Height;
            SidePanel.Top = btnDomicile.Top;
            frmDomicile1.BringToFront();
        }

        private void btnTelephone_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTelephone.Height;
            SidePanel.Top = btnTelephone.Top;
            frmTelephone1.BringToFront();
        }


        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment vous deconnectez ?", "Deconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmConnexion con = new frmConnexion();
                con.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez-vous vraiment quitter ?", "Formulaire Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

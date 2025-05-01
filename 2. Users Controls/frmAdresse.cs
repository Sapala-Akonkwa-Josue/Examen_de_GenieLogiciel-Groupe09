using Examen_GL_Groupe01._1.Classes;
using Examen_GL_Groupe01._4._Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using DGVPrinterHelper;
using static DGVPrinterHelper.DGVPrinter;
using System.IO;

namespace Examen_GL_Groupe01._2._Users_Controls
{
    public partial class frmAdresse : UserControl
    {
        public frmAdresse()
        {
            InitializeComponent();
        }

        Adresse adresse = new Adresse();

        DataAccess data = new DataAccess();

        private void BindingClass()
        {
            adresse.Id = txtIdAdresse.Text;
            adresse.Quartier = txtQuartier.Text;
            adresse.Commune = txtCommune.Text;
            adresse.Ville = txtVille.Text;
            adresse.Pays = txtPays.Text;
        }

        private void LoadlistAdresse()
        {
            try
            {
                DgAdresse.DataSource = adresse.GetAdresse();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdAdresse.Clear();
            txtQuartier.Clear();
            txtCommune.Clear();
            txtVille.Clear();
            txtPays.Clear();
        }

        private void frmAdresse_Load(object sender, EventArgs e)
        {
            LoadlistAdresse();
        }

        private void DgAdresse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdAdresse.Text = DgAdresse["id", DgAdresse.CurrentRow.Index].Value.ToString();
            txtQuartier.Text = DgAdresse["quartier", DgAdresse.CurrentRow.Index].Value.ToString();
            txtCommune.Text = DgAdresse["commune", DgAdresse.CurrentRow.Index].Value.ToString();
            txtVille.Text = DgAdresse["ville", DgAdresse.CurrentRow.Index].Value.ToString();
            txtPays.Text = DgAdresse["pays", DgAdresse.CurrentRow.Index].Value.ToString();
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = adresse.Enregistrer(adresse);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse ajoutée avec succès", "Ajout Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistAdresse();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout de l'adresse a echoué", "Ajout Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = adresse.Modifier(adresse);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse modifiée avec succès", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistAdresse();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La modification a echouée", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la modification de l'adresse. Contactez l'administrateur svp ! ", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = adresse.Supprimer(adresse);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse supprimée avec succès", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistAdresse();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la suppression de l'adresse. Contactez l'administrateur svp ! ", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES ADRESSES\n\n";
            printer.SubTitle = string.Format("XXXXXXXXXXXXXXXXXXXXXXXXXX\n\n", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "xxxxxxxxxxxxxxxxxxxxx";
            printer.FooterSpacing = 15;

            printer.PrintPreviewDataGridView(DgAdresse);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using Examen_GL_Groupe01._1.Classes;
using Examen_GL_Groupe01._4._Connexion;

namespace Examen_GL_Groupe01._2._Users_Controls
{
    public partial class frmPersonne : UserControl
    {
        public frmPersonne()
        {
            InitializeComponent();
        }

        Personne personne = new Personne();

        DataAccess data = new DataAccess();

        private void BindingClass()
        {
            personne.Id = txtIdPersonne.Text;
            personne.Nom = txtNom.Text;
            personne.Postnom = txtPostnom.Text;
            personne.Prenom = txtPrenom.Text;
            if (rbM.Checked)
            {
                personne.Sexe = 'M';
            }
            else
            {
                personne.Sexe = 'F';
            }
        }

        private void LoadlistPersonne()
        {
            try
            {
                DgPersonne.DataSource = personne.GetPersonne();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdPersonne.Clear();
            txtNom.Clear();
            txtPostnom.Clear();
            txtPrenom.Clear();
            rbM.Checked = true;
            rbF.Checked = false;
        }

        private void frmPersonne_Load(object sender, EventArgs e)
        {
            LoadlistPersonne();
            rbM.Checked = true;
        }

        private void DgPersonne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPersonne.Text = DgPersonne["id", DgPersonne.CurrentRow.Index].Value.ToString();
            txtNom.Text = DgPersonne["nom", DgPersonne.CurrentRow.Index].Value.ToString();
            txtPostnom.Text = DgPersonne["postnom", DgPersonne.CurrentRow.Index].Value.ToString();
            txtPrenom.Text = DgPersonne["prenom", DgPersonne.CurrentRow.Index].Value.ToString();
            rbM.Checked = DgPersonne["sexe", DgPersonne.CurrentRow.Index].Value.ToString() == "M";
            rbF.Checked = DgPersonne["sexe", DgPersonne.CurrentRow.Index].Value.ToString() == "F";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES PERSONNES\n\n";
            printer.SubTitle = string.Format("XXXXXXXXXXXXXXXXXXXXXXXXXX\n\n", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "xxxxxxxxxxxxxxxxxxxxx";
            printer.FooterSpacing = 15;

            printer.PrintPreviewDataGridView(DgPersonne);
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = personne.Enregistrer(personne);
                if (resultat > 0)
                {
                    MessageBox.Show("Personne ajoutée avec succès", "Ajout Personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistPersonne();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout de la personne a echoué", "Ajout Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = personne.Modifier(personne);
                if (resultat > 0)
                {
                    MessageBox.Show("Personne modifiée avec succès", "Modification Personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistPersonne();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La modification a echouée", "Modification Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la modification de la personne. Contactez l'administrateur svp ! ", "Modification Personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = personne.Supprimer(personne);
                if (resultat > 0)
                {
                    MessageBox.Show("Personne supprimée avec succès", "Suppression Personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistPersonne();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Personne", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la suppression de la personne. Contactez l'administrateur svp ! ", "Suppression Personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

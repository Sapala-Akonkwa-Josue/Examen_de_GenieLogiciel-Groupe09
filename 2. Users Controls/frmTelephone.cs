using DGVPrinterHelper;
using Examen_GL_Groupe01._1.Classes;
using Examen_GL_Groupe01._4._Connexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_GL_Groupe01._2._Users_Controls
{
    public partial class frmTelephone : UserControl
    {
        public frmTelephone()
        {
            InitializeComponent();
        }


        Telephone telephone = new Telephone();

        DataAccess data = new DataAccess();

        private void ChargerComboPersonne()
        {
            //Load ComboBox Personne
            cmbPersonne.DataSource = new Personne().GetPersonne();
            cmbPersonne.DisplayMember = "nom";
            cmbPersonne.ValueMember = "nom";
        }

        private void BindingClass()
        {
            telephone.Id = txtIdPhone.Text;
            telephone.IdPersonne = txtIdPersonne.Text;
            telephone.Initial = txtInitial.Text;
            telephone.Numero = txtNumero.Text;
        }

        private void LoadlistTelephone()
        {
            try
            {
                DgTelephone.DataSource = telephone.GetTelephone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdPhone.Clear();
            txtIdPersonne.Clear();
            txtInitial.Clear();
            txtNumero.Clear();
            cmbPersonne.Enabled = true;
            txtPersonne.Visible = false;
        }

        private void frmTelephone_Load(object sender, EventArgs e)
        {
            LoadlistTelephone();
            ChargerComboPersonne();
        }

        private void DgTelephone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPhone.Text = DgTelephone["id", DgTelephone.CurrentRow.Index].Value.ToString();
            txtIdPersonne.Text = DgTelephone["idPersonne", DgTelephone.CurrentRow.Index].Value.ToString();
            txtInitial.Text = DgTelephone["initial", DgTelephone.CurrentRow.Index].Value.ToString();
            txtNumero.Text = DgTelephone["numero", DgTelephone.CurrentRow.Index].Value.ToString();
            cmbPersonne.Enabled = false;
            txtPersonne.Visible = true;
        }

        private void cmbPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select id from personne where nom = '" + cmbPersonne.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtIdPersonne.Text = dt.Rows[i]["id"].ToString();
                }
            }
        }

        private void txtIdPersonne_TextChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select nom from personne where id = '" + txtIdPersonne.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtPersonne.Text = dt.Rows[i]["nom"].ToString();
                }
            }
            else if (txtPersonne.Text == "")
            {
                txtPersonne.Text = "";
            }
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = telephone.Enregistrer(telephone);
                if (resultat > 0)
                {
                    MessageBox.Show("Téléphone ajoutée avec succès", "Ajout Téléphone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistTelephone();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout du numéro a echoué", "Ajout Téléphone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Téléphone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = telephone.Modifier(telephone);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse modifiée avec succès", "Modification Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistTelephone();
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
                int resultat = telephone.Supprimer(telephone);
                if (resultat > 0)
                {
                    MessageBox.Show("Adresse supprimée avec succès", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistTelephone();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors du suppression de l'adresse. Contactez l'administrateur svp ! ", "Suppression Adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES PERSONNES AVEC NUMEROS RELATIFS\n\n";
            printer.SubTitle = string.Format("XXXXXXXXXXXXXXXXXXXXXXXXXX\n\n", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "xxxxxxxxxxxxxxxxxxxxx";
            printer.FooterSpacing = 15;

            printer.PrintPreviewDataGridView(DgTelephone);
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerComboPersonne();
        }
    }
}

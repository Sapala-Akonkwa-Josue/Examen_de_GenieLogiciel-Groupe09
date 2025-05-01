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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_GL_Groupe01._2._Users_Controls
{
    public partial class frmDomicile : UserControl
    {
        public frmDomicile()
        {
            InitializeComponent();
        }

        Domicile domicile = new Domicile();

        DataAccess data = new DataAccess();

        private void ChargerComboPersonne()
        {
            //Load ComboBox Personne
            cmbPersonne.DataSource = new Personne().GetPersonne();
            cmbPersonne.DisplayMember = "nom";
            cmbPersonne.ValueMember = "nom";
        }

        private void ChargerComboAdresse()
        {
            //Load ComboBox Quartier
            cmbAdresse.DataSource = new Adresse().GetAdresse();
            cmbAdresse.DisplayMember = "quartier";
            cmbAdresse.ValueMember = "quartier";
        }

        private void BindingClass()
        {
            domicile.Id = txtIdDomicile.Text;
            domicile.IdPersonne = txtIdPersonne.Text;
            domicile.IdAdresse = txtIdAdresse.Text;
            domicile.Avenue = txtAvenue.Text;
            domicile.NumeroAvenue = txtNumAv.Text;
        }

        private void LoadlistDomicile()
        {
            try
            {
                DgDomicile.DataSource = domicile.GetDomicile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearField()
        {
            txtIdDomicile.Clear();
            txtIdPersonne.Clear();
            txtIdAdresse.Clear();
            txtAvenue.Clear();
            txtNumAv.Clear();
            cmbPersonne.Enabled = true;
            cmbAdresse.Enabled = true;
            txtPersonne.Visible = false;
            txtAdresse.Visible = false;
        }

        private void frmDomicile_Load(object sender, EventArgs e)
        {
            LoadlistDomicile();
            ChargerComboAdresse();
            ChargerComboPersonne();
        }

        private void DgDomicile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDomicile.Text = DgDomicile["id", DgDomicile.CurrentRow.Index].Value.ToString();
            txtIdPersonne.Text = DgDomicile["idPersonne", DgDomicile.CurrentRow.Index].Value.ToString();
            txtIdAdresse.Text = DgDomicile["idAdresse", DgDomicile.CurrentRow.Index].Value.ToString();
            txtAvenue.Text = DgDomicile["avenue", DgDomicile.CurrentRow.Index].Value.ToString();
            txtNumAv.Text = DgDomicile["NumeroAvenue", DgDomicile.CurrentRow.Index].Value.ToString();
            cmbPersonne.Enabled = false;
            cmbAdresse.Enabled = false;
            txtPersonne.Visible = true;
            txtAdresse.Visible = true;
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

        private void cmdAdresse_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select id from adresse where quartier = '" + cmbAdresse.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtIdAdresse.Text = dt.Rows[i]["id"].ToString();
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

        private void txtIdAdresse_TextChanged(object sender, EventArgs e)
        {
            data.OpenConnection();
            string query = "select quartier from adresse where id = '" + txtIdAdresse.Text + "'";
            SqlCommand cmd = new SqlCommand(query, data.connection);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txtAdresse.Text = dt.Rows[i]["quartier"].ToString();
                }
            }
            else if (txtPersonne.Text == "")
            {
                txtAdresse.Text = "";
            }
        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = domicile.Enregistrer(domicile);
                if (resultat > 0)
                {
                    MessageBox.Show("Domicile ajouté avec succès", "Ajout Domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistDomicile();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("L'ajout du domicile a echoué", "Ajout Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit. Contactez l'adminisatrateur svp ! ", "Ajout Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = domicile.Modifier(domicile);
                if (resultat > 0)
                {
                    MessageBox.Show("Domicile modifié avec succès", "Modification Domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistDomicile();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La modification a echouée", "Modification Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la modification du domicile. Contactez l'administrateur svp ! ", "Modification Domicile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BindingClass();
                int resultat = domicile.Supprimer(domicile);
                if (resultat > 0)
                {
                    MessageBox.Show("Domicile supprimé avec succès", "Suppression Domicile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadlistDomicile();
                    ClearField();
                }
                else
                {
                    MessageBox.Show("La suppression a echouée", "Suppression Domicile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un probleme s'est produit lors de la suppression du domicile. Contactez l'administrateur svp ! ", "Suppression Domicile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "LISTE DES PERSONNES AVEC ADRESSES RESPECTIVES\n\n";
            printer.SubTitle = string.Format("XXXXXXXXXXXXXXXXXXXXXXXXXX\n\n", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "xxxxxxxxxxxxxxxxxxxxx";
            printer.FooterSpacing = 15;

            printer.PrintPreviewDataGridView(DgDomicile);
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerComboAdresse();
            ChargerComboPersonne();
        }
    }
}

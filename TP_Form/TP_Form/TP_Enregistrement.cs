using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace TP_Form
{
    public partial class TP_Enregistrement : Form
    {
        public TP_Enregistrement()
        {
            InitializeComponent();
            AddColumns(); // Initialiser les colonnes une seule fois
        }

        DataTable dt = new DataTable("table");

        // Méthode pour ajouter les colonnes au DataTable
        void AddColumns()
        {
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Adresse", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
            dt.Columns.Add("Sexe", typeof(string));
            dataGrid.DataSource = dt;
        }

        // Méthode pour ajouter une nouvelle ligne au DataTable
        void AddRows()
        {
            try
            {
                dt.Rows.Add(txt_Name.Text, txt_Adresse.Text, txt_Contact.Text, combo_Sex.Text);
                ClearInputs(); // Effacer les champs après l'ajout
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Méthode pour modifier la ligne sélectionnée
        void Modify()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                selectedRow.Cells["Nom"].Value = txt_Name.Text;
                selectedRow.Cells["Adresse"].Value = txt_Adresse.Text;
                selectedRow.Cells["Contact"].Value = txt_Contact.Text;
                selectedRow.Cells["Sexe"].Value = combo_Sex.Text;
                ClearInputs(); // Effacer les champs après la modification
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Méthode pour supprimer la ou les lignes sélectionnées
        void DeleteRows()
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGrid.SelectedRows)
                {
                    if (!row.IsNewRow) // Vérifier que la ligne n'est pas une nouvelle ligne vide
                    {
                        dataGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ou plusieurs lignes à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Méthode pour effacer les champs de saisie
        void ClearInputs()
        {
            txt_Name.Clear();
            txt_Adresse.Clear();
            txt_Contact.Clear();
            combo_Sex.SelectedIndex = -1;
        }

        // Événement du bouton "Enregistrer"
        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            AddRows();
        }

        // Événement du bouton "Actualiser"
        private void btn_Actualiser_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = dt;
        }

        // Événement du bouton "Modifier"
        private void btn_Mod_Click(object sender, EventArgs e)
        {
            Modify();
        }



        // Événement lors du clic sur une cellule du DataGridView
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGrid.Rows[e.RowIndex];

                // Afficher les données de la ligne sélectionnée dans les TextBox et ComboBox
                txt_Name.Text = selectedRow.Cells["Nom"].Value.ToString();
                txt_Adresse.Text = selectedRow.Cells["Adresse"].Value.ToString();
                txt_Contact.Text = selectedRow.Cells["Contact"].Value.ToString();
                combo_Sex.Text = selectedRow.Cells["Sexe"].Value.ToString();
            }
        }

        // Événement du bouton "Supprimer"

        private void btn_Supp_Click_1(object sender, EventArgs e)
        {
            DeleteRows();
        }
    }
}
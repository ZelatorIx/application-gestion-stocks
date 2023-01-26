using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Negosud.webapi.Models;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Negosud.WinForm
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crée un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAddNewSupplier_Click(object sender, EventArgs e)
        {
            // 1 Récupérer les valeurs de(s) textBox
            string Name = TextBoxSupName.Text;
            string email = TextBoxSupEmail.Text;
            string phoneNumber = TextBoxSupPhoneNumber.Text;
            string address = TextBoxSupAdress.Text;
            int postalCode = Int32.Parse(TextBoxSupZipCode.Text);
            string town = TextBoxSupCity.Text;

            // 2 Créer l'objet DTO
            SupplierDTO SupplierResult = new SupplierDTO();
            // 3 Remplir ce nouvel Objet avec les valeurs de Etape 1
            SupplierResult.Name = Name;
            SupplierResult.Email = email;
            SupplierResult.PhoneNumber = phoneNumber;
            SupplierResult.PhysicalAddress = address;
            SupplierResult.PostalCode = postalCode;
            SupplierResult.Town = town;
            // 4 Appeler la web API (route Families et avec Post)  avec cet objet DTO
            //Déclaration du client http
            HttpClient httpClient = new HttpClient();

            //Adresse de l'api 
            httpClient.BaseAddress = new Uri("https://localhost:7049/suppliers");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "suppliers");
            // Sérialiser le DTO
            string JSon = JsonConvert.SerializeObject(SupplierResult);
            request.Content = new StringContent(JSon);
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //Envoi de la requête 
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(request);
            // vérifie que le retour ne soit pas une erreur
            httpResponseMessage.EnsureSuccessStatusCode();
            //Réponse avec message de la requête
            string response = await httpResponseMessage.Content.ReadAsStringAsync();

            //Affichage de la réponse
            MessageBox.Show("Le nouveau fournisseur a été créé avec succès");
        }

        /// <summary>
        /// Affiche la grille de Fournisseurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonSuppliers_Click_1(object sender, EventArgs e)
        {
            // Envoyer une demande HTTP GET à l'API et récupérer les données sous forme de chaîne JSON
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/suppliers");

            // Convertir la chaîne JSON en un objet dynamic
            dynamic data = JsonConvert.DeserializeObject(json);

            // Créer un objet DataTable et ajouter les colonnes nécessaires
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int)).ReadOnly = true;
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Adresse", typeof(string));
            table.Columns.Add("Code postal", typeof(string));
            table.Columns.Add("Ville", typeof(string));

            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            foreach (dynamic item in data)
            {
                table.Rows.Add(item.id, item.name, item.email, item.phoneNumber, item.physicalAddress, item.postalCode, item.town);
            }
            // Assigner l'objet DataTable comme source de données du contrôle DataGridView
            DataGridViewSuppliersList.DataSource = table;
        }
        /// <summary>
        /// Permet d'effectuer une modification directement dans le dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DataGridViewSuppliersList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= DataGridViewSuppliersList.RowCount)
            {
                //Récupérer la ligne modifiée 
                DataGridViewRow modifiedRow = DataGridViewSuppliersList.Rows[e.RowIndex];

                // Récupérer l'id
                int id = (int)modifiedRow.Cells["ID"].Value;

                // 1 Récupérer les valeurs de la ligne modifiée
                string Name = (string)modifiedRow.Cells["Nom"].Value;
                string email = (string)modifiedRow.Cells["Email"].Value;
                string phoneNumber = (string)modifiedRow.Cells["Telephone"].Value;
                string address = (string)modifiedRow.Cells["Adresse"].Value;
                int postalCode = Convert.ToInt32(modifiedRow.Cells["Code postal"].Value);
                string town = (string)modifiedRow.Cells["Ville"].Value;

                // 2 Créer l'objet DTO
                SupplierDTO SupplierResult = new SupplierDTO();

                // 3 Remplir ce nouvel Objet avec les valeurs de Etape 1
                SupplierResult.Id = id;
                SupplierResult.Name = Name;
                SupplierResult.Email = email;
                SupplierResult.PhoneNumber = phoneNumber;
                SupplierResult.PhysicalAddress = address;
                SupplierResult.PostalCode = postalCode;
                SupplierResult.Town = town;
                // 4 Appeler la web API (route Customers et avec Put)  avec cet objet DTO
                //Déclaration du client http
                HttpClient httpClient = new HttpClient();

                //Adresse de l'api 
                httpClient.BaseAddress = new Uri("https://localhost:7049/suppliers");
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, "suppliers");
                // Sérialiser le DTO
                string JSon = JsonConvert.SerializeObject(SupplierResult);
                request.Content = new StringContent(JSon, Encoding.UTF8, "application/json");
                request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                //Envoi de la requête 
                HttpResponseMessage httpResponseMessage = await httpClient.PutAsync($"https://localhost:7049/suppliers/{id}", request.Content);
                // vérifie que le retour ne soit pas une erreur
                httpResponseMessage.EnsureSuccessStatusCode();
                //Réponse avec message de la requête
                string response = await httpResponseMessage.Content.ReadAsStringAsync();
                //Affichage de la réponse
                MessageBox.Show("Le fournisseur a été modifé avec succès");
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private async void ButtonDeleteSupplier_Click(object sender, EventArgs e)
        {
            //Récupérez la valeur à supprimer
            int id = (int)((DataRowView)DataGridViewSuppliersList.SelectedRows[0].DataBoundItem)["ID"];

            // Envoyez une demande HTTP DELETE à l'API en incluant l'id de la famille à supprimer
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7049/suppliers/{id}");

            if (response.IsSuccessStatusCode)
            {
                //Affichage de la réponse
                MessageBox.Show("Le fournisseur selectionné a été supprimé avec succès");
            }
        }

        #region Redirection Button

        private void ButtonHomePage_Click_1(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void ButtonItems_Click(object sender, EventArgs e)
        {
            FormItems formItems = new FormItems();
            formItems.Show();
            this.Hide();
        }
        private void ButtonFamilies_Click(object sender, EventArgs e)
        {
            FormFamilies formFamilies = new FormFamilies();
            formFamilies.Show();
            this.Hide();
        }
       
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
            this.Hide();
        }
       
        private void BtnSupOrders_Click(object sender, EventArgs e)
        {
            FormCommandSupplier formCommandSupplier = new FormCommandSupplier();
            formCommandSupplier.Show();
            this.Hide();
        }
        
        private void BtnCustOrders_Click(object sender, EventArgs e)
        {
            FormCommandCustomer formCommandCustomer = new FormCommandCustomer();
            formCommandCustomer.Show();
            this.Hide();
        }
        
        private void BtnRegularisation_Click(object sender, EventArgs e)
        {
            FormRegularization formRegularization = new FormRegularization();
            formRegularization.Show();
            this.Hide();
        }
       
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            FormInventory formInventory = new FormInventory();
            formInventory.Show();
            this.Hide();
        }


        #endregion

    }
}

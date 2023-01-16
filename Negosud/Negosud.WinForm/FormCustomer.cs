using Negosud.webapi.Models;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Text;

namespace Negosud.WinForm
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Crée un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAddNewCustomer_Click(object sender, EventArgs e)
        {
            // 1 Récupérer les valeurs de(s) textBox
            string lastName = TextBoxCustName.Text;
            string firstName = TextBoxCustFirstName.Text;
            string email = TextBoxCustEmail.Text;
            string phoneNumber = TextBoxCustPhoneNumber.Text;
            string address = TextBoxCustAdress.Text;
            int postalCode = Int32.Parse(TextBoxCustZipCode.Text);
            string town = TextBoxCustCity.Text;

            // 2 Créer l'objet DTO
            CustomerDTO CustomerResult = new CustomerDTO();
            // 3 Remplir ce nouvel Objet avec les valeurs de Etape 1
            CustomerResult.LastName = lastName;
            CustomerResult.FirstName = firstName;
            CustomerResult.Email = email;
            CustomerResult.PhoneNumber = phoneNumber;
            CustomerResult.PhysicalAddress = address;
            CustomerResult.PostalCode = postalCode;
            CustomerResult.Town = town;
            // 4 Appeler la web API (route Families et avec Post)  avec cet objet DTO
            //Déclaration du client http
            HttpClient httpClient = new HttpClient();

            //Adresse de l'api 
            httpClient.BaseAddress = new Uri("https://localhost:7049/customers");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "customers");
            // Sérialiser le DTO
            string JSon = JsonConvert.SerializeObject(CustomerResult);
            request.Content = new StringContent(JSon);
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //Envoi de la requête 
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(request);
            // vérifie que le retour ne soit pas une erreur
            httpResponseMessage.EnsureSuccessStatusCode();
            //Réponse avec message de la requête
            string response = await httpResponseMessage.Content.ReadAsStringAsync();

            //Affichage de la réponse
            MessageBox.Show("Le nouveau client a été créé avec succès");

        }
        #region Redirection Button
        private void ButtonHomePage_Click(object sender, EventArgs e)
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

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            FormSupplier formSupplier = new FormSupplier(); 
            formSupplier.Show();
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
        /// <summary>
        /// Affiche la grille de clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonCustomers_Click(object sender, EventArgs e)
        {
            // Envoyer une demande HTTP GET à l'API et récupérer les données sous forme de chaîne JSON
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/customers");

            // Convertir la chaîne JSON en un objet dynamic
            dynamic data = JsonConvert.DeserializeObject(json);

            // Créer un objet DataTable et ajouter les colonnes nécessaires
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int)).ReadOnly = true;
            table.Columns.Add("Nom", typeof(string));
            table.Columns.Add("Prenom", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Adresse", typeof(string));
            table.Columns.Add("Code postal", typeof(string));
            table.Columns.Add("Ville", typeof(string));


            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            foreach (dynamic item in data)
            {
                table.Rows.Add(item.id, item.lastName, item.firstName, item.email, item.phoneNumber, item.address, item.postalCode, item.town);
            }
            // Assigner l'objet DataTable comme source de données du contrôle DataGridView
            DataGridViewCustomer.DataSource = table;

        }
        /// <summary>
        /// Permet d'effectuer une modification directement dans le dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier que la cellule modifiée est dans la première colonne (la colonne "ID")
            if (e.ColumnIndex != 0)
            {
                // Récupérer la valeur modifiée
                int id = (int)DataGridViewCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Envoyer une demande HTTP PUT à l'API en incluant les données modifiées en tant que corps de la requête
                HttpClient client = new HttpClient();

                //HttpResponseMessage response = await client.PutAsync("https://localhost:7049/customers/{id}", new StringContent(JsonConvert.SerializeObject(DataRow), Encoding.UTF8, "application/json"));

                //// Si la modification a réussi, mettre à jour la source de données en local
                //if (response.IsSuccessStatusCode)
                //{

                //}
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Récupérez la valeur à supprimer
            int id = (int)((DataRowView)DataGridViewCustomer.SelectedRows[0].DataBoundItem)["ID"];

            // Envoyez une demande HTTP DELETE à l'API en incluant l'id de la famille à supprimer
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7049/customers/{id}");

            if (response.IsSuccessStatusCode)
            {
                //Affichage de la réponse
                MessageBox.Show("Le client selectionné a été supprimée avec succès");
            }
        }

    }
}

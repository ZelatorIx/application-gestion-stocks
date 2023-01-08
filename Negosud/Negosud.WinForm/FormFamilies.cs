using Negosud.webapi.Models;
using Newtonsoft.Json;
using System.Data;

namespace Negosud.WinForm
{
    public partial class FormFamilies : Form
    {
        public FormFamilies()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAddNewFamily_Click(object sender, EventArgs e)
        {
            // 1 Récupérer les valeurs de(s) textBox
            string Name = TextBoxFamilyName.Text;
            // 2 Créer l'objet DTO
            FamilyDTO FamilyResult = new FamilyDTO();
            // 3 Remplir ce nouvel Objet avec les valeurs de Etape 1
            FamilyResult.Name = Name;
            // 4 Appeler la web API (route Families et avec Post)  avec cet objet DTO
            //Déclaration du client http
            HttpClient httpClient = new HttpClient();

            //Adresse de l'api 
            httpClient.BaseAddress = new Uri("https://localhost:7049/families");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "families");
            // Sérialiser le DTO
            string JSon = JsonConvert.SerializeObject(FamilyResult);
            request.Content = new StringContent(JSon);
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //Envoi de la requête 
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(request);
            // vérifie que le retour ne soit pas une erreur
            httpResponseMessage.EnsureSuccessStatusCode();
            //Réponse avec message de la requête
            string response = await httpResponseMessage.Content.ReadAsStringAsync();

            //Affichage de la réponse
            MessageBox.Show("La nouvelle famille a été crée avec succès");
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

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonFamilies_Click(object sender, EventArgs e)
        {
            // Envoyer une demande HTTP GET à l'API et récupérer les données sous forme de chaîne JSON
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/families");

            // Convertir la chaîne JSON en un objet dynamic
            dynamic data = JsonConvert.DeserializeObject(json);

            // Créer un objet DataTable et ajouter les colonnes nécessaires
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int)).ReadOnly = true;
            table.Columns.Add("Nom", typeof(string));

            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            foreach (dynamic item in data)
            {
                table.Rows.Add(item.id, item.name);
            }
            // Assigner l'objet DataTable comme source de données du contrôle DataGridView
            DataGridViewFamilyList.DataSource = table;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void DataGridViewFamilyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier que la cellule modifiée est dans la première colonne (la colonne "ID")
            if (e.ColumnIndex == 0)
            {
                // Récupérer l'id
                int id = (int)DataGridViewFamilyList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                //Récupérer la valeur Name à modifier
                string name = (string)DataGridViewFamilyList.Rows[e.RowIndex].Cells[1].Value;

                // Envoyer une demande HTTP PUT à l'API en incluant les données modifiées en tant que corps de la requête
                HttpClient client = new HttpClient();
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("ID", id.ToString()),
                    new KeyValuePair<string, string>("Nom", name)
                });

                HttpResponseMessage response = await client.PutAsync("https://localhost:7049/families", content);

                //// Si la modification a réussi, mettre à jour la source de données en local
                if (response.IsSuccessStatusCode)
                {
                    //Affichage de la réponse
                    MessageBox.Show("La famille a été modifiée avec succès");

                } else
                {
                    MessageBox.Show(response.StatusCode.ToString());
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            //Récupérez la valeur à supprimer
            int id = (int)((DataRowView)DataGridViewFamilyList.SelectedRows[0].DataBoundItem)["ID"];

            // Envoyez une demande HTTP DELETE à l'API en incluant l'id de la famille à supprimer
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.DeleteAsync($"https://localhost:7049/families/{id}");

            if (response.IsSuccessStatusCode)
            {
                //Affichage de la réponse
                MessageBox.Show("La famille selectionnée a été supprimée avec succès");
            }
        }
    }
}
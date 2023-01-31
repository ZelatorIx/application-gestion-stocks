using Negosud.webapi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud.WinForm
{
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
            InitializeComboboxFamily();
            //ComboBoxItemFamily.DataSource = ItemFamily;
            //ComboBoxItemFamily.DisplayMember = "Name";
            //ComboBoxItemFamily.ValueMember = "Id";
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


        public FamilyDTO? ItemFamily { get; set; }

        private async void BtnNouveau_Click(object sender, EventArgs e)
        {
            try
            {
                //Déclaration du client http
                HttpClient client = new HttpClient();

                //Envoyer le nouvel ObjetDTO à l'API
                // 1 Récupérer les valeurs des Textboxs
                string Name = TextBoxItemName.Text;
                string Description = TextBoxDescription.Text;
                //string Family = ComboBoxItemFamily.Text;
                string? comboBoxFamilyId = ComboBoxItemFamily.SelectedValue.ToString();
                if (comboBoxFamilyId == null)
                {
                    MessageBox.Show("Sélectionnez une famille");
                    return;
                }

                int selectedFamilyId = int.Parse(comboBoxFamilyId);
                string json = await client.GetStringAsync($"https://localhost:7049/families/{selectedFamilyId}");
                FamilyDTO? selectedFamily = JsonConvert.DeserializeObject<FamilyDTO>(json);
                if (selectedFamily == null)
                {
                    MessageBox.Show($"Aucune famille \"{ComboBoxItemFamily.Text}\" trouvée");
                    return;
                }

                int Year = int.Parse(TextBoxYear.Text);
                int StockMin = int.Parse(TextBoxStockMin.Text);
                float PurchasePriceBT = float.Parse(TextBoxPurchasePriceBT.Text);
                float VAT = float.Parse(TextBoxVAT.Text);
                float SellingPriceBT = float.Parse(TextBoxSellingPriceBT.Text);

                // 2 Créer l'objet DTO
                ItemDTO itemResult = new ItemDTO();
                // 3 Remplir ce nouovel Objet avec les valeurs de Etape 1
                itemResult.Name = Name; 
                itemResult.Description = Description;
                itemResult.Family = selectedFamily;

                itemResult.YearItem = Year;
                itemResult.MinLimit = StockMin;
                itemResult.PurchasePriceBT = PurchasePriceBT;
                itemResult.Vat = VAT;
                itemResult.SellingPriceBT = SellingPriceBT;

                // 4 Appeler la web API (route Item et avec Post)  avec cet objet DTO
                //Adresse de l'api 
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://localhost:7049/items");
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "items");
                    // Sérialiser le DTO
                    string JSon = JsonConvert.SerializeObject(itemResult);
                    request.Content = new StringContent(JSon);
                    request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    //Envoi de la requête 
                    HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(request);
                    // vérifie que le retour ne soit pas une erreur
                    httpResponseMessage.EnsureSuccessStatusCode();
                    //Affichage de la réponse
                    if (httpResponseMessage.IsSuccessStatusCode) 
                    {
                        MessageBox.Show("Le nouvel article a été crée avec succès");
                    } else
                    {
                        MessageBox.Show("Une erreur s'est produite, vérifiez d'avoir rempli tous les champs correctement.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonItems_Click(object sender, EventArgs e)
        {
            try
            {

                // Envoyer une demande HTTP GET à l'API et récupérer les données sous forme de chaîne JSON
                HttpClient client = new HttpClient();
                string json = await client.GetStringAsync("https://localhost:7049/items");

                // Convertir la chaîne JSON en un objet dynamic
                List<ItemDTO>? items = JsonConvert.DeserializeObject<List<ItemDTO>>(json);

                // Créer un objet DataTable et ajouter les colonnes nécessaires
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Nom", typeof(string));
                table.Columns.Add("Description", typeof(string));
                table.Columns.Add("Prix HT", typeof(float));
                table.Columns.Add("Prix TTC", typeof(float));
                table.Columns.Add("TVA", typeof(float));
                table.Columns.Add("Image", typeof(string));
                table.Columns.Add("Minimum", typeof(int));
                table.Columns.Add("Année", typeof(int));

                // Parcourir la liste d'ItemDTO et ajouter chaque objet en tant que ligne dans l'objet DataTable
                if (items != null)
                {
                    foreach (ItemDTO item in items)
                    {
                        table.Rows.Add(item.Id, item.Name, item.Description, item.PurchasePriceBT, item.SellingPriceBT,
                            item.Vat, item.Picture, item.MinLimit, item.YearItem);
                    }
                }
                // Assigner l'objet DataTable comme source de données du contrôle DataGridView
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void InitializeComboboxFamily()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/families");
            List<FamilyDTO>? families = JsonConvert.DeserializeObject<List<FamilyDTO>>(json);
            // Créer un objet DataTable et ajouter les colonnes nécessaires
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int)).ReadOnly = true;
            table.Columns.Add("Nom", typeof(string));
            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            if (families != null)
            {
                foreach (FamilyDTO family in families)
                {
                    table.Rows.Add(family.Id, family.Name);
                }
            }
            // Assigner l'objet DataTable comme source de données de la comboBox
            ComboBoxItemFamily.DataSource = table;
            ComboBoxItemFamily.ValueMember = "Id";
            ComboBoxItemFamily.DisplayMember = "Nom";
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.ComboBoxItemFamily.SelectedIndexChanged += new EventHandler(ComboBoxItemFamily_SelectedIndexChanged);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBoxItemFamily_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

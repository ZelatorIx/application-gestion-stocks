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
        }

        public FamilyDTO? ItemFamily { get; private set; }

        private async void BtnNouveau_Click(object sender, EventArgs e)
        {
            //Envoyer le nouvel ObjetDTO à l'API
            // 1 Récupérer les valeurs des Textboxs
            string Name = TextBoxItemName.Text;
            string Description = TextBoxDescription.Text;
            //string Family = ComboBoxItemFamily.Text;
            ComboBoxItemFamily.DataSource = new List<FamilyDTO>();  
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
            //itemResult.Family = Family;
            itemResult.YearItem = Year;
            itemResult.MinLimit = StockMin;
            itemResult.PurchasePriceBT = PurchasePriceBT;
            itemResult.Vat = VAT;
            itemResult.SellingPriceBT = SellingPriceBT;

            // 4 Appeler la web API (route Item et avec Post)  avec cet objet DTO
            //Déclaration du client http
            HttpClient httpClient = new HttpClient();

            //Adresse de l'api 
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
                MessageBox.Show("L'article a été crée avec succès");
            }
            
        }

        private async void buttonItems_Click(object sender, EventArgs e)
        {
            // Envoyer une demande HTTP GET à l'API et récupérer les données sous forme de chaîne JSON
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/items");

            // Convertir la chaîne JSON en un objet dynamic
            dynamic data = JsonConvert.DeserializeObject(json);

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

            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            foreach (dynamic item in data)
            {
                table.Rows.Add(item.id, item.name, item.description, item.purchasePriceBT, item.sellingPriceBT, 
                    item.vat, item.picture, item.minLimit, item.yearItem);
            }
            // Assigner l'objet DataTable comme source de données du contrôle DataGridView
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

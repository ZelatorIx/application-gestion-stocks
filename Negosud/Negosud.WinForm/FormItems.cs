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

            // 4 Propriétés pour rendre opérationelle la combo 
            //comboBox1.SelectedItem
            //comboBox1.ValueMember
            //comboBox1.DisplayMember
            //comboBox1.DataSource
            int Family = int.Parse(TextBoxPurchasePriceBT.Text);
            String Description = TextBoxDescription.Text; 
            string Name = TextBoxItemName.Text;
            // 2 Créer l'objet DTO
            ItemDTO itemResult = new ItemDTO();
            // 3 Remplir ce nouovel Objet avec les valeurs de Etape 1
         
            itemResult.Family = ItemFamily; 
            itemResult.Description = Description;   
            itemResult.Name = Name;

            // 4 Appeler la web API (route Item et avec Post)  avec cet objet DTO
            //Déclaration du client http
            HttpClient httpClient = new HttpClient();

            //Adresse de l'api 
            httpClient.BaseAddress = new Uri("https://localhost:7049/");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "items");
            // Sérialiser le DTO
            string JSon = JsonConvert.SerializeObject(itemResult);
            request.Content = new StringContent(JSon);
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            //Envoi de la requête 
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(request);
            // vérifie que le retour ne soit pas une erreur
            httpResponseMessage.EnsureSuccessStatusCode(); 
            //Réponse avec message de la requête
            string response = await httpResponseMessage.Content.ReadAsStringAsync();

            //Affichage de la réponse
            MessageBox.Show(response);
        }
    }
}

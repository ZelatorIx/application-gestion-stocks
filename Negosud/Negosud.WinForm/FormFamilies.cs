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
    public partial class FormFamilies : Form
    {
        public FormFamilies()
        {
            InitializeComponent();
        }

        private async Task ButtonAddNewFamily_ClickAsync(object sender, EventArgs e)
        {
            // But envoyer le nouvel objet DTO à l'API
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
            httpClient.BaseAddress = new Uri("https://localhost:7049/");
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
            MessageBox.Show(response);



        }
    }
}

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

       

     
    }
}

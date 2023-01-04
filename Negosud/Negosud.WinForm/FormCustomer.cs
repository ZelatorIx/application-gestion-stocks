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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

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
            httpClient.BaseAddress = new Uri("https://localhost:7049/");
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
            MessageBox.Show(response);

        }

        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
        }

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
    }
}

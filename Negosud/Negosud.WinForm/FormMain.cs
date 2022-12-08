using Negosud.dataaccess.Tables;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace Negosud.WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void buttonTestApi_click(object sender, EventArgs e)
        {
            //D�claration du client http
            HttpClient httpClient = new HttpClient();

            //Adresse de l'api 
            httpClient.BaseAddress = new Uri("https://localhost:7049/");
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "families");

            //Envoi de la requ�te 
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(request);

            //R�ponse avec message de la requ�te
            string response = await httpResponseMessage.Content.ReadAsStringAsync();

            //Affichage de la r�ponse
            MessageBox.Show(response);

            List<FamilyDTO> responseDeserialize = JsonConvert.DeserializeObject<List<FamilyDTO>>(response);

            dataGrid.DataSource = responseDeserialize;

        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            FormItems  formItems = new FormItems();
            formItems.ShowDialog();   
        }
    }
}
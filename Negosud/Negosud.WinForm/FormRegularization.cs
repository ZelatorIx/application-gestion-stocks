using Microsoft.EntityFrameworkCore.Infrastructure;
using Negosud.webapi.Models;
using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Text;

namespace Negosud.WinForm
{
    public partial class FormRegularization : Form
    {
        public FormRegularization()
        {
            InitializeComponent();
            InitializeReasonRegulComboBox();
        }

        private async void InitializeReasonRegulComboBox()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/reasons-regularization");

            dynamic data = JsonConvert.DeserializeObject(json);

            reasonRegulComboBox.Items.Add("Toto");
            if (data != null )
            {
                foreach (dynamic regul in data)
                {
                    reasonRegulComboBox.Items.Insert(regul.id, regul.title);
                }
            }
        }

        private async void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/items");

            dynamic data = JsonConvert.DeserializeObject(json);

            comboBoxItems.Items.Add("Toto");
            if (data != null)
            {
                foreach (dynamic item in data)
                {
                    comboBoxItems.Items.Insert(item.id, item.title);
                }
            }
        }

        private async void ReasonRegularizationComboxBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/reasons-regularization");

            dynamic data = JsonConvert.DeserializeObject(json);
            DataTable reguls = new DataTable();
            ReasonRegularizationDTO reasons = data;

            reasonRegulComboBox.Items.Add("Toto");
            foreach (dynamic regul in json)
            {
                reasonRegulComboBox.Items.Insert(regul.Id, regul.Title);
            }
        }

    }
}

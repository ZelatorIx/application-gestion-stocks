using Microsoft.EntityFrameworkCore.Infrastructure;
using Negosud.webapi.Models;
using Newtonsoft.Json;
using System.Data;
using System.Drawing.Imaging;
using System.Net;
using System.Text;
using static System.Net.WebRequestMethods;

namespace Negosud.WinForm
{
    public partial class FormRegularization : Form
    {
        public FormRegularization()
        {
            InitializeComponent();
            //InitializeComboboxReasonRegul();
            InitializeComboBoxItems();

        }

        private async void InitializeComboboxReasonRegul()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/reasons-regularization");

            dynamic data = JsonConvert.DeserializeObject(json);

            ComboBoxReasonRegul.Items.Add("Motif");
            if (data != null )
            {
                foreach (dynamic regul in data)
                {
                    ComboBoxReasonRegul.Items.Insert(regul.id, regul.title);
                }
            }
        }

        private async void InitializeComboBoxItems()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/items");

            dynamic data = JsonConvert.DeserializeObject(json);

            // Créer un objet DataTable et ajouter les colonnes nécessaires
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int)).ReadOnly = true;
            table.Columns.Add("Nom", typeof(string));

            //ComboBoxItems.Items.Add("Article");
            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            if (data != null)
            {
                foreach (dynamic item in data)
                {
                    table.Rows.Add(item.id, item.name);
                }
            }
            // Assigner l'objet DataTable comme source de données de la comboBox
            ComboBoxItems.DataSource = table;
            ComboBoxItems.ValueMember = "Id";
            ComboBoxItems.DisplayMember= "Nom";
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.ComboBoxItems.SelectedIndexChanged +=
                new System.EventHandler(comboBoxItems_SelectedIndexChanged); 
            //foreach (dynamic item in data)
            //{
            //    ComboBoxItems.Items.Insert(item.id, item.title);
            //}

        }

        private async void ComboxBoxReasonRegularization_CellContextClick(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/reasons-regularization");

            dynamic data = JsonConvert.DeserializeObject(json);
            DataTable reguls = new DataTable();
            ReasonRegularizationDTO reasons = data;

            ComboBoxReasonRegul.Items.Add("Toto");
            foreach (dynamic regul in json)
            {
                ComboBoxReasonRegul.Items.Insert(regul.Id, regul.Title);
            }
        }

        //private async void ComboxBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    HttpClient client = new HttpClient();
        //    string json = await client.GetStringAsync("https://localhost:7049/items");

        //    dynamic data = JsonConvert.DeserializeObject(json);
        //    DataTable reguls = new DataTable();
        //    ReasonRegularizationDTO reasons = data;

        //    ComboBoxReasonRegul.Items.Add("Toto");
        //    foreach (dynamic regul in json)
        //    {
        //        ComboBoxReasonRegul.Items.Insert(regul.Id, regul.Title);
        //    }
        //}
    }
}

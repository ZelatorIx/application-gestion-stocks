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
            InitializeComboboxReasonRegul();
            InitializeComboBoxItems();

        }

        private async void InitializeComboboxReasonRegul()
        {
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync("https://localhost:7049/reasons-regularization");
            dynamic data = JsonConvert.DeserializeObject(json);
            // Créer un objet DataTable et ajouter les colonnes nécessaires
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int)).ReadOnly = true;
            table.Columns.Add("Nom", typeof(string));
            // Parcourir l'objet dynamic et ajouter chaque objet en tant que ligne dans l'objet DataTable
            if (data != null )
            {
                foreach (dynamic reason in data)
                {
                    table.Rows.Add(reason.id, reason.title);
                }
            }
            // Assigner l'objet DataTable comme source de données de la comboBox
            ComboBoxReasonRegul.DataSource = table;
            ComboBoxReasonRegul.ValueMember = "Id";
            ComboBoxReasonRegul.DisplayMember = "Nom";
            // Associate the event-handling method with the 
            // SelectedIndexChanged event.
            this.ComboBoxItems.SelectedIndexChanged +=
                new System.EventHandler(ReasonRegularizationComboxBox_SelectedIndexChanged);
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
        }

        private async void ComboxBoxReasonRegularization_CellContextClick(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            //string json = await client.GetStringAsync("https://localhost:7049/reasons-regularization");

            //dynamic data = JsonConvert.DeserializeObject(json);
            //DataTable reguls = new DataTable();
            //ReasonRegularizationDTO reasons = data;

            //ComboBoxReasonRegul.Items.Add("Toto");
            //foreach (dynamic regul in json)
            //{
            //    ComboBoxReasonRegul.Items.Insert(regul.Id, regul.Title);
            //}
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

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            FormInventory formInventory = new FormInventory();
            formInventory.Show();
            this.Hide();
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

namespace Negosud.WinForm
{
    partial class FormCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnRegularisation = new System.Windows.Forms.Button();
            this.BtnCustOrders = new System.Windows.Forms.Button();
            this.BtnSupOrders = new System.Windows.Forms.Button();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.TextBoxStocks = new System.Windows.Forms.TextBox();
            this.TextBoxSellings = new System.Windows.Forms.TextBox();
            this.TextBoxPurchases = new System.Windows.Forms.TextBox();
            this.TextBoxCustName = new System.Windows.Forms.TextBox();
            this.TextBoxCustFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxCustPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxCustEmail = new System.Windows.Forms.TextBox();
            this.TextBoxCustAdress = new System.Windows.Forms.TextBox();
            this.TextBoxCustZipCode = new System.Windows.Forms.TextBox();
            this.TextBoxCustCity = new System.Windows.Forms.TextBox();
            this.LabelCustName = new System.Windows.Forms.Label();
            this.LabelCustFirstname = new System.Windows.Forms.Label();
            this.LabelCustEmail = new System.Windows.Forms.Label();
            this.LabelCustPhoneNumer = new System.Windows.Forms.Label();
            this.LabelCustAdress = new System.Windows.Forms.Label();
            this.LabelCustZipCode = new System.Windows.Forms.Label();
            this.LabelCustCity = new System.Windows.Forms.Label();
            this.TextBoxMapSellings = new System.Windows.Forms.TextBox();
            this.TextBoxMapCustumers = new System.Windows.Forms.TextBox();
            this.ScrollBarCustomers = new System.Windows.Forms.VScrollBar();
            this.ButtonFamilies = new System.Windows.Forms.Button();
            this.ButtonItems = new System.Windows.Forms.Button();
            this.TextBoxProducts = new System.Windows.Forms.TextBox();
            this.ButtonAddNewCustomer = new System.Windows.Forms.Button();
            this.ButtonDeleteCustomer = new System.Windows.Forms.Button();
            this.ButtonHomePage = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.DataGridViewCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(22, 415);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(90, 23);
            this.BtnInventory.TabIndex = 19;
            this.BtnInventory.Text = "Inventaire";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnRegularisation
            // 
            this.BtnRegularisation.Location = new System.Drawing.Point(22, 385);
            this.BtnRegularisation.Name = "BtnRegularisation";
            this.BtnRegularisation.Size = new System.Drawing.Size(90, 23);
            this.BtnRegularisation.TabIndex = 18;
            this.BtnRegularisation.Text = "Régularisation";
            this.BtnRegularisation.UseVisualStyleBackColor = true;
            this.BtnRegularisation.Click += new System.EventHandler(this.BtnRegularisation_Click);
            // 
            // BtnCustOrders
            // 
            this.BtnCustOrders.Location = new System.Drawing.Point(22, 325);
            this.BtnCustOrders.Name = "BtnCustOrders";
            this.BtnCustOrders.Size = new System.Drawing.Size(90, 23);
            this.BtnCustOrders.TabIndex = 17;
            this.BtnCustOrders.Text = "Commandes";
            this.BtnCustOrders.UseVisualStyleBackColor = true;
            this.BtnCustOrders.Click += new System.EventHandler(this.BtnCustOrders_Click);
            // 
            // BtnSupOrders
            // 
            this.BtnSupOrders.Location = new System.Drawing.Point(22, 235);
            this.BtnSupOrders.Name = "BtnSupOrders";
            this.BtnSupOrders.Size = new System.Drawing.Size(90, 23);
            this.BtnSupOrders.TabIndex = 15;
            this.BtnSupOrders.Text = "Commandes";
            this.BtnSupOrders.UseVisualStyleBackColor = true;
            this.BtnSupOrders.Click += new System.EventHandler(this.BtnSupOrders_Click);
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Location = new System.Drawing.Point(22, 205);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(90, 23);
            this.BtnSuppliers.TabIndex = 14;
            this.BtnSuppliers.Text = "Fournisseurs";
            this.BtnSuppliers.UseVisualStyleBackColor = true;
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // TextBoxStocks
            // 
            this.TextBoxStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxStocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxStocks.Location = new System.Drawing.Point(12, 360);
            this.TextBoxStocks.Name = "TextBoxStocks";
            this.TextBoxStocks.Size = new System.Drawing.Size(100, 22);
            this.TextBoxStocks.TabIndex = 13;
            this.TextBoxStocks.Text = "STOCKS";
            // 
            // TextBoxSellings
            // 
            this.TextBoxSellings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSellings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSellings.Location = new System.Drawing.Point(12, 270);
            this.TextBoxSellings.Name = "TextBoxSellings";
            this.TextBoxSellings.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSellings.TabIndex = 12;
            this.TextBoxSellings.Text = "VENTES";
            // 
            // TextBoxPurchases
            // 
            this.TextBoxPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPurchases.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPurchases.Location = new System.Drawing.Point(12, 180);
            this.TextBoxPurchases.Name = "TextBoxPurchases";
            this.TextBoxPurchases.Size = new System.Drawing.Size(100, 22);
            this.TextBoxPurchases.TabIndex = 11;
            this.TextBoxPurchases.Text = "ACHATS";
            // 
            // TextBoxCustName
            // 
            this.TextBoxCustName.Location = new System.Drawing.Point(165, 79);
            this.TextBoxCustName.Name = "TextBoxCustName";
            this.TextBoxCustName.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustName.TabIndex = 21;
            // 
            // TextBoxCustFirstName
            // 
            this.TextBoxCustFirstName.Location = new System.Drawing.Point(165, 118);
            this.TextBoxCustFirstName.Name = "TextBoxCustFirstName";
            this.TextBoxCustFirstName.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustFirstName.TabIndex = 22;
            // 
            // TextBoxCustPhoneNumber
            // 
            this.TextBoxCustPhoneNumber.Location = new System.Drawing.Point(165, 196);
            this.TextBoxCustPhoneNumber.Name = "TextBoxCustPhoneNumber";
            this.TextBoxCustPhoneNumber.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustPhoneNumber.TabIndex = 24;
            // 
            // TextBoxCustEmail
            // 
            this.TextBoxCustEmail.Location = new System.Drawing.Point(165, 157);
            this.TextBoxCustEmail.Name = "TextBoxCustEmail";
            this.TextBoxCustEmail.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustEmail.TabIndex = 23;
            // 
            // TextBoxCustAdress
            // 
            this.TextBoxCustAdress.Location = new System.Drawing.Point(472, 79);
            this.TextBoxCustAdress.Name = "TextBoxCustAdress";
            this.TextBoxCustAdress.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustAdress.TabIndex = 25;
            // 
            // TextBoxCustZipCode
            // 
            this.TextBoxCustZipCode.Location = new System.Drawing.Point(472, 118);
            this.TextBoxCustZipCode.Name = "TextBoxCustZipCode";
            this.TextBoxCustZipCode.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustZipCode.TabIndex = 26;
            // 
            // TextBoxCustCity
            // 
            this.TextBoxCustCity.Location = new System.Drawing.Point(472, 157);
            this.TextBoxCustCity.Name = "TextBoxCustCity";
            this.TextBoxCustCity.Size = new System.Drawing.Size(259, 23);
            this.TextBoxCustCity.TabIndex = 27;
            // 
            // LabelCustName
            // 
            this.LabelCustName.AutoSize = true;
            this.LabelCustName.Location = new System.Drawing.Point(165, 63);
            this.LabelCustName.Name = "LabelCustName";
            this.LabelCustName.Size = new System.Drawing.Size(34, 15);
            this.LabelCustName.TabIndex = 28;
            this.LabelCustName.Text = "Nom";
            // 
            // LabelCustFirstname
            // 
            this.LabelCustFirstname.AutoSize = true;
            this.LabelCustFirstname.Location = new System.Drawing.Point(165, 103);
            this.LabelCustFirstname.Name = "LabelCustFirstname";
            this.LabelCustFirstname.Size = new System.Drawing.Size(49, 15);
            this.LabelCustFirstname.TabIndex = 29;
            this.LabelCustFirstname.Text = "Prénom";
            // 
            // LabelCustEmail
            // 
            this.LabelCustEmail.AutoSize = true;
            this.LabelCustEmail.Location = new System.Drawing.Point(165, 142);
            this.LabelCustEmail.Name = "LabelCustEmail";
            this.LabelCustEmail.Size = new System.Drawing.Size(41, 15);
            this.LabelCustEmail.TabIndex = 30;
            this.LabelCustEmail.Text = "e-mail";
            // 
            // LabelCustPhoneNumer
            // 
            this.LabelCustPhoneNumer.AutoSize = true;
            this.LabelCustPhoneNumer.Location = new System.Drawing.Point(165, 182);
            this.LabelCustPhoneNumer.Name = "LabelCustPhoneNumer";
            this.LabelCustPhoneNumer.Size = new System.Drawing.Size(37, 15);
            this.LabelCustPhoneNumer.TabIndex = 31;
            this.LabelCustPhoneNumer.Text = "N° tél";
            // 
            // LabelCustAdress
            // 
            this.LabelCustAdress.AutoSize = true;
            this.LabelCustAdress.Location = new System.Drawing.Point(472, 63);
            this.LabelCustAdress.Name = "LabelCustAdress";
            this.LabelCustAdress.Size = new System.Drawing.Size(48, 15);
            this.LabelCustAdress.TabIndex = 32;
            this.LabelCustAdress.Text = "Adresse";
            // 
            // LabelCustZipCode
            // 
            this.LabelCustZipCode.AutoSize = true;
            this.LabelCustZipCode.Location = new System.Drawing.Point(472, 103);
            this.LabelCustZipCode.Name = "LabelCustZipCode";
            this.LabelCustZipCode.Size = new System.Drawing.Size(70, 15);
            this.LabelCustZipCode.TabIndex = 33;
            this.LabelCustZipCode.Text = "Code Postal";
            // 
            // LabelCustCity
            // 
            this.LabelCustCity.AutoSize = true;
            this.LabelCustCity.Location = new System.Drawing.Point(472, 142);
            this.LabelCustCity.Name = "LabelCustCity";
            this.LabelCustCity.Size = new System.Drawing.Size(29, 15);
            this.LabelCustCity.TabIndex = 34;
            this.LabelCustCity.Text = "Ville";
            // 
            // TextBoxMapSellings
            // 
            this.TextBoxMapSellings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapSellings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapSellings.Location = new System.Drawing.Point(152, 12);
            this.TextBoxMapSellings.Name = "TextBoxMapSellings";
            this.TextBoxMapSellings.Size = new System.Drawing.Size(100, 22);
            this.TextBoxMapSellings.TabIndex = 35;
            this.TextBoxMapSellings.Text = "VENTES";
            // 
            // TextBoxMapCustumers
            // 
            this.TextBoxMapCustumers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapCustumers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapCustumers.ForeColor = System.Drawing.Color.SeaGreen;
            this.TextBoxMapCustumers.Location = new System.Drawing.Point(300, 6);
            this.TextBoxMapCustumers.Name = "TextBoxMapCustumers";
            this.TextBoxMapCustumers.Size = new System.Drawing.Size(100, 28);
            this.TextBoxMapCustumers.TabIndex = 36;
            this.TextBoxMapCustumers.Text = "CLIENTS";
            // 
            // ScrollBarCustomers
            // 
            this.ScrollBarCustomers.Location = new System.Drawing.Point(774, 226);
            this.ScrollBarCustomers.Name = "ScrollBarCustomers";
            this.ScrollBarCustomers.Size = new System.Drawing.Size(22, 222);
            this.ScrollBarCustomers.TabIndex = 37;
            // 
            // ButtonFamilies
            // 
            this.ButtonFamilies.Location = new System.Drawing.Point(22, 145);
            this.ButtonFamilies.Name = "ButtonFamilies";
            this.ButtonFamilies.Size = new System.Drawing.Size(90, 23);
            this.ButtonFamilies.TabIndex = 40;
            this.ButtonFamilies.Text = "Familles";
            this.ButtonFamilies.UseVisualStyleBackColor = true;
            this.ButtonFamilies.Click += new System.EventHandler(this.ButtonFamilies_Click);
            // 
            // ButtonItems
            // 
            this.ButtonItems.Location = new System.Drawing.Point(22, 115);
            this.ButtonItems.Name = "ButtonItems";
            this.ButtonItems.Size = new System.Drawing.Size(90, 23);
            this.ButtonItems.TabIndex = 39;
            this.ButtonItems.Text = "Articles";
            this.ButtonItems.UseVisualStyleBackColor = true;
            this.ButtonItems.Click += new System.EventHandler(this.ButtonItems_Click);
            // 
            // TextBoxProducts
            // 
            this.TextBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxProducts.Location = new System.Drawing.Point(12, 90);
            this.TextBoxProducts.Name = "TextBoxProducts";
            this.TextBoxProducts.Size = new System.Drawing.Size(100, 22);
            this.TextBoxProducts.TabIndex = 38;
            this.TextBoxProducts.Text = "PRODUITS";
            // 
            // ButtonAddNewCustomer
            // 
            this.ButtonAddNewCustomer.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonAddNewCustomer.Location = new System.Drawing.Point(471, 196);
            this.ButtonAddNewCustomer.Name = "ButtonAddNewCustomer";
            this.ButtonAddNewCustomer.Size = new System.Drawing.Size(71, 23);
            this.ButtonAddNewCustomer.TabIndex = 41;
            this.ButtonAddNewCustomer.Text = "Créer";
            this.ButtonAddNewCustomer.UseVisualStyleBackColor = false;
            this.ButtonAddNewCustomer.Click += new System.EventHandler(this.ButtonAddNewCustomer_Click);
            // 
            // ButtonDeleteCustomer
            // 
            this.ButtonDeleteCustomer.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonDeleteCustomer.Location = new System.Drawing.Point(548, 196);
            this.ButtonDeleteCustomer.Name = "ButtonDeleteCustomer";
            this.ButtonDeleteCustomer.Size = new System.Drawing.Size(71, 23);
            this.ButtonDeleteCustomer.TabIndex = 43;
            this.ButtonDeleteCustomer.Text = "Supprimer";
            this.ButtonDeleteCustomer.UseVisualStyleBackColor = false;
            this.ButtonDeleteCustomer.Click += new System.EventHandler(this.ButtonDeleteCustomer_Click);
            // 
            // ButtonHomePage
            // 
            this.ButtonHomePage.Location = new System.Drawing.Point(22, 61);
            this.ButtonHomePage.Name = "ButtonHomePage";
            this.ButtonHomePage.Size = new System.Drawing.Size(90, 23);
            this.ButtonHomePage.TabIndex = 44;
            this.ButtonHomePage.Text = "Accueil";
            this.ButtonHomePage.UseVisualStyleBackColor = true;
            this.ButtonHomePage.Click += new System.EventHandler(this.ButtonHomePage_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Location = new System.Drawing.Point(677, 195);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(98, 23);
            this.buttonCustomers.TabIndex = 45;
            this.buttonCustomers.Text = "Clients";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // DataGridViewCustomer
            // 
            this.DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCustomer.Location = new System.Drawing.Point(165, 226);
            this.DataGridViewCustomer.Name = "DataGridViewCustomer";
            this.DataGridViewCustomer.RowTemplate.Height = 25;
            this.DataGridViewCustomer.Size = new System.Drawing.Size(610, 222);
            this.DataGridViewCustomer.TabIndex = 46;
            this.DataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCustomer_CellContentClick);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 493);
            this.Controls.Add(this.DataGridViewCustomer);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.ButtonHomePage);
            this.Controls.Add(this.ButtonDeleteCustomer);
            this.Controls.Add(this.ButtonAddNewCustomer);
            this.Controls.Add(this.ButtonFamilies);
            this.Controls.Add(this.ButtonItems);
            this.Controls.Add(this.TextBoxProducts);
            this.Controls.Add(this.ScrollBarCustomers);
            this.Controls.Add(this.TextBoxMapCustumers);
            this.Controls.Add(this.TextBoxMapSellings);
            this.Controls.Add(this.LabelCustCity);
            this.Controls.Add(this.LabelCustZipCode);
            this.Controls.Add(this.LabelCustAdress);
            this.Controls.Add(this.LabelCustPhoneNumer);
            this.Controls.Add(this.LabelCustEmail);
            this.Controls.Add(this.LabelCustFirstname);
            this.Controls.Add(this.LabelCustName);
            this.Controls.Add(this.TextBoxCustCity);
            this.Controls.Add(this.TextBoxCustZipCode);
            this.Controls.Add(this.TextBoxCustAdress);
            this.Controls.Add(this.TextBoxCustPhoneNumber);
            this.Controls.Add(this.TextBoxCustEmail);
            this.Controls.Add(this.TextBoxCustFirstName);
            this.Controls.Add(this.TextBoxCustName);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnRegularisation);
            this.Controls.Add(this.BtnCustOrders);
            this.Controls.Add(this.BtnSupOrders);
            this.Controls.Add(this.BtnSuppliers);
            this.Controls.Add(this.TextBoxStocks);
            this.Controls.Add(this.TextBoxSellings);
            this.Controls.Add(this.TextBoxPurchases);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnInventory;
        private Button BtnRegularisation;
        private Button BtnCustOrders;
        private Button BtnSupOrders;
        private Button BtnSuppliers;
        private TextBox TextBoxStocks;
        private TextBox TextBoxSellings;
        private TextBox TextBoxPurchases;
        private TextBox TextBoxCustName;
        private TextBox TextBoxCustFirstName;
        private TextBox TextBoxCustPhoneNumber;
        private TextBox TextBoxCustEmail;
        private TextBox TextBoxCustAdress;
        private TextBox TextBoxCustZipCode;
        private TextBox TextBoxCustCity;
        private Label LabelCustName;
        private Label LabelCustFirstname;
        private Label LabelCustEmail;
        private Label LabelCustPhoneNumer;
        private Label LabelCustAdress;
        private Label LabelCustZipCode;
        private Label LabelCustCity;
        private TextBox TextBoxMapSellings;
        private TextBox TextBoxMapCustumers;
        private VScrollBar ScrollBarCustomers;
        private Button ButtonFamilies;
        private Button ButtonItems;
        private TextBox TextBoxProducts;
        private Button ButtonAddNewCustomer;
        private Button ButtonDeleteCustomer;
        private Button ButtonHomePage;
        private Button buttonCustomers;
        private DataGridView DataGridViewCustomer;
    }
}
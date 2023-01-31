namespace Negosud.WinForm
{
    partial class FormItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItems));
            this.BtnNew = new System.Windows.Forms.Button();
            this.DataGridViewItemList = new System.Windows.Forms.DataGridView();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxItemName = new System.Windows.Forms.TextBox();
            this.LabelItemName = new System.Windows.Forms.Label();
            this.LabelItemDescription = new System.Windows.Forms.Label();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnRegularization = new System.Windows.Forms.Button();
            this.BtnCustOrders = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnSupOrders = new System.Windows.Forms.Button();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.textBoxStocks = new System.Windows.Forms.TextBox();
            this.textBoxVentes = new System.Windows.Forms.TextBox();
            this.textBoxAchats = new System.Windows.Forms.TextBox();
            this.ButtonFamilies = new System.Windows.Forms.Button();
            this.TextBoxProducts = new System.Windows.Forms.TextBox();
            this.TextBoxMapFamilies = new System.Windows.Forms.TextBox();
            this.TextBoxMapProducts = new System.Windows.Forms.TextBox();
            this.PictureBoxItem = new System.Windows.Forms.PictureBox();
            this.LabelItemYear = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.LabelStockLimit = new System.Windows.Forms.Label();
            this.TextBoxStockMin = new System.Windows.Forms.TextBox();
            this.LabelVAT = new System.Windows.Forms.Label();
            this.TextBoxVAT = new System.Windows.Forms.TextBox();
            this.LabelSellingPriceBT = new System.Windows.Forms.Label();
            this.TextBoxSellingPriceBT = new System.Windows.Forms.TextBox();
            this.LabelPurchasePriceBT = new System.Windows.Forms.Label();
            this.TextBoxPurchasePriceBT = new System.Windows.Forms.TextBox();
            this.LabelItemFamily = new System.Windows.Forms.Label();
            this.ComboBoxItemFamily = new System.Windows.Forms.ComboBox();
            this.ScrollBarListItems = new System.Windows.Forms.VScrollBar();
            this.buttonItems = new System.Windows.Forms.Button();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.ButtonHomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNew
            // 
            this.BtnNew.BackColor = System.Drawing.Color.MistyRose;
            this.BtnNew.Location = new System.Drawing.Point(467, 196);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "Créer";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // DataGridViewItemList
            // 
            this.DataGridViewItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewItemList.Location = new System.Drawing.Point(152, 234);
            this.DataGridViewItemList.Name = "DataGridViewItemList";
            this.DataGridViewItemList.RowTemplate.Height = 25;
            this.DataGridViewItemList.Size = new System.Drawing.Size(625, 211);
            this.DataGridViewItemList.TabIndex = 2;
            this.DataGridViewItemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewItemList_CellContentClick);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(216, 118);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(204, 23);
            this.TextBoxDescription.TabIndex = 5;
            // 
            // TextBoxItemName
            // 
            this.TextBoxItemName.Location = new System.Drawing.Point(216, 76);
            this.TextBoxItemName.Name = "TextBoxItemName";
            this.TextBoxItemName.Size = new System.Drawing.Size(204, 23);
            this.TextBoxItemName.TabIndex = 6;
            // 
            // LabelItemName
            // 
            this.LabelItemName.AutoSize = true;
            this.LabelItemName.Location = new System.Drawing.Point(216, 59);
            this.LabelItemName.Name = "LabelItemName";
            this.LabelItemName.Size = new System.Drawing.Size(34, 15);
            this.LabelItemName.TabIndex = 8;
            this.LabelItemName.Text = "Nom";
            // 
            // LabelItemDescription
            // 
            this.LabelItemDescription.AutoSize = true;
            this.LabelItemDescription.Location = new System.Drawing.Point(216, 101);
            this.LabelItemDescription.Name = "LabelItemDescription";
            this.LabelItemDescription.Size = new System.Drawing.Size(67, 15);
            this.LabelItemDescription.TabIndex = 9;
            this.LabelItemDescription.Text = "Description";
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(22, 404);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(90, 26);
            this.BtnInventory.TabIndex = 20;
            this.BtnInventory.Text = "Inventaire";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click_1);
            // 
            // BtnRegularization
            // 
            this.BtnRegularization.Location = new System.Drawing.Point(22, 375);
            this.BtnRegularization.Name = "BtnRegularization";
            this.BtnRegularization.Size = new System.Drawing.Size(90, 26);
            this.BtnRegularization.TabIndex = 19;
            this.BtnRegularization.Text = "Régularisation";
            this.BtnRegularization.UseVisualStyleBackColor = true;
            this.BtnRegularization.Click += new System.EventHandler(this.BtnRegularization_Click);
            // 
            // BtnCustOrders
            // 
            this.BtnCustOrders.Location = new System.Drawing.Point(22, 318);
            this.BtnCustOrders.Name = "BtnCustOrders";
            this.BtnCustOrders.Size = new System.Drawing.Size(90, 26);
            this.BtnCustOrders.TabIndex = 18;
            this.BtnCustOrders.Text = "Commandes";
            this.BtnCustOrders.UseVisualStyleBackColor = true;
            this.BtnCustOrders.Click += new System.EventHandler(this.BtnCustOrders_Click_1);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Location = new System.Drawing.Point(22, 290);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(90, 26);
            this.BtnCustomers.TabIndex = 17;
            this.BtnCustomers.Text = "Clients";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click_1);
            // 
            // BtnSupOrders
            // 
            this.BtnSupOrders.Location = new System.Drawing.Point(22, 234);
            this.BtnSupOrders.Name = "BtnSupOrders";
            this.BtnSupOrders.Size = new System.Drawing.Size(90, 26);
            this.BtnSupOrders.TabIndex = 16;
            this.BtnSupOrders.Text = "Commandes";
            this.BtnSupOrders.UseVisualStyleBackColor = true;
            this.BtnSupOrders.Click += new System.EventHandler(this.BtnSupOrders_Click_1);
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Location = new System.Drawing.Point(22, 205);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(90, 26);
            this.BtnSuppliers.TabIndex = 15;
            this.BtnSuppliers.Text = "Fournisseurs";
            this.BtnSuppliers.UseVisualStyleBackColor = true;
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // textBoxStocks
            // 
            this.textBoxStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxStocks.Location = new System.Drawing.Point(12, 350);
            this.textBoxStocks.Name = "textBoxStocks";
            this.textBoxStocks.Size = new System.Drawing.Size(100, 22);
            this.textBoxStocks.TabIndex = 14;
            this.textBoxStocks.Text = "STOCKS";
            // 
            // textBoxVentes
            // 
            this.textBoxVentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxVentes.Location = new System.Drawing.Point(12, 265);
            this.textBoxVentes.Name = "textBoxVentes";
            this.textBoxVentes.Size = new System.Drawing.Size(100, 22);
            this.textBoxVentes.TabIndex = 13;
            this.textBoxVentes.Text = "VENTES";
            // 
            // textBoxAchats
            // 
            this.textBoxAchats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAchats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAchats.Location = new System.Drawing.Point(12, 180);
            this.textBoxAchats.Name = "textBoxAchats";
            this.textBoxAchats.Size = new System.Drawing.Size(100, 22);
            this.textBoxAchats.TabIndex = 12;
            this.textBoxAchats.Text = "ACHATS";
            // 
            // ButtonFamilies
            // 
            this.ButtonFamilies.Location = new System.Drawing.Point(22, 151);
            this.ButtonFamilies.Name = "ButtonFamilies";
            this.ButtonFamilies.Size = new System.Drawing.Size(90, 23);
            this.ButtonFamilies.TabIndex = 43;
            this.ButtonFamilies.Text = "Familles";
            this.ButtonFamilies.UseVisualStyleBackColor = true;
            this.ButtonFamilies.Click += new System.EventHandler(this.ButtonFamilies_Click);
            // 
            // TextBoxProducts
            // 
            this.TextBoxProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxProducts.Location = new System.Drawing.Point(12, 96);
            this.TextBoxProducts.Name = "TextBoxProducts";
            this.TextBoxProducts.Size = new System.Drawing.Size(100, 22);
            this.TextBoxProducts.TabIndex = 41;
            this.TextBoxProducts.Text = "PRODUITS";
            // 
            // TextBoxMapFamilies
            // 
            this.TextBoxMapFamilies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapFamilies.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapFamilies.ForeColor = System.Drawing.Color.SeaGreen;
            this.TextBoxMapFamilies.Location = new System.Drawing.Point(300, 6);
            this.TextBoxMapFamilies.Name = "TextBoxMapFamilies";
            this.TextBoxMapFamilies.Size = new System.Drawing.Size(98, 28);
            this.TextBoxMapFamilies.TabIndex = 57;
            this.TextBoxMapFamilies.Text = "ARTICLES";
            // 
            // TextBoxMapProducts
            // 
            this.TextBoxMapProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapProducts.Location = new System.Drawing.Point(152, 12);
            this.TextBoxMapProducts.Name = "TextBoxMapProducts";
            this.TextBoxMapProducts.Size = new System.Drawing.Size(98, 22);
            this.TextBoxMapProducts.TabIndex = 56;
            this.TextBoxMapProducts.Text = "PRODUITS";
            // 
            // PictureBoxItem
            // 
            this.PictureBoxItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxItem.BackgroundImage")));
            this.PictureBoxItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxItem.Location = new System.Drawing.Point(152, 68);
            this.PictureBoxItem.Name = "PictureBoxItem";
            this.PictureBoxItem.Size = new System.Drawing.Size(60, 151);
            this.PictureBoxItem.TabIndex = 58;
            this.PictureBoxItem.TabStop = false;
            // 
            // LabelItemYear
            // 
            this.LabelItemYear.AutoSize = true;
            this.LabelItemYear.Location = new System.Drawing.Point(216, 185);
            this.LabelItemYear.Name = "LabelItemYear";
            this.LabelItemYear.Size = new System.Drawing.Size(41, 15);
            this.LabelItemYear.TabIndex = 60;
            this.LabelItemYear.Text = "Année";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(216, 202);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(204, 23);
            this.TextBoxYear.TabIndex = 59;
            // 
            // LabelStockLimit
            // 
            this.LabelStockLimit.AutoSize = true;
            this.LabelStockLimit.Location = new System.Drawing.Point(472, 76);
            this.LabelStockLimit.Name = "LabelStockLimit";
            this.LabelStockLimit.Size = new System.Drawing.Size(77, 15);
            this.LabelStockLimit.TabIndex = 63;
            this.LabelStockLimit.Text = "Quantité Min";
            // 
            // TextBoxStockMin
            // 
            this.TextBoxStockMin.Location = new System.Drawing.Point(472, 93);
            this.TextBoxStockMin.Name = "TextBoxStockMin";
            this.TextBoxStockMin.Size = new System.Drawing.Size(100, 23);
            this.TextBoxStockMin.TabIndex = 62;
            // 
            // LabelVAT
            // 
            this.LabelVAT.AutoSize = true;
            this.LabelVAT.Location = new System.Drawing.Point(472, 129);
            this.LabelVAT.Name = "LabelVAT";
            this.LabelVAT.Size = new System.Drawing.Size(70, 15);
            this.LabelVAT.TabIndex = 65;
            this.LabelVAT.Text = "Taux de TVA";
            // 
            // TextBoxVAT
            // 
            this.TextBoxVAT.Location = new System.Drawing.Point(472, 146);
            this.TextBoxVAT.Name = "TextBoxVAT";
            this.TextBoxVAT.Size = new System.Drawing.Size(100, 23);
            this.TextBoxVAT.TabIndex = 64;
            // 
            // LabelSellingPriceBT
            // 
            this.LabelSellingPriceBT.AutoSize = true;
            this.LabelSellingPriceBT.Location = new System.Drawing.Point(634, 129);
            this.LabelSellingPriceBT.Name = "LabelSellingPriceBT";
            this.LabelSellingPriceBT.Size = new System.Drawing.Size(93, 15);
            this.LabelSellingPriceBT.TabIndex = 69;
            this.LabelSellingPriceBT.Text = "Prix de vente HT";
            // 
            // TextBoxSellingPriceBT
            // 
            this.TextBoxSellingPriceBT.Location = new System.Drawing.Point(634, 146);
            this.TextBoxSellingPriceBT.Name = "TextBoxSellingPriceBT";
            this.TextBoxSellingPriceBT.Size = new System.Drawing.Size(100, 23);
            this.TextBoxSellingPriceBT.TabIndex = 68;
            // 
            // LabelPurchasePriceBT
            // 
            this.LabelPurchasePriceBT.AutoSize = true;
            this.LabelPurchasePriceBT.Location = new System.Drawing.Point(634, 76);
            this.LabelPurchasePriceBT.Name = "LabelPurchasePriceBT";
            this.LabelPurchasePriceBT.Size = new System.Drawing.Size(89, 15);
            this.LabelPurchasePriceBT.TabIndex = 67;
            this.LabelPurchasePriceBT.Text = "Prix d\'Achat HT";
            // 
            // TextBoxPurchasePriceBT
            // 
            this.TextBoxPurchasePriceBT.Location = new System.Drawing.Point(634, 93);
            this.TextBoxPurchasePriceBT.Name = "TextBoxPurchasePriceBT";
            this.TextBoxPurchasePriceBT.Size = new System.Drawing.Size(100, 23);
            this.TextBoxPurchasePriceBT.TabIndex = 66;
            // 
            // LabelItemFamily
            // 
            this.LabelItemFamily.AutoSize = true;
            this.LabelItemFamily.Location = new System.Drawing.Point(218, 144);
            this.LabelItemFamily.Name = "LabelItemFamily";
            this.LabelItemFamily.Size = new System.Drawing.Size(45, 15);
            this.LabelItemFamily.TabIndex = 70;
            this.LabelItemFamily.Text = "Famille";
            // 
            // ComboBoxItemFamily
            // 
            this.ComboBoxItemFamily.FormattingEnabled = true;
            this.ComboBoxItemFamily.Location = new System.Drawing.Point(216, 163);
            this.ComboBoxItemFamily.Name = "ComboBoxItemFamily";
            this.ComboBoxItemFamily.Size = new System.Drawing.Size(204, 23);
            this.ComboBoxItemFamily.TabIndex = 71;
            this.ComboBoxItemFamily.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemFamily_SelectedIndexChanged);
            // 
            // ScrollBarListItems
            // 
            this.ScrollBarListItems.Location = new System.Drawing.Point(780, 225);
            this.ScrollBarListItems.Name = "ScrollBarListItems";
            this.ScrollBarListItems.Size = new System.Drawing.Size(22, 222);
            this.ScrollBarListItems.TabIndex = 72;
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(557, 196);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(109, 23);
            this.buttonItems.TabIndex = 73;
            this.buttonItems.Text = "Liste articles";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.Location = new System.Drawing.Point(682, 196);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(95, 23);
            this.DeleteItemButton.TabIndex = 74;
            this.DeleteItemButton.Text = "Supprimer";
            this.DeleteItemButton.UseVisualStyleBackColor = true;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // ButtonHomePage
            // 
            this.ButtonHomePage.Location = new System.Drawing.Point(22, 68);
            this.ButtonHomePage.Name = "ButtonHomePage";
            this.ButtonHomePage.Size = new System.Drawing.Size(90, 23);
            this.ButtonHomePage.TabIndex = 75;
            this.ButtonHomePage.Text = "Accueil";
            this.ButtonHomePage.UseVisualStyleBackColor = true;
            this.ButtonHomePage.Click += new System.EventHandler(this.ButtonHomePage_Click_1);
            // 
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonHomePage);
            this.Controls.Add(this.DeleteItemButton);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.ScrollBarListItems);
            this.Controls.Add(this.ComboBoxItemFamily);
            this.Controls.Add(this.LabelItemFamily);
            this.Controls.Add(this.LabelSellingPriceBT);
            this.Controls.Add(this.TextBoxSellingPriceBT);
            this.Controls.Add(this.LabelPurchasePriceBT);
            this.Controls.Add(this.TextBoxPurchasePriceBT);
            this.Controls.Add(this.LabelVAT);
            this.Controls.Add(this.TextBoxVAT);
            this.Controls.Add(this.LabelStockLimit);
            this.Controls.Add(this.TextBoxStockMin);
            this.Controls.Add(this.LabelItemYear);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.PictureBoxItem);
            this.Controls.Add(this.TextBoxMapFamilies);
            this.Controls.Add(this.TextBoxMapProducts);
            this.Controls.Add(this.ButtonFamilies);
            this.Controls.Add(this.TextBoxProducts);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnRegularization);
            this.Controls.Add(this.BtnCustOrders);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnSupOrders);
            this.Controls.Add(this.BtnSuppliers);
            this.Controls.Add(this.textBoxStocks);
            this.Controls.Add(this.textBoxVentes);
            this.Controls.Add(this.textBoxAchats);
            this.Controls.Add(this.LabelItemDescription);
            this.Controls.Add(this.LabelItemName);
            this.Controls.Add(this.TextBoxItemName);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.DataGridViewItemList);
            this.Controls.Add(this.BtnNew);
            this.Name = "FormItems";
            this.Text = "Articles";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNew;
        private DataGridView DataGridViewItemList;
        private TextBox TextBoxDescription;
        private TextBox TextBoxItemName;
        private Label LabelItemName;
        private Label LabelItemDescription;
        private Label LabelFamily;
        private Button ButtonHomePage;
        private Button ButtonFamilies;
        private TextBox TextBoxProducts;
        private Button BtnInventory;
        private Button BtnRegularization;
        private Button BtnCustOrders;
        private Button BtnCustomers;
        private Button BtnSupOrders;
        private Button BtnSuppliers;
        private TextBox textBoxStocks;
        private TextBox textBoxSellings;
        private TextBox textBoxPurchases;
        private Label LabelSellingPriceBT;
        private TextBox TextBoxSellingPriceBT;
        private Label LabelTVA;
        private TextBox TextBoxYear;
        private Label LabelMinLimit;
        private TextBox TextBoxStockMin;
        private Label labelYear;
        private TextBox TextBoxVAT;
        private PictureBox PictureBoxItemPicture;
        private TextBox TextBoxMapItems;
        private TextBox TextBoxMapProducts;
        private VScrollBar ScrollBarItems;
        private ComboBox ComboBoxFamily;
        private TextBox textBoxVentes;
        private TextBox textBoxAchats;
        private TextBox TextBoxMapFamilies;
        private PictureBox PictureBoxItem;
        private Label LabelItemYear;
        private Label LabelStockLimit;
        private Label LabelVAT;
        private Label LabelPurchasePriceBT;
        private TextBox TextBoxPurchasePriceBT;
        private Label LabelItemFamily;
        private ComboBox ComboBoxItemFamily;
        private VScrollBar ScrollBarListItems;
        private Button buttonItems;
        private Button DeleteItemButton;
    }
}
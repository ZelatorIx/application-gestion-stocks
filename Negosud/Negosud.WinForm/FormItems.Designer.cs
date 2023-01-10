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
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxItemName = new System.Windows.Forms.TextBox();
            this.LabelItemName = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelFamily = new System.Windows.Forms.Label();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnRegularisation = new System.Windows.Forms.Button();
            this.BtnCustOrders = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnSupOrders = new System.Windows.Forms.Button();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.textBoxStocks = new System.Windows.Forms.TextBox();
            this.textBoxVentes = new System.Windows.Forms.TextBox();
            this.textBoxAchats = new System.Windows.Forms.TextBox();
            this.textBoxAccueil = new System.Windows.Forms.TextBox();
            this.ButtonFamilies = new System.Windows.Forms.Button();
            this.ButtonItems = new System.Windows.Forms.Button();
            this.TextBoxProducts = new System.Windows.Forms.TextBox();
            this.TextBoxMapFamilies = new System.Windows.Forms.TextBox();
            this.TextBoxMapProducts = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.ComboBoxFamily = new System.Windows.Forms.ComboBox();
            this.LabelStockLimit = new System.Windows.Forms.Label();
            this.TextBoxStockMin = new System.Windows.Forms.TextBox();
            this.LabelVAT = new System.Windows.Forms.Label();
            this.TextBoxVAT = new System.Windows.Forms.TextBox();
            this.LabelSellingPriceBT = new System.Windows.Forms.Label();
            this.TextBoxSellingPriceBT = new System.Windows.Forms.TextBox();
            this.LabelPurchasePriceBT = new System.Windows.Forms.Label();
            this.TextBoxPurchasePriceBT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.BackColor = System.Drawing.Color.MistyRose;
            this.BtnNouveau.Location = new System.Drawing.Point(472, 196);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(75, 23);
            this.BtnNouveau.TabIndex = 0;
            this.BtnNouveau.Text = "Créer";
            this.BtnNouveau.UseVisualStyleBackColor = false;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.BtnDelete.Location = new System.Drawing.Point(659, 196);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(152, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(625, 220);
            this.dataGridView1.TabIndex = 2;
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
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(216, 101);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(67, 15);
            this.LabelDescription.TabIndex = 9;
            this.LabelDescription.Text = "Description";
            // 
            // LabelFamily
            // 
            this.LabelFamily.AutoSize = true;
            this.LabelFamily.Location = new System.Drawing.Point(216, 143);
            this.LabelFamily.Name = "LabelFamily";
            this.LabelFamily.Size = new System.Drawing.Size(45, 15);
            this.LabelFamily.TabIndex = 10;
            this.LabelFamily.Text = "Famille";
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(22, 404);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(90, 26);
            this.BtnInventory.TabIndex = 20;
            this.BtnInventory.Text = "Inventaire";
            this.BtnInventory.UseVisualStyleBackColor = true;
            // 
            // BtnRegularisation
            // 
            this.BtnRegularisation.Location = new System.Drawing.Point(22, 375);
            this.BtnRegularisation.Name = "BtnRegularisation";
            this.BtnRegularisation.Size = new System.Drawing.Size(90, 26);
            this.BtnRegularisation.TabIndex = 19;
            this.BtnRegularisation.Text = "Régularisation";
            this.BtnRegularisation.UseVisualStyleBackColor = true;
            // 
            // BtnCustOrders
            // 
            this.BtnCustOrders.Location = new System.Drawing.Point(22, 318);
            this.BtnCustOrders.Name = "BtnCustOrders";
            this.BtnCustOrders.Size = new System.Drawing.Size(90, 26);
            this.BtnCustOrders.TabIndex = 18;
            this.BtnCustOrders.Text = "Commandes";
            this.BtnCustOrders.UseVisualStyleBackColor = true;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Location = new System.Drawing.Point(22, 290);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(90, 26);
            this.BtnCustomers.TabIndex = 17;
            this.BtnCustomers.Text = "Clients";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnSupOrders
            // 
            this.BtnSupOrders.Location = new System.Drawing.Point(22, 234);
            this.BtnSupOrders.Name = "BtnSupOrders";
            this.BtnSupOrders.Size = new System.Drawing.Size(90, 26);
            this.BtnSupOrders.TabIndex = 16;
            this.BtnSupOrders.Text = "Commandes";
            this.BtnSupOrders.UseVisualStyleBackColor = true;
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Location = new System.Drawing.Point(22, 205);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(90, 26);
            this.BtnSuppliers.TabIndex = 15;
            this.BtnSuppliers.Text = "Fournisseurs";
            this.BtnSuppliers.UseVisualStyleBackColor = true;
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
            // textBoxAccueil
            // 
            this.textBoxAccueil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccueil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccueil.Location = new System.Drawing.Point(12, 68);
            this.textBoxAccueil.Name = "textBoxAccueil";
            this.textBoxAccueil.Size = new System.Drawing.Size(100, 22);
            this.textBoxAccueil.TabIndex = 11;
            this.textBoxAccueil.Text = "ACCUEIL";
            // 
            // ButtonFamilies
            // 
            this.ButtonFamilies.Location = new System.Drawing.Point(22, 151);
            this.ButtonFamilies.Name = "ButtonFamilies";
            this.ButtonFamilies.Size = new System.Drawing.Size(90, 23);
            this.ButtonFamilies.TabIndex = 43;
            this.ButtonFamilies.Text = "Familles";
            this.ButtonFamilies.UseVisualStyleBackColor = true;
            // 
            // ButtonItems
            // 
            this.ButtonItems.Location = new System.Drawing.Point(22, 121);
            this.ButtonItems.Name = "ButtonItems";
            this.ButtonItems.Size = new System.Drawing.Size(90, 23);
            this.ButtonItems.TabIndex = 42;
            this.ButtonItems.Text = "Articles";
            this.ButtonItems.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(152, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 151);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(216, 185);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(41, 15);
            this.LabelYear.TabIndex = 60;
            this.LabelYear.Text = "Année";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(216, 202);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(204, 23);
            this.TextBoxYear.TabIndex = 59;
            // 
            // ComboBoxFamily
            // 
            this.ComboBoxFamily.FormattingEnabled = true;
            this.ComboBoxFamily.Location = new System.Drawing.Point(217, 160);
            this.ComboBoxFamily.Name = "ComboBoxFamily";
            this.ComboBoxFamily.Size = new System.Drawing.Size(204, 23);
            this.ComboBoxFamily.TabIndex = 61;
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
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelSellingPriceBT);
            this.Controls.Add(this.TextBoxSellingPriceBT);
            this.Controls.Add(this.LabelPurchasePriceBT);
            this.Controls.Add(this.TextBoxPurchasePriceBT);
            this.Controls.Add(this.LabelVAT);
            this.Controls.Add(this.TextBoxVAT);
            this.Controls.Add(this.LabelStockLimit);
            this.Controls.Add(this.TextBoxStockMin);
            this.Controls.Add(this.ComboBoxFamily);
            this.Controls.Add(this.LabelYear);
            this.Controls.Add(this.TextBoxYear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxMapFamilies);
            this.Controls.Add(this.TextBoxMapProducts);
            this.Controls.Add(this.ButtonFamilies);
            this.Controls.Add(this.ButtonItems);
            this.Controls.Add(this.TextBoxProducts);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnRegularisation);
            this.Controls.Add(this.BtnCustOrders);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnSupOrders);
            this.Controls.Add(this.BtnSuppliers);
            this.Controls.Add(this.textBoxStocks);
            this.Controls.Add(this.textBoxVentes);
            this.Controls.Add(this.textBoxAchats);
            this.Controls.Add(this.textBoxAccueil);
            this.Controls.Add(this.LabelFamily);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelItemName);
            this.Controls.Add(this.TextBoxItemName);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNouveau);
            this.Name = "FormItems";
            this.Text = "Articles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNouveau;
        private Button BtnDelete;
        private DataGridView dataGridView1;
        private TextBox TextBoxDescription;
        private TextBox TextBoxItemName;
        private Label LabelItemName;
        private Label LabelDescription;
        private Label LabelFamily;
        private Button ButtonHomePage;
        private Button ButtonFamilies;
        private Button ButtonItems;
        private TextBox TextBoxProducts;
        private Button BtnInventory;
        private Button BtnRegularisation;
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
        private Label LabelFamily;
        private TextBox textBoxVentes;
        private TextBox textBoxAchats;
        private TextBox textBoxAccueil;
        private TextBox TextBoxMapFamilies;
        private PictureBox pictureBox1;
        private Label LabelYear;
        private ComboBox ComboBoxFamily;
        private Label LabelStockLimit;
        private Label LabelVAT;
        private Label LabelPurchasePriceBT;
        private TextBox TextBoxPurchasePriceBT;
    }
}
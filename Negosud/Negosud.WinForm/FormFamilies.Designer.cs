﻿namespace Negosud.WinForm
{
    partial class FormFamilies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamilies));
            this.ButtonItems = new System.Windows.Forms.Button();
            this.TextBoxProducts = new System.Windows.Forms.TextBox();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnRegularisation = new System.Windows.Forms.Button();
            this.BtnCustOrders = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnSupOrders = new System.Windows.Forms.Button();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.TextBoxStocks = new System.Windows.Forms.TextBox();
            this.TextBoxSellings = new System.Windows.Forms.TextBox();
            this.TextBoxPurchases = new System.Windows.Forms.TextBox();
            this.TextBoxMapFamilies = new System.Windows.Forms.TextBox();
            this.TextBoxMapProducts = new System.Windows.Forms.TextBox();
            this.ScrollBarCustomers = new System.Windows.Forms.VScrollBar();
            this.LabelCustName = new System.Windows.Forms.Label();
            this.TextBoxFamilyName = new System.Windows.Forms.TextBox();
            this.DataGridViewFamilyList = new System.Windows.Forms.DataGridView();
            this.ButtonAddNewFamily = new System.Windows.Forms.Button();
            this.ButtonHomePage = new System.Windows.Forms.Button();
            this.ButtonFamilies = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFamilyList)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonItems
            // 
            this.ButtonItems.Location = new System.Drawing.Point(22, 115);
            this.ButtonItems.Name = "ButtonItems";
            this.ButtonItems.Size = new System.Drawing.Size(90, 23);
            this.ButtonItems.TabIndex = 52;
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
            this.TextBoxProducts.TabIndex = 51;
            this.TextBoxProducts.Text = "PRODUITS";
            // 
            // BtnInventory
            // 
            this.BtnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnInventory.Location = new System.Drawing.Point(22, 415);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(90, 23);
            this.BtnInventory.TabIndex = 50;
            this.BtnInventory.Text = "Inventaire";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnRegularisation
            // 
            this.BtnRegularisation.Location = new System.Drawing.Point(22, 385);
            this.BtnRegularisation.Name = "BtnRegularisation";
            this.BtnRegularisation.Size = new System.Drawing.Size(90, 23);
            this.BtnRegularisation.TabIndex = 49;
            this.BtnRegularisation.Text = "Régularisation";
            this.BtnRegularisation.UseVisualStyleBackColor = true;
            this.BtnRegularisation.Click += new System.EventHandler(this.BtnRegularisation_Click);
            // 
            // BtnCustOrders
            // 
            this.BtnCustOrders.Location = new System.Drawing.Point(22, 325);
            this.BtnCustOrders.Name = "BtnCustOrders";
            this.BtnCustOrders.Size = new System.Drawing.Size(90, 23);
            this.BtnCustOrders.TabIndex = 48;
            this.BtnCustOrders.Text = "Commandes";
            this.BtnCustOrders.UseVisualStyleBackColor = true;
            this.BtnCustOrders.Click += new System.EventHandler(this.BtnCustOrders_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Location = new System.Drawing.Point(22, 295);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(90, 23);
            this.BtnCustomers.TabIndex = 47;
            this.BtnCustomers.Text = "Clients";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnSupOrders
            // 
            this.BtnSupOrders.Location = new System.Drawing.Point(22, 235);
            this.BtnSupOrders.Name = "BtnSupOrders";
            this.BtnSupOrders.Size = new System.Drawing.Size(90, 23);
            this.BtnSupOrders.TabIndex = 46;
            this.BtnSupOrders.Text = "Commandes";
            this.BtnSupOrders.UseVisualStyleBackColor = true;
            this.BtnSupOrders.Click += new System.EventHandler(this.BtnSupOrders_Click);
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Location = new System.Drawing.Point(22, 205);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(90, 23);
            this.BtnSuppliers.TabIndex = 45;
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
            this.TextBoxStocks.TabIndex = 44;
            this.TextBoxStocks.Text = "STOCKS";
            // 
            // TextBoxSellings
            // 
            this.TextBoxSellings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSellings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxSellings.Location = new System.Drawing.Point(12, 270);
            this.TextBoxSellings.Name = "TextBoxSellings";
            this.TextBoxSellings.Size = new System.Drawing.Size(100, 22);
            this.TextBoxSellings.TabIndex = 43;
            this.TextBoxSellings.Text = "VENTES";
            // 
            // TextBoxPurchases
            // 
            this.TextBoxPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPurchases.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxPurchases.Location = new System.Drawing.Point(12, 180);
            this.TextBoxPurchases.Name = "TextBoxPurchases";
            this.TextBoxPurchases.Size = new System.Drawing.Size(100, 22);
            this.TextBoxPurchases.TabIndex = 42;
            this.TextBoxPurchases.Text = "ACHATS";
            // 
            // TextBoxMapFamilies
            // 
            this.TextBoxMapFamilies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapFamilies.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapFamilies.ForeColor = System.Drawing.Color.SeaGreen;
            this.TextBoxMapFamilies.Location = new System.Drawing.Point(300, 6);
            this.TextBoxMapFamilies.Name = "TextBoxMapFamilies";
            this.TextBoxMapFamilies.Size = new System.Drawing.Size(98, 28);
            this.TextBoxMapFamilies.TabIndex = 55;
            this.TextBoxMapFamilies.Text = "FAMILLES";
            // 
            // TextBoxMapProducts
            // 
            this.TextBoxMapProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapProducts.Location = new System.Drawing.Point(152, 12);
            this.TextBoxMapProducts.Name = "TextBoxMapProducts";
            this.TextBoxMapProducts.Size = new System.Drawing.Size(98, 22);
            this.TextBoxMapProducts.TabIndex = 54;
            this.TextBoxMapProducts.Text = "PRODUITS";
            // 
            // ScrollBarCustomers
            // 
            this.ScrollBarCustomers.Location = new System.Drawing.Point(774, 225);
            this.ScrollBarCustomers.Name = "ScrollBarCustomers";
            this.ScrollBarCustomers.Size = new System.Drawing.Size(22, 222);
            this.ScrollBarCustomers.TabIndex = 71;
            // 
            // LabelCustName
            // 
            this.LabelCustName.AutoSize = true;
            this.LabelCustName.Location = new System.Drawing.Point(165, 63);
            this.LabelCustName.Name = "LabelCustName";
            this.LabelCustName.Size = new System.Drawing.Size(34, 15);
            this.LabelCustName.TabIndex = 64;
            this.LabelCustName.Text = "Nom";
            // 
            // TextBoxFamilyName
            // 
            this.TextBoxFamilyName.Location = new System.Drawing.Point(165, 79);
            this.TextBoxFamilyName.Name = "TextBoxFamilyName";
            this.TextBoxFamilyName.Size = new System.Drawing.Size(259, 23);
            this.TextBoxFamilyName.TabIndex = 57;
            // 
            // DataGridViewFamilyList
            // 
            this.DataGridViewFamilyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFamilyList.Location = new System.Drawing.Point(152, 227);
            this.DataGridViewFamilyList.Name = "DataGridViewFamilyList";
            this.DataGridViewFamilyList.RowTemplate.Height = 25;
            this.DataGridViewFamilyList.Size = new System.Drawing.Size(623, 220);
            this.DataGridViewFamilyList.TabIndex = 56;
            this.DataGridViewFamilyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFamilyList_CellContentClick);
            // 
            // ButtonAddNewFamily
            // 
            this.ButtonAddNewFamily.BackColor = System.Drawing.Color.MistyRose;
            this.ButtonAddNewFamily.Location = new System.Drawing.Point(443, 79);
            this.ButtonAddNewFamily.Name = "ButtonAddNewFamily";
            this.ButtonAddNewFamily.Size = new System.Drawing.Size(71, 23);
            this.ButtonAddNewFamily.TabIndex = 72;
            this.ButtonAddNewFamily.Text = "Créer";
            this.ButtonAddNewFamily.UseVisualStyleBackColor = false;
            this.ButtonAddNewFamily.Click += new System.EventHandler(this.ButtonAddNewFamily_Click);
            // 
            // ButtonHomePage
            // 
            this.ButtonHomePage.Location = new System.Drawing.Point(22, 61);
            this.ButtonHomePage.Name = "ButtonHomePage";
            this.ButtonHomePage.Size = new System.Drawing.Size(90, 23);
            this.ButtonHomePage.TabIndex = 75;
            this.ButtonHomePage.Text = "Accueil";
            this.ButtonHomePage.UseVisualStyleBackColor = true;
            this.ButtonHomePage.Click += new System.EventHandler(this.ButtonHomePage_Click);
            // 
            // ButtonFamilies
            // 
            this.ButtonFamilies.Location = new System.Drawing.Point(165, 198);
            this.ButtonFamilies.Name = "ButtonFamilies";
            this.ButtonFamilies.Size = new System.Drawing.Size(133, 23);
            this.ButtonFamilies.TabIndex = 76;
            this.ButtonFamilies.Text = "Liste de Familles";
            this.ButtonFamilies.UseVisualStyleBackColor = true;
            this.ButtonFamilies.Click += new System.EventHandler(this.buttonFamilies_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(314, 198);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(187, 23);
            this.ButtonDelete.TabIndex = 77;
            this.ButtonDelete.Text = "Supprimer Famille Selectionnée";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormFamilies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonFamilies);
            this.Controls.Add(this.ButtonHomePage);
            this.Controls.Add(this.ButtonAddNewFamily);
            this.Controls.Add(this.ScrollBarCustomers);
            this.Controls.Add(this.LabelCustName);
            this.Controls.Add(this.TextBoxFamilyName);
            this.Controls.Add(this.DataGridViewFamilyList);
            this.Controls.Add(this.TextBoxMapFamilies);
            this.Controls.Add(this.TextBoxMapProducts);
            this.Controls.Add(this.ButtonItems);
            this.Controls.Add(this.TextBoxProducts);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnRegularisation);
            this.Controls.Add(this.BtnCustOrders);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnSupOrders);
            this.Controls.Add(this.BtnSuppliers);
            this.Controls.Add(this.TextBoxStocks);
            this.Controls.Add(this.TextBoxSellings);
            this.Controls.Add(this.TextBoxPurchases);
            this.Name = "FormFamilies";
            this.Text = "FormFamilies";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFamilyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ButtonItems;
        private TextBox TextBoxProducts;
        private Button BtnInventory;
        private Button BtnRegularisation;
        private Button BtnCustOrders;
        private Button BtnCustomers;
        private Button BtnSupOrders;
        private Button BtnSuppliers;
        private TextBox TextBoxStocks;
        private TextBox TextBoxSellings;
        private TextBox TextBoxPurchases;
        private TextBox TextBoxMapFamilies;
        private TextBox TextBoxMapProducts;
        private VScrollBar ScrollBarCustomers;
        private Label LabelCustName;
        private TextBox TextBoxFamilyName;
        private DataGridView DataGridViewFamilyList;
        private Button ButtonAddNewFamily;
        private Button ButtonHomePage;
        private Button ButtonFamilies;
        private Button ButtonDelete;
    }
}
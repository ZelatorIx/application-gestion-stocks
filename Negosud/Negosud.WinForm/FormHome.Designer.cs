﻿namespace Negosud.WinForm
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.textBoxAccueil = new System.Windows.Forms.TextBox();
            this.textBoxAchats = new System.Windows.Forms.TextBox();
            this.textBoxVentes = new System.Windows.Forms.TextBox();
            this.textBoxStocks = new System.Windows.Forms.TextBox();
            this.BtnSuppliers = new System.Windows.Forms.Button();
            this.BtnSupOrders = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnCustOrders = new System.Windows.Forms.Button();
            this.BtnRegularisation = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.TextBoxMapHomePage = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxWelcome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAccueil
            // 
            this.textBoxAccueil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccueil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccueil.Location = new System.Drawing.Point(12, 72);
            this.textBoxAccueil.Name = "textBoxAccueil";
            this.textBoxAccueil.Size = new System.Drawing.Size(100, 22);
            this.textBoxAccueil.TabIndex = 0;
            this.textBoxAccueil.Text = "ACCUEIL";
            // 
            // textBoxAchats
            // 
            this.textBoxAchats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAchats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAchats.Location = new System.Drawing.Point(12, 157);
            this.textBoxAchats.Name = "textBoxAchats";
            this.textBoxAchats.Size = new System.Drawing.Size(100, 22);
            this.textBoxAchats.TabIndex = 1;
            this.textBoxAchats.Text = "ACHATS";
            // 
            // textBoxVentes
            // 
            this.textBoxVentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxVentes.Location = new System.Drawing.Point(12, 242);
            this.textBoxVentes.Name = "textBoxVentes";
            this.textBoxVentes.Size = new System.Drawing.Size(100, 22);
            this.textBoxVentes.TabIndex = 2;
            this.textBoxVentes.Text = "VENTES";
            // 
            // textBoxStocks
            // 
            this.textBoxStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxStocks.Location = new System.Drawing.Point(12, 327);
            this.textBoxStocks.Name = "textBoxStocks";
            this.textBoxStocks.Size = new System.Drawing.Size(100, 22);
            this.textBoxStocks.TabIndex = 3;
            this.textBoxStocks.Text = "STOCKS";
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.Location = new System.Drawing.Point(22, 185);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(90, 23);
            this.BtnSuppliers.TabIndex = 4;
            this.BtnSuppliers.Text = "Fournisseurs";
            this.BtnSuppliers.UseVisualStyleBackColor = true;
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // BtnSupOrders
            // 
            this.BtnSupOrders.Location = new System.Drawing.Point(22, 214);
            this.BtnSupOrders.Name = "BtnSupOrders";
            this.BtnSupOrders.Size = new System.Drawing.Size(90, 23);
            this.BtnSupOrders.TabIndex = 5;
            this.BtnSupOrders.Text = "Commandes";
            this.BtnSupOrders.UseVisualStyleBackColor = true;
            this.BtnSupOrders.Click += new System.EventHandler(this.BtnSupOrders_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Location = new System.Drawing.Point(22, 270);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(90, 23);
            this.BtnCustomers.TabIndex = 6;
            this.BtnCustomers.Text = "Clients";
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnCustOrders
            // 
            this.BtnCustOrders.Location = new System.Drawing.Point(22, 298);
            this.BtnCustOrders.Name = "BtnCustOrders";
            this.BtnCustOrders.Size = new System.Drawing.Size(90, 23);
            this.BtnCustOrders.TabIndex = 7;
            this.BtnCustOrders.Text = "Commandes";
            this.BtnCustOrders.UseVisualStyleBackColor = true;
            this.BtnCustOrders.Click += new System.EventHandler(this.BtnCustOrders_Click);
            // 
            // BtnRegularisation
            // 
            this.BtnRegularisation.Location = new System.Drawing.Point(22, 355);
            this.BtnRegularisation.Name = "BtnRegularisation";
            this.BtnRegularisation.Size = new System.Drawing.Size(90, 23);
            this.BtnRegularisation.TabIndex = 8;
            this.BtnRegularisation.Text = "Régularisation";
            this.BtnRegularisation.UseVisualStyleBackColor = true;
            this.BtnRegularisation.Click += new System.EventHandler(this.BtnRegularisation_Click);
            // 
            // BtnInventory
            // 
            this.BtnInventory.Location = new System.Drawing.Point(22, 384);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(90, 23);
            this.BtnInventory.TabIndex = 9;
            this.BtnInventory.Text = "Inventaire";
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // TextBoxMapHomePage
            // 
            this.TextBoxMapHomePage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMapHomePage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxMapHomePage.Location = new System.Drawing.Point(152, 12);
            this.TextBoxMapHomePage.Name = "TextBoxMapHomePage";
            this.TextBoxMapHomePage.Size = new System.Drawing.Size(100, 22);
            this.TextBoxMapHomePage.TabIndex = 10;
            this.TextBoxMapHomePage.Text = "ACCUEIL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(161, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 82);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxWelcome
            // 
            this.TextBoxWelcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxWelcome.Location = new System.Drawing.Point(364, 190);
            this.TextBoxWelcome.Name = "TextBoxWelcome";
            this.TextBoxWelcome.Size = new System.Drawing.Size(175, 33);
            this.TextBoxWelcome.TabIndex = 12;
            this.TextBoxWelcome.Text = "Bienvenue";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxMapHomePage);
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
            this.Name = "FormHome";
            this.Text = "FormModel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxAccueil;
        private TextBox textBoxAchats;
        private TextBox textBoxVentes;
        private TextBox textBoxStocks;
        private Button BtnSuppliers;
        private Button BtnSupOrders;
        private Button BtnCustomers;
        private Button BtnCustOrders;
        private Button BtnRegularisation;
        private Button BtnInventory;
        private TextBox TextBoxMapHomePage;
        private PictureBox pictureBox1;
        private TextBox TextBoxWelcome;
    }
}
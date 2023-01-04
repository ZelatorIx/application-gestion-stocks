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
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.TextBoxPurchasePriceBT = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxItemName = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelItemName = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelPurchasePriceBT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Location = new System.Drawing.Point(114, 45);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(75, 23);
            this.BtnNouveau.TabIndex = 0;
            this.BtnNouveau.Text = "Créer";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(264, 45);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(319, 352);
            this.dataGridView1.TabIndex = 2;
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(63, 105);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.ReadOnly = true;
            this.TextBoxId.Size = new System.Drawing.Size(204, 23);
            this.TextBoxId.TabIndex = 3;
            // 
            // TextBoxFamily
            // 
            this.TextBoxPurchasePriceBT.Location = new System.Drawing.Point(63, 246);
            this.TextBoxPurchasePriceBT.Name = "TextBoxFamily";
            this.TextBoxPurchasePriceBT.Size = new System.Drawing.Size(204, 23);
            this.TextBoxPurchasePriceBT.TabIndex = 4;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(63, 199);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(204, 23);
            this.TextBoxDescription.TabIndex = 5;
            // 
            // TextBoxName
            // 
            this.TextBoxItemName.Location = new System.Drawing.Point(63, 152);
            this.TextBoxItemName.Name = "TextBoxName";
            this.TextBoxItemName.Size = new System.Drawing.Size(204, 23);
            this.TextBoxItemName.TabIndex = 6;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(63, 84);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(17, 15);
            this.LabelId.TabIndex = 7;
            this.LabelId.Text = "Id";
            // 
            // LabelName
            // 
            this.LabelItemName.AutoSize = true;
            this.LabelItemName.Location = new System.Drawing.Point(63, 132);
            this.LabelItemName.Name = "LabelName";
            this.LabelItemName.Size = new System.Drawing.Size(34, 15);
            this.LabelItemName.TabIndex = 8;
            this.LabelItemName.Text = "Nom";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(63, 180);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(67, 15);
            this.LabelDescription.TabIndex = 9;
            this.LabelDescription.Text = "Description";
            // 
            // LabelFamily
            // 
            this.LabelPurchasePriceBT.AutoSize = true;
            this.LabelPurchasePriceBT.Location = new System.Drawing.Point(63, 228);
            this.LabelPurchasePriceBT.Name = "LabelFamily";
            this.LabelPurchasePriceBT.Size = new System.Drawing.Size(45, 15);
            this.LabelPurchasePriceBT.TabIndex = 10;
            this.LabelPurchasePriceBT.Text = "Famille";
            // 
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelPurchasePriceBT);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelItemName);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TextBoxItemName);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxPurchasePriceBT);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNouveau);
            this.Name = "FormItems";
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.FormItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNouveau;
        private Button BtnDelete;
        private DataGridView dataGridView1;
        private TextBox TextBoxPurchasePriceBT;
        private TextBox TextBoxDescription;
        private TextBox TextBoxItemName;
        private Label LabelItemName;
        private Label LabelDescription;
        private Label LabelPurchasePriceBT;
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
        private TextBox textBox1;
        private Label LabelMinLimit;
        private TextBox textBox2;
        private Label labelYear;
        private TextBox textBox3;
        private PictureBox PictureBoxItemPicture;
        private TextBox TextBoxMapItems;
        private TextBox TextBoxMapProducts;
        private VScrollBar ScrollBarItems;
        private ComboBox ComboBoxFamily;
        private Label LabelFamily;
    }
}
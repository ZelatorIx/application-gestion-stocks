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
            this.TextBoxFamily = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelFamily = new System.Windows.Forms.Label();
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
            this.TextBoxFamily.Location = new System.Drawing.Point(63, 246);
            this.TextBoxFamily.Name = "TextBoxFamily";
            this.TextBoxFamily.Size = new System.Drawing.Size(204, 23);
            this.TextBoxFamily.TabIndex = 4;
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
            this.TextBoxName.Location = new System.Drawing.Point(63, 152);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(204, 23);
            this.TextBoxName.TabIndex = 6;
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
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(63, 132);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(34, 15);
            this.LabelName.TabIndex = 8;
            this.LabelName.Text = "Nom";
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
            this.LabelFamily.AutoSize = true;
            this.LabelFamily.Location = new System.Drawing.Point(63, 228);
            this.LabelFamily.Name = "LabelFamily";
            this.LabelFamily.Size = new System.Drawing.Size(45, 15);
            this.LabelFamily.TabIndex = 10;
            this.LabelFamily.Text = "Famille";
            // 
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelFamily);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxFamily);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNouveau);
            this.Name = "FormItems";
            this.Text = "Articles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNouveau;
        private Button BtnDelete;
        private DataGridView dataGridView1;
        private TextBox TextBoxId;
        private TextBox TextBoxFamily;
        private TextBox TextBoxDescription;
        private TextBox TextBoxName;
        private Label LabelId;
        private Label LabelName;
        private Label LabelDescription;
        private Label LabelFamily;
    }
}
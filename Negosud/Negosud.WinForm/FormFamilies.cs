using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud.WinForm
{
    public partial class FormFamilies : Form
    {
        public FormFamilies()
        {
            InitializeComponent();
        }

        private void ButtonAddNewFamily_Click(object sender, EventArgs e)
        {
            // But envoyer le nouvel objet DTO à l'API
            // 1 Récupérer les valeurs de(s) textBox
            string Name = TextBoxFamilyName.Text;
            // 2 Créer l'objet DTO

            // 3 Remplir ce nouvel Objet avec les valeurs de Etape 1

            // 4 Appeler la web API (route Family et avec Post)  avec cet objet DTO



        }
    }
}

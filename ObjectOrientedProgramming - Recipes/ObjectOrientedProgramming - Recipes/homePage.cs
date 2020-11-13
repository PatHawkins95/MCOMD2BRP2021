using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedProgramming___Recipes
{
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectRecipeComboBox.Items.Add("Chicken Fajita Pasta");
            selectRecipeComboBox.Items.Add("Creamy Cajun Chicken and rice");
            selectRecipeComboBox.Items.Add("Home Made Steak and Chips");
            selectRecipeComboBox.Items.Add("Chicken and muschroom risotto");
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            recipePage recipePage = new recipePage();
            recipePage.Visible = true;
        }
    }
}

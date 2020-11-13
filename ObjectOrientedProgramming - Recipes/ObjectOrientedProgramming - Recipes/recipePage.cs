using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedProgramming___Recipes
{
    public partial class recipePage : Form
    {
        public recipePage()
        {
            InitializeComponent();
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            string ingredients = "\\ingredients.txt";
            ingredients = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ingredients;

            System.IO.StreamReader objReader;
            objReader = new System.IO.StreamReader(ingredients);

            ingredientTB.Text = objReader.ReadLine();

            objReader.Close();

        }

        private void ingredientTB_TextChanged(object sender, EventArgs e)
        {
            string ingredients = "\\ingredients.txt";
            ingredients = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ingredients;

            System.IO.StreamReader objReader;
            objReader = new System.IO.StreamReader(ingredients);

            ingredientTB.Text = objReader.ReadLine();

            objReader.Close();
        }
    }
}

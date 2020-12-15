using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unserious_program
{
    public partial class AddDrink : Form
    {
        public string drinkName = "";
        public int drinkPrice = 0;

        public AddDrink()
        {
            InitializeComponent();
            priceNumericUpDown.Maximum = int.MaxValue;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(nameTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("Hiányzik a név");
                    return;
                }

                drinkName = nameTextBox.Text;
                drinkPrice = (int)priceNumericUpDown.Value;

                DialogResult = DialogResult.OK;
                Close();
            } catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

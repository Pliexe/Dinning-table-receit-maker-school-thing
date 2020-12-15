using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unserious_program
{
    public partial class EditDrink : Form
    {
        public Drink drink;

        public EditDrink(Drink _drink)
        {
            drink = _drink;
            InitializeComponent();
            priceNumericUpDown.Maximum = int.MaxValue;
            nameTextBox.Text = _drink.name;
            priceNumericUpDown.Value = _drink.price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("Hiányzik a név");
                    return;
                }

                drink.price = (int)priceNumericUpDown.Value;
                drink.name = nameTextBox.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

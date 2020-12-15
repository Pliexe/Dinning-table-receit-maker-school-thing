using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Unserious_program
{
    public partial class DrinksControlForm : Form
    {
        public List<Drink> drinks;
        BindingSource bindingSource = new BindingSource();

        public DrinksControlForm(List<Drink> _drinks)
        {
            drinks = _drinks;
            InitializeComponent();
            bindingSource.DataSource = drinks;
            drinksListBox.DataSource = bindingSource;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            using (AddDrink addDrink = new AddDrink())
            {
                if (addDrink.ShowDialog() == DialogResult.OK)
                {
                    drinks.Add(new Drink(addDrink.drinkName, addDrink.drinkPrice));
                    bindingSource.ResetBindings(false);
                }
            }
        }

        private void RemoveDrinkButton_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex == -1) return;
            drinks.RemoveAt(drinksListBox.SelectedIndex);
            bindingSource.ResetBindings(false);
        }

        private void EditDrinkButton_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex == -1) return;
            using (EditDrink editDrink = new EditDrink(drinks[drinksListBox.SelectedIndex]))
            {
                if (editDrink.ShowDialog() == DialogResult.OK)
                {
                    drinks[drinksListBox.SelectedIndex] = editDrink.drink;
                    bindingSource.ResetBindings(false);
                }
            }
        }

        private void SortNumBiggerToSmaller_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex == -1) return;
            drinks.Sort((a, b) => b.price - a.price);
            bindingSource.ResetBindings(false);
        }

        private void SortNumSmallerToBigger_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex == -1) return;
            drinks.Sort((a, b) => a.price - b.price);
            bindingSource.ResetBindings(false);
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex == -1) return;
            if (drinks.Count <= drinksListBox.SelectedIndex + 1) return;

            Drink temp = drinks[drinksListBox.SelectedIndex];
            drinks[drinksListBox.SelectedIndex] = drinks[drinksListBox.SelectedIndex + 1];
            drinks[drinksListBox.SelectedIndex + 1] = temp;
            drinksListBox.SelectedIndex += 1;
            bindingSource.ResetBindings(false);
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            if (drinksListBox.SelectedIndex == -1) return;
            if (drinksListBox.SelectedIndex <= 0) return;

            Drink temp = drinks[drinksListBox.SelectedIndex];
            drinks[drinksListBox.SelectedIndex] = drinks[drinksListBox.SelectedIndex - 1];
            drinks[drinksListBox.SelectedIndex - 1] = temp;
            drinksListBox.SelectedIndex -= 1;
            bindingSource.ResetBindings(false);
        }
    }
}

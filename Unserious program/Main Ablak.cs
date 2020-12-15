using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unserious_program
{
    public partial class Form1 : Form
    {
        List<Drink> drinks = new List<Drink>();
        List<Drink> checkout = new List<Drink>();
        BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            CheckoutGroupBox.DataSource = bindingSource;
            bindingSource.DataSource = checkout;

            drinks.Add(new Drink("Coca Cola", 100));
            drinks.Add(new Drink("Beer", 110));
            drinks.Add(new Drink("Fanta", 95));
            drinks.Add(new Drink("Ásványvíz", 95));

            DisplayDrinks();
        }

        void UpdateCart(Object sender, EventArgs e)
        {
            foreach(DrinkCheckBox checkBox in drinksGroupBox.Controls.OfType<DrinkCheckBox>())
            {
                if (checkout.Exists(x => x.name == checkBox.Name))
                {
                    if (!checkBox.Checked) checkout.RemoveAt(checkout.FindIndex(x => x.name == checkBox.Name));
                }
                else if (checkBox.Checked) checkout.Add(new Drink(checkBox.Name, checkBox.drinkPrice));
            }
            bindingSource.ResetBindings(false);
        }

        void DisplayDrinks()
        {
            drinksGroupBox.Controls.Clear();
            for (int i = 0; i < drinks.Count; i++)
            {
                DrinkCheckBox checkBox = new DrinkCheckBox() { Text = drinks[i].name+", "+ drinks[i].price + " RSD", Name = drinks[i].name, drinkPrice = drinks[i].price };
                checkBox.Width = drinksGroupBox.Width - 10;
                checkBox.Location = new Point(drinksGroupBox.Width / 2 - checkBox.Width / 2, (i+1) * 20);
                checkBox.CheckStateChanged += UpdateCart;
                drinksGroupBox.Controls.Add(checkBox);
            }
        }

        private void buttonDrinkListEdit_Click(object sender, EventArgs e)
        {
            using (DrinksControlForm drinksControlForm = new DrinksControlForm(drinks))
            {
                if(drinksControlForm.ShowDialog() == DialogResult.OK)
                {
                    drinks = drinksControlForm.drinks;
                    DisplayDrinks();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DrinkCheckBox checkBox in drinksGroupBox.Controls.OfType<DrinkCheckBox>())
            {
                checkBox.Checked = false;
            }

            checkout.Clear();
            bindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (checkout.Count <= 0)
            {
                MessageBox.Show("Semmi nincs kiválasztva!");
                return;
            }

            if (!groupBox2.Controls.OfType<RadioButton>().ToList().Exists(x => x.Checked))
            {
                MessageBox.Show("Asztal nincs választva!");
                return;
            }

            if(deleteOldReceit.Checked) richTextBox1.Clear();

            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.SelectionFont = new Font("Segoe", 15);
            richTextBox1.SelectedText = "\n\nItalok\n";

            richTextBox1.SelectedText = String.Join('\n', checkout.Select(x => x.name + " - " + x.price + " RSD"));

            richTextBox1.SelectionFont = new Font("Segoe", 12);
            richTextBox1.SelectedText = "\n\n" + groupBox2.Controls.OfType<RadioButton>().ToList().Find(x => x.Checked).Text;

            richTextBox1.SelectionFont = new Font("Segoe", 13);
            richTextBox1.SelectedText = "\n\nVégső ár: " + checkout.Sum(x => x.price) + " RSD";

            checkout.Sum(x => x.price);
        }
    }

    public class Drink
    {
        public string name;
        public int price;

        public Drink(string _name, int _price)
        {
            name = _name;
            price = _price;
        }

        public override string ToString()
        {
            return name + " | " + price.ToString() + " RSD";
        }
    }

    public class DrinkCheckBox : CheckBox
    {
        public int drinkPrice;

        public override string ToString()
        {
            return Text;
        }
    }
}

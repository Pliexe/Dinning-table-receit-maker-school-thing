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
                    
                    if (!checkBox.Checked) checkout.RemoveAll(x => x.name == checkBox.Name);
                    else
                    {
                        int count = checkout.FindAll(x => x.name == checkBox.Name).Count;
                        if (count > checkBox.numericUp.Value)
                        {
                            int removed = count - (int)checkBox.numericUp.Value;

                            for (int i = 0; i < removed; i++) checkout.RemoveAt(checkout.FindIndex(x => x.name == checkBox.Name));
                        }
                        else if (count < checkBox.numericUp.Value)
                        {
                            int add = (int)checkBox.numericUp.Value - count;

                            for (int i = 0; i < add; i++) checkout.Add(new Drink(checkBox.Name, checkBox.drinkPrice));
                        }
                    }
                }
                else if (checkBox.Checked)
                    if(checkBox.numericUp.Value > 0)
                        for (int i = 0; i < checkBox.numericUp.Value; i++) checkout.Add(new Drink(checkBox.Name, checkBox.drinkPrice));
            }
            bindingSource.ResetBindings(false);
        }

        void DisplayDrinks()
        {
            drinksGroupBox.Controls.Clear();
            for (int i = 0; i < drinks.Count; i++)
            {
                int checkBoxWidth = drinksGroupBox.Width / 2 - 10;
                NumericUpDown numeric = new NumericUpDown { Location = new Point(checkBoxWidth + 10, (i + 1) * 20), Width = 100 };
                numeric.ValueChanged += UpdateCart;
                DrinkCheckBox checkBox = new DrinkCheckBox() {
                    Location = new Point(drinksGroupBox.Width / 2 - checkBoxWidth, (i+1) * 20),
                    Width = checkBoxWidth,
                    Text = drinks[i].name + ", " + drinks[i].price + " RSD", Name = drinks[i].name,
                    drinkPrice = drinks[i].price,
                    numericUp = numeric };
                checkBox.CheckStateChanged += UpdateCart;

                drinksGroupBox.Controls.Add(checkBox);
                drinksGroupBox.Controls.Add(numeric);
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
        public NumericUpDown numericUp;

        public override string ToString()
        {
            return Text;
        }
    }

    public class CheckoutItem
    {
        public string name;
        public int price;
        public int times = 1;
    }
}

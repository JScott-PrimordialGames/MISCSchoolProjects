using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store store = new Store();

        BindingSource carListBinding = new BindingSource();
        BindingSource ShoppingListBinging = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            SetBindings();
        }


        private void SetBindings()
        {
            carListBinding.DataSource = store.CarList;
            listBox1.DataSource = carListBinding;
            listBox1.DisplayMember = "Display";
            //listBox1.ValueMember = "Display";

            ShoppingListBinging.DataSource = store.ShoppingList;
            listBox2.DataSource = ShoppingListBinging;
            listBox2.DisplayMember = "Display";
            //listBox2.ValueMember = "Display";
        }

        private void CreateCar_Click(object sender, EventArgs e)
        {
            Car newCar = new Car();
            int year;
            Decimal price;
            newCar.Make = textBox1.Text;
            newCar.Color = textBox2.Text;
            newCar.Model = textBox3.Text;
            if(!int.TryParse(textBox4.Text, out year))
            {
                MessageBox.Show("Please enter only number" , "Error, invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                newCar.Year = year;
            }
            if(!Decimal.TryParse(textBox5.Text, out price))
            {
                MessageBox.Show("Please enter only number", "Error, invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                newCar.Price = price;
            }

            store.CarList.Add(newCar);

            carListBinding.ResetBindings(false);

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            store.ShoppingList.Add((Car)listBox1.SelectedItem);

            ShoppingListBinging.ResetBindings(false);
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            decimal total = store.checkout();
            TotalPrice.Text = total.ToString();
        }
    }
}

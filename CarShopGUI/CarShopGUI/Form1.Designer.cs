using CarClassLibrary;
using System.Windows.Forms;

namespace CarShopGUI
{
    partial class Form1
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
            this.CreateACar = new System.Windows.Forms.GroupBox();
            this.CreateCar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Make = new System.Windows.Forms.Label();
            this.CarInventory = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ShoppingCart = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AddToCart = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.TotalCost = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.CreateACar.SuspendLayout();
            this.CarInventory.SuspendLayout();
            this.ShoppingCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateACar
            // 
            this.CreateACar.Controls.Add(this.CreateCar);
            this.CreateACar.Controls.Add(this.textBox5);
            this.CreateACar.Controls.Add(this.textBox4);
            this.CreateACar.Controls.Add(this.textBox3);
            this.CreateACar.Controls.Add(this.textBox2);
            this.CreateACar.Controls.Add(this.textBox1);
            this.CreateACar.Controls.Add(this.Year);
            this.CreateACar.Controls.Add(this.Color);
            this.CreateACar.Controls.Add(this.Price);
            this.CreateACar.Controls.Add(this.Model);
            this.CreateACar.Controls.Add(this.Make);
            this.CreateACar.Location = new System.Drawing.Point(32, 36);
            this.CreateACar.Name = "CreateACar";
            this.CreateACar.Size = new System.Drawing.Size(200, 167);
            this.CreateACar.TabIndex = 0;
            this.CreateACar.TabStop = false;
            this.CreateACar.Text = "Create a Car:";
            // 
            // CreateCar
            // 
            this.CreateCar.Location = new System.Drawing.Point(48, 134);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(75, 23);
            this.CreateCar.TabIndex = 10;
            this.CreateCar.Text = "Create Car";
            this.CreateCar.UseVisualStyleBackColor = true;
            this.CreateCar.UseWaitCursor = true;
            this.CreateCar.Click += new System.EventHandler(this.CreateCar_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(47, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.UseWaitCursor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(48, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.UseWaitCursor = true;
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(7, 88);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(32, 13);
            this.Year.TabIndex = 4;
            this.Year.Text = "Year:";
            this.Year.UseWaitCursor = true;
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Location = new System.Drawing.Point(7, 43);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(34, 13);
            this.Color.TabIndex = 3;
            this.Color.Text = "Color:";
            this.Color.UseWaitCursor = true;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(7, 111);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(34, 13);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price:";
            this.Price.UseWaitCursor = true;
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(7, 65);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 1;
            this.Model.Text = "Model";
            this.Model.UseWaitCursor = true;
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Location = new System.Drawing.Point(7, 20);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(37, 13);
            this.Make.TabIndex = 0;
            this.Make.Text = "Make:";
            this.Make.UseWaitCursor = true;
            // 
            // CarInventory
            // 
            this.CarInventory.Controls.Add(this.listBox1);
            this.CarInventory.Location = new System.Drawing.Point(277, 36);
            this.CarInventory.Name = "CarInventory";
            this.CarInventory.Size = new System.Drawing.Size(200, 318);
            this.CarInventory.TabIndex = 1;
            this.CarInventory.TabStop = false;
            this.CarInventory.Text = "Car Inventroy";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 290);
            this.listBox1.TabIndex = 0;
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.Controls.Add(this.listBox2);
            this.ShoppingCart.Location = new System.Drawing.Point(579, 36);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Size = new System.Drawing.Size(200, 318);
            this.ShoppingCart.TabIndex = 2;
            this.ShoppingCart.TabStop = false;
            this.ShoppingCart.Text = "Shopping Cart";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 14);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 290);
            this.listBox2.TabIndex = 1;
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(483, 170);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(90, 23);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add to Cart ->";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(641, 360);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(75, 23);
            this.Checkout.TabIndex = 4;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(585, 413);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(58, 13);
            this.TotalCost.TabIndex = 5;
            this.TotalCost.Text = "Total Cost:";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(649, 413);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(0, 13);
            this.TotalPrice.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.CarInventory);
            this.Controls.Add(this.CreateACar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CreateACar.ResumeLayout(false);
            this.CreateACar.PerformLayout();
            this.CarInventory.ResumeLayout(false);
            this.ShoppingCart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CreateACar;
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Make;
        private System.Windows.Forms.GroupBox CarInventory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox ShoppingCart;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label TotalPrice;
    }
}


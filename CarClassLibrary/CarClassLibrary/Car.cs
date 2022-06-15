using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace CarClassLibrary
{
    public class Car
    {
        public String Make { get; set; }

        public String Color { get; set; }

        public String Model { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }

        public Car(String make, String color, String model, int year, decimal price)
        {
            Make = make;
            Color = color;
            Model = model;
            Year = year;
            Price = price;
        }

        public Car()
        {
            Make = "Placeholder";
            Color = "White";
            Model = "Placeholder";
            Year = 2020;
            Price = 0;
        }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2} {3} ${4}", Make, Color, Model, Year, Price);
            }
        }
    }
}

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
using TextFileDataAccessDemo;

namespace ProjectIO
{
    public partial class Form1 : Form
    {

        public string FilePath = @"C:\demos\people.txt";
        List<Person> people;
        List<String> lines;

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
            lines = File.ReadAllLines(FilePath).ToList();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.firstName = TXB_FirstName.Text;
            p.lastName = TXB_LastName.Text;
            p.Url = TXB_URL.Text;
            people.Add(p);
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            List<string> outputLines = new List<string>();
            foreach (Person p in people)
            {
                outputLines.Add(p.firstName + "," + p.lastName + "," + p.Url + "\n");
            }
            File.WriteAllLines(FilePath, outputLines);
        }

        private void BTN_Load_Click(object sender, EventArgs e)
        {
            lines = File.ReadAllLines(FilePath).ToList();
            foreach (string line in lines)
            {
                string[] entries = line.Split(',');
                if (entries.Length == 3)
                {
                    Person p = new Person();
                    p.firstName = entries[0];
                    p.lastName = entries[1];
                    p.Url = entries[2];
                    people.Add(p);
                }
                else if (entries.Length < 3)
                {
                    Person p = new Person();
                    p.firstName = "Error";
                    p.lastName = "";
                    p.Url = "There was less than three items";
                    people.Add(p);
                }
                else if (entries.Length > 3)
                {
                    Person p = new Person();
                    p.firstName = "Error";
                    p.lastName = "";
                    p.Url = "There was more than three items";
                    people.Add(p);
                }
            }
        }
    }
}

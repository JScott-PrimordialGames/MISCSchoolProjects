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
        BindingSource PeopleList = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            people = new List<Person>();
            lines = File.ReadAllLines(FilePath).ToList();
            SetBindings();
        }

        private void SetBindings()
        {
            PeopleList.DataSource = people;
            listBox1.DataSource = PeopleList;
            listBox1.DisplayMember = "Display";
            //listBox1.ValueMember = "Display";
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            if(TXB_FirstName.Text.Length > 0)
            {
                p.firstName = TXB_FirstName.Text;
            }
            else
            {
                string text = "Error: Please enter a First Name";
                MessageBox.Show(text);
                return;
            }


            if (TXB_LastName.Text.Length > 0)
            {
                p.lastName = TXB_LastName.Text;
            }
            else
            {
                string text = "Error: Please enter a Last Name";
                MessageBox.Show(text);
                return;
            }


            if (TXB_URL.Text.Length > 0)
            {
                p.Url = TXB_URL.Text;
            }
            else
            {
                string text = "Error: Please enter a URL";
                MessageBox.Show(text);
                return;
            }
            people.Add(p);
            PeopleList.ResetBindings(false);
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
               PeopleList.ResetBindings(false);
            }
        }
    }
}

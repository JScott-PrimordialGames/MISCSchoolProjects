using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\demos\test.txt";

            List<Person> people = new List<Person>();
            List<String> lines = File.ReadAllLines(filepath).ToList();

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

            List<string> outputLines = new List<string>();
            Console.WriteLine("Here is a list of the people I have.");
            foreach(Person p in people)
            {
                Console.WriteLine("First Name: " + p.firstName + " Last Name: " + p.lastName + " URL: " + p.Url);

                outputLines.Add("First Name: " + p.firstName + " Last Name: " + p.lastName + " URL: " + p.Url + "\n");
            }

            string outPath = @"C:\demos\peopleOut.txt";
            File.WriteAllLines(outPath, outputLines);

            Console.ReadLine();
            /*
            List<string> lines = File.ReadAllLines(filepath).ToList();

            lines.Add("Steve, Jobs, www.apple.com");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(filepath, lines);
         
            Console.ReadLine();
            */
        }
    }
}

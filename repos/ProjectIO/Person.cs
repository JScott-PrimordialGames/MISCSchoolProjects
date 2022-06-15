using System;
using System.Collections.Generic;
using System.Text;

namespace TextFileDataAccessDemo
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Url { get; set; }

        public string Display
        {
            get
            {
                return string.Format("First Name: {0} | Last Name: {1} | URL: {2}", firstName, lastName, Url);
            }
        }
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public class SuperHeroClass
    {
        public String name { get; set; }
        public List<String> skills { get; set; }
        public List<String> officeLocations { get; set; }
        public DateTime birth { get; set; }
        public DateTime dayFound { get; set; }
        public DateTime fate { get; set; }
        public String vehicle { get; set; }
        public int yearsActive { get; set; }
        public int corruption { get; set; }
        public int speed { get; set; }
        public int stamina { get; set; }
        public int strength { get; set; }

        public void SetSuperHeroclass(String Name, List<String> Skills, List<String> Offices, DateTime Birth, DateTime DayFound, DateTime Fate, String Vehicle, int YearsActive, int Corruption, int Speed, int Stamina, int Strength)
        {
            name = Name;
            skills = Skills;
            officeLocations = Offices;
            birth = Birth;
            dayFound = DayFound;
            fate = Fate;
            vehicle = Vehicle;
            yearsActive = YearsActive;
            corruption = Corruption;
            speed = Speed;
            stamina = Stamina;
            strength = Strength;

        }

        public string Display
        {
            get
            {
                return name;
            }
        }

        public String printArray(List<String> input)
        {
            String output = string.Join(" , ", input);

            return output;
        }

    }
}

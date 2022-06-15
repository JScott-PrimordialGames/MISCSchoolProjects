using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    public class SuperHeroList
    {
        public List<SuperHeroClass> ListOfHeroes { get; set; }

        public SuperHeroList()
        {
            ListOfHeroes = new List<SuperHeroClass>();
        }

        public SuperHeroClass GetHero(int index)
        {
            return ListOfHeroes[index];
        }
    }
}

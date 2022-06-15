using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHero
{
    public partial class Form2 : Form
    {
        private Form1 parent;
        private SuperHeroList HeroListArray;
        BindingSource HerosListBinding = new BindingSource();

        public Form2(SuperHeroList heroList, Form1 Parent)
        {
            InitializeComponent();
            HeroListArray = heroList;
            parent = Parent;
            SetBindings();
        }

        private void SetBindings()
        {
            HerosListBinding.DataSource = HeroListArray.ListOfHeroes;
            LB_Heros.DataSource = HerosListBinding;
            LB_Heros.DisplayMember = "Display";
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            parent.Show();
            parent.ResetBoard();
            Close();
        }

        private void LB_Heros_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuperHeroClass CurrentHero = HeroListArray.GetHero(LB_Heros.SelectedIndex);

            TXB_Profile.Text = CurrentHero.name + " has these powers: " + CurrentHero.printArray(CurrentHero.skills) + ". They have offices in: " + CurrentHero.printArray(CurrentHero.officeLocations) + ". Prefered method of travel is " + CurrentHero.vehicle + ". Their current level of corrupton is: " + int.Parse(CurrentHero.corruption.ToString()) + " Strength: " + int.Parse(CurrentHero.strength.ToString()) + "%, Speed: " + int.Parse(CurrentHero.speed.ToString()) + "%, Stamina: " + int.Parse(CurrentHero.stamina.ToString()) + "%"; 
        }
    }
}

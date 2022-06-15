using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHero
{
    public partial class Form1 : Form
    {

        SuperHeroList HeroListArray = new SuperHeroList();

        public Form1()
        {
            InitializeComponent();
            LBL_Strength.Text = "0";
            LBL_Stamina.Text = "0";
            LBL_Strength.Text = "0";
        }


        public void ResetBoard()
        {
            TXB_Name.Clear();
            resetSkills();
            LB_Cities.SelectedIndex = -1;
            resetTravel();
            NUD_YearsActive.Value = 0;
            TB_Corruption.Value = 0;
            HSB_Speed.Value = 0;
            HSB_Stamina.Value = 0;
            HSB_Strenght.Value = 0;
            LBL_Strength.Text = "0";
            LBL_Speed.Text = "0";
            LBL_Stamina.Text = "0";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showError()
        {
            MessageBox.Show("Oops, looks like you missed something, check again.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTN_MakeMe_Click(object sender, EventArgs e)
        {
            if (TXB_Name.Text == null || GetSkills() == null || GetOffices() == null)
            {
                showError();
                return;
            }

            String name = TXB_Name.Text;
            List<String> skills = GetSkills();
            List<String> officeLocations = GetOffices();
            DateTime birth = DTP_Birth.Value;
            DateTime dayFound = DTP_PowersFound.Value;
            DateTime fate = DTP_FaitfulDay.Value;
            String vehicle = "None";
            if (RB_Jetpack.Checked)
                vehicle = "Jetpack";
            else if (RB_Hoverbike.Checked)
                vehicle = "Hoverbike";
            else if (RB_ArmoredCar.Checked)
                vehicle = "Armored Car";
            else if (RB_PowerAromr.Checked)
                vehicle = "Power Armor";
            else if (RB_Teleporation.Checked)
                vehicle = "Teleportation";
            int yearsActive = Decimal.ToInt32(NUD_YearsActive.Value);
            int corruption = TB_Corruption.Value;
            int speed = HSB_Speed.Value;
            int stamina = HSB_Stamina.Value;
            int strength = HSB_Strenght.Value;


            SuperHeroClass NewHero = new SuperHeroClass();
            NewHero.SetSuperHeroclass(name, skills, officeLocations, birth, dayFound, fate, vehicle, yearsActive, corruption, speed, stamina, strength);

            HeroListArray.ListOfHeroes.Add(NewHero);

            Form2 HeroList = new Form2(HeroListArray, this);
            this.Hide();
            HeroList.Show();

        }

        private void HSB_Strenght_Scroll(object sender, ScrollEventArgs e)
        {
            LBL_Strength.Text = HSB_Strenght.Value.ToString();
        }

        private void HSB_Stamina_Scroll(object sender, ScrollEventArgs e)
        {
            LBL_Stamina.Text = HSB_Stamina.Value.ToString();
        }

        private void HSB_Speed_Scroll(object sender, ScrollEventArgs e)
        {
            LBL_Speed.Text = HSB_Speed.Value.ToString();
        }

        private void resetSkills()
        {
            CB_SuperStrenght.Checked = false;
            CB_Flight.Checked = false;
            CB_XrayVision.Checked = false;
            CB_Invisibility.Checked = false;
            CB_Telepathy.Checked = false;
            CB_Luck.Checked = false;
            CB_EnergyFields.Checked = false;
            CB_Pyrokenesis.Checked = false;
            CB_WaterBreathing.Checked = false;
            CB_ChronoShifter.Checked = false;
        }

        private void resetTravel()
        {
            RB_ArmoredCar.Checked = false;
            RB_Hoverbike.Checked = false;
            RB_Jetpack.Checked = false;
            RB_PowerAromr.Checked = false;
            RB_Teleporation.Checked = false;
        }

        private List<String> GetSkills()
        {
            List<String> Skills = new List<string>();

            if (CB_SuperStrenght.Checked)
                Skills.Add("Super Strength");
            if (CB_Flight.Checked)
                Skills.Add("Flight");
            if (CB_XrayVision.Checked)
                Skills.Add("xRay Vision");
            if (CB_Invisibility.Checked)
                Skills.Add("Invisibility");
            if (CB_Telepathy.Checked)
                Skills.Add("Telepathy");
            if (CB_Luck.Checked)
                Skills.Add("Luck Manipulation");
            if (CB_EnergyFields.Checked)
                Skills.Add("Energy Manipulation");
            if (CB_Pyrokenesis.Checked)
                Skills.Add("Pyrokenesis");
            if (CB_WaterBreathing.Checked)
                Skills.Add("Water Breathing");
            if (CB_ChronoShifter.Checked)
                Skills.Add("Time Controle");

            return Skills;
        }

        private List<String> GetOffices()
        {
            List<String> Offices = new List<string>();
            Offices.Add(LB_Cities.SelectedItem.ToString());
            return Offices;
        }

        private void HSB_Speed_ValueChanged(object sender, EventArgs e)
        {
            if (HSB_Strenght.Value + HSB_Stamina.Value + HSB_Speed.Value >= 100)
                HSB_Speed.Maximum = HSB_Speed.Value;
            else
                HSB_Speed.Maximum = 100 - (HSB_Strenght.Value + HSB_Stamina.Value);
        }

        private void HSB_Stamina_ValueChanged(object sender, EventArgs e)
        {
            if (HSB_Strenght.Value + HSB_Stamina.Value + HSB_Speed.Value >= 100)
                HSB_Stamina.Maximum = HSB_Stamina.Value;
            else
                HSB_Stamina.Maximum = 100 - (HSB_Strenght.Value + HSB_Speed.Value);
        }

        private void HSB_Strenght_ValueChanged(object sender, EventArgs e)
        {
            if (HSB_Strenght.Value + HSB_Stamina.Value + HSB_Speed.Value >= 100)
                HSB_Strenght.Maximum = HSB_Strenght.Value;
            else
                HSB_Strenght.Maximum = 100 - (HSB_Speed.Value + HSB_Stamina.Value);
        }
    }
}

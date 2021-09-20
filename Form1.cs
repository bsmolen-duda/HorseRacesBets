using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorsesBets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Add_horse_Click(object sender, EventArgs e)
        {

            // Opens a new window, where the user can write some notes.
           
            Form newHorse = new NewHorse();
            newHorse.Show();
            
        }

        private void NewCustomer_Click(object sender, EventArgs e)
        {

            // Opens a new window, where the user can write some notes.

            
            Form newCustomer = new NewCustomer();
            newCustomer.Show();
        }

        private void RandomRace_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.GenerateRace();
        }

        private void AddBet_Click(object sender, EventArgs e)
        {
            Form newBet = new NewBet();
            newBet.Show();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.Check(RaceIDBox.Text);
        }

        private void FinishRace_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.FinishRace(RaceIDBox.Text);
        }
    }
}

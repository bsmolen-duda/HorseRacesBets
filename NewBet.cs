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
    public partial class NewBet : Form
    {
        public NewBet()
        {
            InitializeComponent();
        }

        private void AddNewBet_Click(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.AddBet(CustomerIDBox.Text, ValueBox.Text, RateBox.Text, KindOfBetBox.Text, RaceIDBox.Text, Horse1.Text, Horse2.Text, Horse3.Text);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KindOfBetBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kindOfBet= KindOfBetBox.Text;
            switch(kindOfBet)
            {
                case "Zwyczajny":
                    label8.Visible = false;
                    Horse2.Visible = false;

                    label9.Visible = false;
                    Horse3.Visible = false;
                    break;

                case "Dwójka":
                    label8.Visible = true;
                    Horse2.Visible = true;

                    label9.Visible = false;
                    Horse3.Visible = false;
                    break;

                case "Trójka":
                    label8.Visible = true;
                    Horse2.Visible = true;

                    label9.Visible = true;
                    Horse3.Visible = true;
                    break;
            }

        }
    }
}

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
    public partial class NewHorse : Form
    {
        public NewHorse()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DatabaseManager dbmanager = new DatabaseManager();
            dbmanager.AddHorse(NameBox.Text, YearBox.Text, VictoriesBox.Text, CoachBox.Text, JockeyBox.Text);
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

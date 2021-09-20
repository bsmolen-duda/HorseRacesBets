using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace HorsesBets
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            DatabaseManager dbManager = new DatabaseManager();
            dbManager.AddCustomer(IDBox.Text, NameBox.Text, SurnameBox.Text, BalanceBox.Text);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nowhere
{
    public partial class TownOfNowhere : Form
    {
        public TownOfNowhere()
        {
            InitializeComponent();
            new controls(this).Show();
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TownOfNowhere_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Are you sure you want to quit?", "Rev pls", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                Application.Exit();

            }*/

            Properties.Settings.Default.wellness = wellnessValTB.Text;
            Properties.Settings.Default.attitude = attitudeValTB.Text;
            Properties.Settings.Default.reputation = repValTB.Text;
            Properties.Settings.Default.noah = noahValTB.Text;
            Properties.Settings.Default.hordiculture = hordicultureValTB.Text;
            Properties.Settings.Default.sexy = sexyValTB.Text;
            Properties.Settings.Default.smart = smartValTB.Text;
            Properties.Settings.Default.bibe = bibeValTB.Text;
            Properties.Settings.Default.hunger = hungerValTB.Text;
            Properties.Settings.Default.money = moneyValTB.Text;
            Properties.Settings.Default.Save();
        }

        private void TownOfNowhere_Load(object sender, EventArgs e)
        {
            wellnessValTB.Text = Properties.Settings.Default.wellness;
            attitudeValTB.Text = Properties.Settings.Default.attitude;
            repValTB.Text = Properties.Settings.Default.reputation;
            noahValTB.Text = Properties.Settings.Default.noah;
            hordicultureValTB.Text = Properties.Settings.Default.hordiculture;
            sexyValTB.Text = Properties.Settings.Default.sexy;
            smartValTB.Text = Properties.Settings.Default.smart;
            bibeValTB.Text = Properties.Settings.Default.bibe;
            hungerValTB.Text = Properties.Settings.Default.hunger;
            moneyValTB.Text = Properties.Settings.Default.money;
        }
    }
}

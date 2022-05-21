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
    public partial class controls : Form
    {


        TownOfNowhere nowhere;
        

        public controls(TownOfNowhere gameWindow)
        {
            InitializeComponent();
            nowhere = gameWindow;

            wellnessTB.Text = Properties.Settings.Default.wellness;
            attitudeTB.Text = Properties.Settings.Default.attitude;
            repTB.Text = Properties.Settings.Default.reputation;
            noahTB.Text = Properties.Settings.Default.noah;
            hordicultureTB.Text = Properties.Settings.Default.hordiculture;
            sexyTB.Text = Properties.Settings.Default.sexy;
            smartTB.Text = Properties.Settings.Default.smart;
            bibeTB.Text = Properties.Settings.Default.bibe;
            hungerTB.Text = Properties.Settings.Default.hunger;
            moneyTB.Text = Properties.Settings.Default.money;

            wellnessTB.TextChanged += new EventHandler(wellnessTB_TextChanged);
            attitudeTB.TextChanged += new EventHandler(attitudeTB_TextChanged);
            repTB.TextChanged += new EventHandler(repTB_TextChanged);
            noahTB.TextChanged += new EventHandler(noahTB_TextChanged);
            hordicultureTB.TextChanged += new EventHandler(hordicultureTB_TextChanged);
            sexyTB.TextChanged += new EventHandler(sexyTB_TextChanged);
            smartTB.TextChanged += new EventHandler(smartTB_TextChanged);
            bibeTB.TextChanged += new EventHandler(bibeTB_TextChanged);
            hungerTB.TextChanged += new EventHandler(hungerTB_TextChanged);
            moneyTB.TextChanged += new EventHandler(moneyTB_TextChanged);

            locationsBox.SelectedIndexChanged += new EventHandler(LocationChanged);
        }

        void LocationChanged(object sender, EventArgs e)
        {
            if (locationsBox.SelectedIndex == 0)
            {
                nowhere.areaBox.Image = Properties.Resources.church;
            }
            else if (locationsBox.SelectedIndex == 4)
                nowhere.areaBox.Image = Properties.Resources.outsideStarbucks;
        }

        void wellnessTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.wellnessValTB.Text = wellnessTB.Text;
        }
        
        void attitudeTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.attitudeValTB.Text = attitudeTB.Text;
        }
        
        void repTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.repValTB.Text = repTB.Text;
        }
        
        void noahTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.noahValTB.Text = noahTB.Text;
        }
        
        void hordicultureTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.hordicultureValTB.Text = hordicultureTB.Text;
        }
        
        void sexyTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.sexyValTB.Text = sexyTB.Text;
        }
        
        void smartTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.smartValTB.Text = smartTB.Text;
        }
        
        void bibeTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.bibeValTB.Text = bibeTB.Text;
        }
        
        void hungerTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.hungerValTB.Text = hungerTB.Text;
        }
        
        void moneyTB_TextChanged(object sender, EventArgs e)
        {
            nowhere.moneyValTB.Text = moneyTB.Text;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.wellness = wellnessTB.Text;
            Properties.Settings.Default.attitude = attitudeTB.Text;
            Properties.Settings.Default.reputation = repTB.Text;
            Properties.Settings.Default.noah = noahTB.Text;
            Properties.Settings.Default.hordiculture = hordicultureTB.Text;
            Properties.Settings.Default.sexy = sexyTB.Text;
            Properties.Settings.Default.smart = smartTB.Text;
            Properties.Settings.Default.bibe = bibeTB.Text;
            Properties.Settings.Default.hunger = hungerTB.Text;
            Properties.Settings.Default.money = moneyTB.Text;
            Properties.Settings.Default.Save();
        }







        private void controls_FormClosing(object sender, FormClosingEventArgs e)
        {


            SaveSettings();


        }
    }
}

using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Adventure
{
    public partial class Adventure : Form
    {

        public Player _player;

        public Adventure()
        {
            InitializeComponent();

// Giving the player a set constructor of values. 
            _player = new Player(10,10,5,0,0);
            
            // Text for the given Player stats.

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

                
        }

        private void Adventure_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Adventure_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}

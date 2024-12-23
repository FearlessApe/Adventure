using Engine;

namespace Adventure
{
    public partial class Adventure : Form
    {

        private Player _player;

        public Adventure()
        {
            InitializeComponent();

            _player = new Player();

            _player.CurrentHitPoints = 10;
            _player.MaxHitpoitns = 10;
            _player.Gold = 5;
            _player.ExperiencePoints = 0;
            _player.Level = 0;
            
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

namespace SonusMininma
{
    public partial class MainApplication : Form
    {
        System.Media.SoundPlayer player = new();
        public MainApplication()
        {
            InitializeComponent();
            player.SoundLocation = Soundpicker.soundName; 
            this.pictureBox1.Image = Soundpicker.ps;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Soundpicker sp = new();
            this.Hide();
            sp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

    }
}
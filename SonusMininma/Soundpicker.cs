using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonusMininma
{
    public partial class Soundpicker : Form
    {
        public static Image? ps; 
        public Soundpicker()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainApplication ma = new();
            this.Hide();
            ma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    pictureBox1.Image = Image.FromFile(file);
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                }
                catch(IOException)
                {

                }
            }
            Console.WriteLine(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    this.button2.Text = file; 
                 
                }
                catch (IOException) { }
            }
            Console.WriteLine(res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ps = pictureBox1.Image;
            MainApplication ma = new();
            this.Hide();
            ma.Show();
        }
    }
}

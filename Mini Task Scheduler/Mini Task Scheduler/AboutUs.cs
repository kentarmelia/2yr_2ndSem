using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_Task_Scheduler
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            var posi = this.PointToScreen(panel1.Location);
            posi = pictureBox1.PointToClient(posi);
            panel1.Parent = pictureBox1;
            panel1.Location = posi;
            panel1.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

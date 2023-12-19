using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAppLOLGG.Pages
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            MovePanel(buttonAddFilm);
            userControlEditFilm1.Hide();
            userControlSeans1.Hide();
            userControlWatchFilms1.Hide();
            userControlWatchBron1.Hide();
            userControlBronAdd1.Hide();
            userControlBronEdit1.Hide();
            userControlAddFilms1.Show();
        }

        private void buttonEditFilm_Click(object sender, EventArgs e)
        {
            MovePanel(buttonEditFilm);
            userControlAddFilms1.Hide();
            userControlWatchFilms1.Hide();
            userControlSeans1.Hide();
            userControlWatchBron1.Hide();
            userControlBronEdit1.Hide();
            userControlEditFilm1.Show();
            userControlBronAdd1.Hide();
        }

        private void buttonAddBron_Click(object sender, EventArgs e)
        {
            MovePanel(buttonAddBron);
            userControlAddFilms1.Hide();
            userControlWatchFilms1.Hide();
            userControlSeans1.Hide();
            userControlWatchBron1.Hide();
            userControlEditFilm1.Hide();
            userControlBronEdit1.Hide();
            userControlBronAdd1.Show();
        }

        private void buttonEditBron_Click(object sender, EventArgs e)
        {
            MovePanel(buttonEditBron);
            userControlAddFilms1.Hide();
            userControlWatchFilms1.Hide();
            userControlSeans1.Hide();
            userControlWatchBron1.Hide();
            userControlEditFilm1.Hide();
            userControlBronAdd1.Hide();
            userControlBronEdit1.Show();
        }

        private void linkLabel1LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void userControlAddFilms1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovePanel(buttonWatchFilm);
            userControlAddFilms1.Hide();
            userControlEditFilm1.Hide();
            userControlSeans1.Hide();
            userControlWatchBron1.Hide();
            userControlBronAdd1.Hide();
            userControlBronEdit1.Hide();
            userControlWatchFilms1.Show();
        }

        private void buttonWatchBron_Click(object sender, EventArgs e)
        {
            MovePanel(buttonWatchBron);
            userControlAddFilms1.Hide();
            userControlEditFilm1.Hide();
            userControlSeans1.Hide();
            userControlWatchFilms1.Hide();
            userControlBronEdit1.Hide();
            userControlBronAdd1.Hide();
            userControlWatchBron1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MovePanel(button1);
            userControlAddFilms1.Hide();
            userControlEditFilm1.Hide();
            userControlWatchFilms1.Hide();
            userControlBronAdd1.Hide();
            userControlBronEdit1.Hide();
            userControlWatchBron1.Hide();
            userControlSeans1.Show();
        }
    }
}

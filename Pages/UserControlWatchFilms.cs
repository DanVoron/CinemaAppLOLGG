using CinemaAppLOLGG.Classes;
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
    public partial class UserControlWatchFilms : UserControl
    {
        Connect conn = new Connect();
        public UserControlWatchFilms()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable("select * from film");
        }


        private void UserControlWatchFilms_Load(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable("select * from film");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable($"select * from film where Moviename like '%{textBox1.Text}%'");
        }
    }
}

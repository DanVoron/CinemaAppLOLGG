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
    public partial class UserControlWatchBron : UserControl
    {
        Connect conn = new Connect();
        public UserControlWatchBron()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable("select * from Position where STATUS_P = 'freent'");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable($"select * from Position where ID_POSITION like '%{textBox1.Text}%'");
        }

        private void UserControlWatchBron_Load(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable("select * from Position where STATUS_P = 'freent'");
        }
    }
}

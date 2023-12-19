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
    public partial class UserControlBronEdit : UserControl
    {
        Connect conn = new Connect();
        public UserControlBronEdit()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.ProverkaSdachi($"update POSITION set STATUS_P='free' where ID_POSITION = '{id}'");
            dataGridView1.DataSource = conn.getTable($"select * from POSITION where ID_HALL_P = '{IDzala}' and STATUS_P='freent'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewFilms.DataSource = conn.getTable($"select * from SEANS where Nazvanie_filma = '{comboBox1.SelectedValue.ToString()}'");
            dataGridViewFilms.DataSource = conn.getTable($"select * from SEANS where Nazvanie_filma = '{comboBox1.SelectedValue.ToString()}'");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.getTable($"select * from POSITION where ID_HALL_P = '{IDzala}' and STATUS_P='freent'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "MovieName";
            comboBox1.ValueMember = "MovieName";
            comboBox1.DataSource = conn.getTable("select * from film");
        }

        private void UserControlBronEdit_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "MovieName";
            comboBox1.ValueMember = "MovieName";
            comboBox1.DataSource = conn.getTable("select * from film");
            dataGridViewFilms.DataSource = conn.getTable($"select * from SEANS where Nazvanie_filma = '{comboBox1.SelectedValue.ToString()}'");
        }
        string IDzala = "";
        string IDSessia = "";
        private void dataGridViewFilms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewFilms.Rows[e.RowIndex];
                IDzala = row.Cells[2].Value.ToString();
                IDSessia = row.Cells[0].Value.ToString();
            }
        }
        string id = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.ProverkaSdachi($"delete  from seans where ID_SESSION = '{IDSessia}'"))
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Ошбика");
            }
        }
    }
}

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
    public partial class UserControlSeans : UserControl
    {
        Connect conn = new Connect();
        public UserControlSeans()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxFilm.DisplayMember = "MovieName";
            comboBoxFilm.ValueMember = "MovieName";
            comboBoxFilm.DataSource = conn.getTable("select * from film");

            comboBoxHall.DisplayMember = "ID_HALL";
            comboBoxHall.ValueMember = "ID_HALL";
            comboBoxHall.DataSource = conn.getTable("select * from hall");
        }

        private void buttonSeansAdd_Click(object sender, EventArgs e)
        {
            if (conn.ProverkaSdachi($"insert into seans (Nazvanie_filma,ID_HALL_S,DATA_S,Price) values ('{comboBoxFilm.SelectedValue.ToString()}','{comboBoxHall.SelectedValue.ToString()}','{textBoxIn.Text}','{textBoxPrice.Text}')"))
            {
                MessageBox.Show("Получилось");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonSeansEdit_Click(object sender, EventArgs e)
        {
            if (conn.ProverkaSdachi($"Update seans set  ID_FILMA = '{comboBoxFilm.SelectedValue.ToString()}', ID_HALL_S ='{comboBoxHall.SelectedValue.ToString()}',DATA_S='{textBoxIn.Text}',Price='{textBoxPrice.Text}' where ID_FILMA = '{comboBoxFilm.SelectedItem.ToString()}'"))
            {
                MessageBox.Show("Получилось");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonSeansDel_Click(object sender, EventArgs e)
        {
            if (conn.ProverkaSdachi($"delete from seans where DATA_S = '{textBoxIn.Text}'"))
            {
                MessageBox.Show("Получилось");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}

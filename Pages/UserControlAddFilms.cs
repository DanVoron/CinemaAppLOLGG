using CinemaAppLOLGG.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAppLOLGG.Pages
{
    public partial class UserControlAddFilms : UserControl
    {
        Connect conn = new Connect();
        public UserControlAddFilms()
        {
            InitializeComponent();
        }
        string imglocation = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation= imglocation;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imglocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            string SqlQuery = $"insert into Film(MovieName,MovieCategory,PosterPriview,Description,Prodolzitelnost) values  ('{textBoxFilmName.Text}','{textBoxFilmCategory.Text}','{images}','{textBoxFilmDescription.Text}','{textBoxFilmTime.Text}')";
            if (conn.ProverkaSdachi(SqlQuery))
            {
                MessageBox.Show("Фильм добавлен");
            }
            else
            {
                MessageBox.Show("Ошбика");
            }
        }
    }
}

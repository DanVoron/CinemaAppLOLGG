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
    public partial class UserControlEditFilm : UserControl
    {
        Connect conn = new Connect();
        public UserControlEditFilm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);

            string SqlQuery = $"UPDATE Film Set  MovieName='{textBoxFilmName.Text}', MovieCategory = '{textBoxFilmCategory.Text}', PosterPriview='{images}',Description='{textBoxFilmDescription.Text}',Prodolzitelnost='{textBoxFilmTime.Text}' where MovieName = '{textBoxFilmName.Text}'";
            if (conn.ProverkaSdachi(SqlQuery))
            {
                MessageBox.Show("Фильм обновлен");
            }
            else
            {
                MessageBox.Show("Ошбика");
            }
        }
        string imglocation = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SqlQuery = $"DELETE FROM Film WHERE MovieName = '{textBoxFilmName.Text}'";
            if (conn.ProverkaSdachi(SqlQuery))
            {
                MessageBox.Show("Фильм удалён");
            }
            else
            {
                MessageBox.Show("Ошбика");
            }
        }
    }
}

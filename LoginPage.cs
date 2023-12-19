using CinemaAppLOLGG.Classes;
using CinemaAppLOLGG.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAppLOLGG
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect conn = new Connect();
            string[] wordsToCheck = { "/", "--", "'", "~", "!", "#", "$", "%", "^", "&", "*", "(", ")", "+", "`", ";", ":", "<", ">", "\\", "|" }; // Массив запрещённых слов/символов от sql иньекций
            if (wordsToCheck.Any(word => textBoxUsername.Text.Contains(word)) || wordsToCheck.Any(word => textBoxPassword.Text.Contains(word)))
            {
                MessageBox.Show("Введенны недопустимые символы");
                return;
            }
            if (textBoxUsername.Text.Length > 0) // проверяем введён ли логин     
            {
                if (textBoxPassword.Text.Length > 0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными         
                    DataTable dt_user = conn.Select($"SELECT * FROM [dbo].[User] WHERE [Username] = '{textBoxUsername.Text}' AND [Password] = '{textBoxUsername.Text}'");
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        FormStart fd = new FormStart();
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        fd.Show();

                    }
                    else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку 
        }
    }
}

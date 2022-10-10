using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CollegStudentDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработка события нажатия на кнопку "Вход".
        private void login_btn_Click(object sender, EventArgs e)
        {
            // Запрос к таблице Authorization.
            string query = "SELECT LoginID FROM Authorization WHERE Login ='" + name_box.Text + "' and LoginPass = '" + pass_box.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            // Объект для выполнения SQL-запроса.
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                // Устанавливаем соединение с БД.
                conn.Open();
                int result = 0;
                result = Convert.ToInt32(cmDB.ExecuteScalar());
                if (result > 1)
                {
                    Menu Win = new Menu(result); // Обращение к форме "Menu", на которую будет совершаться переход.
                    Win.Owner = this;
                    this.Hide();
                    Win.Show(); // Запуск окна "Menu".
                    name_box.Clear(); // Очистка поля - логин.
                    pass_box.Clear(); // Очистка поля - пароль.
                }
                else
                    MessageBox.Show("Возникла ошибка авторизации!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }
        
        // Обработка события нажатия на кнопку "Выход".
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

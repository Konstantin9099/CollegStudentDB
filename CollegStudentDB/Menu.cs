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
    public partial class Menu : Form
    {
        public int ID = 0;
        public Menu(int ID_log)
        {
            InitializeComponent();
            ID = ID_log;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Переход к окну "Profile" (Профиль).
        private void change_profile_btn_Click(object sender, EventArgs e)
        {
            Profile Win = new Profile(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
        // Переход к окну "Teachers" (Преподаватели).
        private void teachers_btn_Click(object sender, EventArgs e)
        {
            Teachers Win = new Teachers(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
        // Переход к окну "LearningGroup" (Учебные группы).
        private void groups_btn_Click(object sender, EventArgs e)
        {
            LearningGroup Win = new LearningGroup(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
        // Переход к окну "Students" (Студенты).
        private void student_btn_Click(object sender, EventArgs e)
        {
            Students Win = new Students(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
        // Переход к форме "Списки групп".
        private void group_lists_btn_Click(object sender, EventArgs e)
        {
            MainWindow Win = new MainWindow(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}

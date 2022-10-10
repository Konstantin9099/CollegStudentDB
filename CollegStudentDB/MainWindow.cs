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
    public partial class MainWindow : Form
    {
        public int ID = 0;

        public MainWindow(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            Get_Inf(ID_log);
            ID = ID_log;
        }
        // Переход на форму "Преподаватели".
        private void add_teacher_btn_Click(object sender, EventArgs e)
        {
            Teachers Win = new Teachers(ID);
            Win.Show();
        }
        // Переход на форму "Группы".
        private void add_group_btn_Click(object sender, EventArgs e)
        {
            LearningGroup Win = new LearningGroup(ID);
            Win.Owner = this;
            Win.Show();
        }
        // Переход на форму "Студенты".
        private void add_student_btn_Click(object sender, EventArgs e)
        {
            Students Win = new Students(ID);
            Win.Owner = this;
            Win.Show();
        }
        // Переход в "Menu".
        private void menu_bt_Click(object sender, EventArgs e)
        {
            Menu Win = new Menu(ID);
            Win.Owner = this;
            Win.Show();
        }

        // Вывод таблицы "Список - Кураторы".
        public void Get_Info(int ID)
        {
            string query = "select * from Teachers inner join LearningGroup on Teachers.TeacherID=LearningGroup.Curator;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[1].HeaderText = "Фамилия";
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[2].HeaderText = "Имя";
                this.dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[3].HeaderText = "Отчество";
                this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                this.dataGridView1.Columns[6].HeaderText = "Группа";
                this.dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[7].HeaderText = "Специальность";
                this.dataGridView1.Columns[7].Width = 200;
                this.dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }


        // Вывод таблицы "Список - студенты".
        public void Get_Inf(int ID)
        {
            string query = "select * from LearningGroup inner join Students on LearningGroup.LearningGroupID=Students.LearningGroup;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.ClearSelection();
                dataGridView2.Columns[0].Visible = false;
                this.dataGridView2.Columns[1].HeaderText = "Группа";
                this.dataGridView2.Columns[1].Width = 75;
                this.dataGridView2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[2].HeaderText = "Специальность";
                this.dataGridView2.Columns[2].Width = 180;
                this.dataGridView2.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                this.dataGridView2.Columns[5].HeaderText = "№ студ. билета";
                this.dataGridView2.Columns[5].Width = 70;
                this.dataGridView2.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.Columns[6].Visible = false;
                this.dataGridView2.Columns[7].HeaderText = "Фамилия";
                this.dataGridView2.Columns[7].Width = 70;
                this.dataGridView2.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[8].HeaderText = "Имя";
                this.dataGridView2.Columns[8].Width = 70;
                this.dataGridView2.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[9].HeaderText = "Отчество";
                this.dataGridView2.Columns[9].Width = 70;
                this.dataGridView2.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[10].HeaderText = "День рожд.";
                this.dataGridView2.Columns[10].Width = 70;
                this.dataGridView2.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[11].HeaderText = "Адрес";
                this.dataGridView2.Columns[11].Width = 250;
                this.dataGridView2.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView2.Columns[12].HeaderText = "Телефон";
                this.dataGridView2.Columns[12].Width = 100;
                this.dataGridView2.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }


        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}


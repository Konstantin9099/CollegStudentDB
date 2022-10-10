using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace CollegStudentDB
{
    public partial class LearningGroup : Form
    {
        public int ID = 0;
        public LearningGroup(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            ID = ID_log;
        }

        // Вывод таблицы LearningGroup в БД.
        public void Get_Info(int ID)
        {
            string query = "SELECT LearningGroupID AS 'Код', GroupNumber AS 'Номер группы', Speciality AS 'Специальность', Curator AS 'Куратор' FROM LearningGroup";
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
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[2].Width = 200;
                this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void LearningGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Кнопка добавить группу.
        private void add_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (group_tb.Text == null || group_tb.Text == "")
                MessageBox.Show(
                    "Введите № группы.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (speciality_tb.Text == null || speciality_tb.Text == "")
                MessageBox.Show(
                   "Введите название специальности.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (teachers_cmb.Text == null || teachers_cmb.Text == "")
                MessageBox.Show(
                   "Введите отчество.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else
            {
                string query = "insert into LearningGroup(GroupNumber, Speciality, Curator) values('" + group_tb.Text + "', '" + speciality_tb.Text + "', '" + teachers_cmb.Text + "'); ";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
                do_Action(query);
            }
        }

        string id;
        public LearningGroup(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }

        // Изменение данных группы.
        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                EditGroup Win = new EditGroup("chng", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                Win.Owner = this;
                Win.Show();
            }
        }

        //Функция, позволяющая отправить команду на сервер БД для оптимизации кода.
        public void do_Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        // Переход в меню и закрытие формы.
        private void menu_bt_Click(object sender, EventArgs e)
        {
            Menu Win = new Menu(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void print_bt_Click(object sender, EventArgs e)
        {
            int kol = dataGridView1.Rows.Count;
            if (kol != 0)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp =
                        new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                //Книга.
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                //Таблица.
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    ExcelApp.Cells[1, i + 1] = Convert.ToString(dataGridView1.Columns[i].HeaderText);
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }
                //Вызываем приложение Excel.
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            else
            {
                MessageBox.Show("Для импорта данных из таблицы в Excel для начало заполните таблицу данными!", "Импорт данных из таблицы в Excel");
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(search_line_tb.Text))
                            {
                                dataGridView1.Rows[i].Selected = true;
                                break;
                            }


                }
            }
        }

        private void LearningGroup_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM  colleg_student_db.Teachers ";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    teachers_cmb.Items.Add(reader.GetString("TeacherID"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Вывод данных в поля формы (ФИО и дата рождения) при выделении строки нажатием курсора.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            group_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            speciality_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            teachers_cmb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Get_Info(ID);
            group_tb.Clear();
            speciality_tb.Clear();
            search_line_tb.Clear();
            teachers_cmb.SelectedIndex = -1;
        }
    }
}

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
    public partial class Students : Form
    {
        public int ID = 0;
        public Students(int ID_log)
        {
            InitializeComponent();
            Get_Info(ID_log);
            ID = ID_log;
            dateTimePicker1.Value = DateTime.Now;
        }

        // Вывод таблицы Students в БД.
        public void Get_Info(int ID)
        {
            string query = "SELECT StudentID AS 'Код', NumberStudentCard AS '№ Студенч. билета', LearningGroup AS 'Группа', LastName AS 'Фамилия', FirstName AS 'Имя', MiddleName AS 'Отчество', Birthday AS 'Дата рождения', Address AS 'Адрес', Phone AS 'Телефон' FROM Students";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                this.dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);
            }
        }

        private void Students_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Добавление в БД нового студента.
        private void add_btn_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (last_name_tb.Text == null || last_name_tb.Text == "")
                MessageBox.Show(
                    "Введите фамилию.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (first_name_tb.Text == null || first_name_tb.Text == "")
                MessageBox.Show(
                   "Введите имя.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (middle_name_tb.Text == null || middle_name_tb.Text == "")
                MessageBox.Show(
                   "Введите отчество.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (address_tb.Text == null || address_tb.Text == "")
                MessageBox.Show(
                   "Введите адрес.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (telephone_mtb.Text == null || telephone_mtb.Text == "")
                MessageBox.Show(
                   "Введите номер телефона.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (student_card_tb.Text == null || student_card_tb.Text == "")
                MessageBox.Show(
                   "Введите номер студенческого билета.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (group_cmb.Text == null || group_cmb.Text == "")
                MessageBox.Show(
                   "Введите номер группы.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else
            {
                string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string query = "insert into Students(NumberStudentCard, LearningGroup, LastName, FirstName, MiddleName, Birthday, Address, Phone) values('" + student_card_tb.Text + "', '" + group_cmb.Text + "', '" + last_name_tb.Text + "', '" + first_name_tb.Text + "', '" + middle_name_tb.Text + "','" + Date1 + "', '" + address_tb.Text + "', '" + telephone_mtb.Text + "'); ";
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
        public Students(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                Edit_Student Win = new Edit_Student("chng", dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
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
        // Вывод данных в поля формы (ФИО, дата рождения и т.д.) при выделении строки нажатием курсора.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            student_card_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            group_cmb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            last_name_tb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            first_name_tb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            middle_name_tb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            address_tb.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            telephone_mtb.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
        // Обновление БД.
        private void button1_Click(object sender, EventArgs e)
        {
            Get_Info(ID);
            last_name_tb.Clear();
            first_name_tb.Clear();
            middle_name_tb.Clear();
            address_tb.Clear();
            telephone_mtb.Clear();
            student_card_tb.Clear();
            group_cmb.SelectedIndex = -1;
        }
        // Переход в меню и закрытие формы.
        private void menu_bt_Click(object sender, EventArgs e)
        {
            Menu Win = new Menu(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
        // Экспорт файла в Excel.
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
        // Строка поиска.
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

        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM  colleg_student_db.LearningGroup ";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);

                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    group_cmb.Items.Add(reader.GetString("LearningGroupID"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Кнопка "Удалить".
        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены что хотите удалить информацию?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string valueCell = dataGridView1.CurrentCell.Value != null ? dataGridView1.CurrentCell.Value.ToString() : "";
                string del = "delete from Students where StudentID = " + valueCell + ";";
                do_Action(del);
            }
            else
            {
                MessageBox.Show("Не выбрано ни одной записи! Удаление невозможно.");
            }
        }
    }
}

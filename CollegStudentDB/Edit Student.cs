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
    public partial class Edit_Student : Form
    {
        public Students fm { get; set; }
        public Edit_Student(Students fm)
        {
            InitializeComponent();
            this.fm = fm;
        }

        void do_Action(string query)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла непредвиденная ошибка!");
            }
        }

        string id;
        public Edit_Student(string mode, string Id)
        {
            InitializeComponent();

            if (mode == "chng")
            {
                id = Id;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, чтобы были заполнены все поля.
            if (student_card_tb.Text == null || student_card_tb.Text == "")
                MessageBox.Show(
                    "Введите № Студенческого билета.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (group_cmb.Text == null || group_cmb.Text == "")
                MessageBox.Show(
                   "Введите № группы.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (last_name_tb.Text == null || last_name_tb.Text == "")
                MessageBox.Show(
                   "Введите фамилию.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (first_name_tb.Text == null || first_name_tb.Text == "")
                MessageBox.Show(
                   "Введите фамилию.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (middle_name_tb.Text == null || middle_name_tb.Text == "")
                MessageBox.Show(
                   "Введите фамилию.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (address_tb.Text == null || address_tb.Text == "")
                MessageBox.Show(
                   "Введите имя.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (telephone_mtb.Text == null || telephone_mtb.Text == "")
                MessageBox.Show(
                   "Введите отчество.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else
            {
                string Date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string query = "update Students set NumberStudentCard = '" + student_card_tb.Text + "', LearningGroup = '" + group_cmb.Text + "', LastName = '" + last_name_tb.Text + "', FirstName = '" + first_name_tb.Text + "', MiddleName = '" + middle_name_tb.Text + "', Birthday = '" + Date1 + "', Address = '" + address_tb.Text + "', Phone = '" + telephone_mtb.Text + "' where StudentID =" + id.ToString() + ";";
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

        private void Edit_Student_Load(object sender, EventArgs e)
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
    }
}

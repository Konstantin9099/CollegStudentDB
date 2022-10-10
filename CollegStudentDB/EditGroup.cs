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
    public partial class EditGroup : Form
    {
        public LearningGroup fm { get; set; }
        public EditGroup(LearningGroup fm)
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
        public EditGroup(string mode, string Id)
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
            if (GroupNumber_tb.Text == null || GroupNumber_tb.Text == "")
                MessageBox.Show(
                    "Введите № группы.",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else if (speciality_tb.Text == null || speciality_tb.Text == "")
                MessageBox.Show(
                   "Введите специальность.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (teachers_cmb.Text == null || teachers_cmb.Text == "")
                MessageBox.Show(
                   "Введите куратора.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (speciality_tb.Text == null || speciality_tb.Text == "")
                MessageBox.Show(
                   "Введите специальность.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else if (teachers_cmb.Text == null || teachers_cmb.Text == "")
                MessageBox.Show(
                   "Введите куратора.",
                   "Сообщение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            else
            {
                string query = "update LearningGroup set GroupNumber = '" + GroupNumber_tb.Text + "', Speciality = '" + speciality_tb.Text + "', Curator = '" + teachers_cmb.Text + "' where LearningGroupID =" + id.ToString() + ";";
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

        private void EditGroup_Load(object sender, EventArgs e)
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
    }
}

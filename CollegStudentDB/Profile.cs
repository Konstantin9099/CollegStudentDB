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
    public partial class Profile : Form
    {
        public int ID = 0;
        public Profile(int ID_log)
        {
            InitializeComponent();
            name_box.Visible = false;
            password_box.Visible = false;
            ID = ID_log;
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chng_btn_Click(object sender, EventArgs e)
        {
            if (chng_btn.Text == "Изменить")
            {
                name_box.Visible = true;
                password_box.Visible = true;
                chng_btn.Text = "Сохранить";
            }
            else if (chng_btn.Text == "Сохранить")
            {
                string query = "update Authorization set Login ='" + name_box.Text + "', LoginPass ='" + password_box.Text + "' where LoginID = " + ID.ToString() + ";";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmDB.ExecuteReader();
                    conn.Close();
                    name_box.Visible = false;
                    password_box.Visible = false;
                    chng_btn.Text = "Изменить";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Возникла непредвиденная ошибка!" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Menu Win = new Menu(ID);
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }
    }
}

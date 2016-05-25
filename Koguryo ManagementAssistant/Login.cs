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
using System.Security.Cryptography;

namespace Koguryo_ManagementAssistant
{
    public partial class Login : Form
    {

        private string username;
        private string password;
        Record studentsForm = new Record();

        public Login()
        {
            InitializeComponent();
            MySql.InitializeDB();
            
        }

        public bool OpenConnection()
        {
            try
            {
                MySql.dbConn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Connection Failed");
                        break;
                    case 1045:
                        MessageBox.Show("Username or Password Incorrect");
                        break;
                }
                return false;
            }
        }


        public bool loginQuery()
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding UTF8 = new UTF8Encoding();
            password = BitConverter.ToString(md5.ComputeHash(UTF8.GetBytes(passwordBox.Text)));
            //Console.WriteLine(password);

            username = usernameBox.Text;

            string query = " SELECT * FROM admin where Username = @username && Password = @password";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Connection = MySql.dbConn;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        MySql.dbConn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        MySql.dbConn.Close();
                        return false;
                    }

                }
                else
                {
                    MySql.dbConn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MySql.dbConn.Close();
                return false;
            }



        }

        

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginQuery())
            {
                studentsForm.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Invalid Login");
            }
        }
    }
}


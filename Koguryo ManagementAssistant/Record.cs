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

namespace Koguryo_ManagementAssistant
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            MySql.InitializeDB();
            LoadAll();
            this.dateStamp.Value = DateTime.Now;
        }

        public void LoadAll()
        {
            List<Student> students = Student.GetStudents();

            studentlist.Items.Clear();

            foreach (Student s in students)
            {

                ListViewItem item = new ListViewItem(new String[] { s.Id.ToString(), s.Firstname, s.Lastname });
                item.Tag = s;

                studentlist.Items.Add(item);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO students (Firstname, Lastname) Values(@fname,@lname)";

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@fname", studentfnamebox.Text);
            cmd.Parameters.AddWithValue("@lname", studentlnamebox.Text);
            cmd.Connection = MySql.dbConn;
            MySql.dbConn.Open();
            cmd.ExecuteNonQuery();
            MySql.dbConn.Close();

            LoadAll();

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void studentlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentlist.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = studentlist.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                ListViewItem item = studentlist.SelectedItems[0];
                idbox.Text = item.SubItems[0].Text;
                selectedfname.Text = item.SubItems[1].Text;
                selectedlname.Text = item.SubItems[2].Text;
            }
        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO attendance (Firstname,Lastname,Date,Paid,Amount,StudentID,Class) VALUES(@firstname,@lastname,@date,@paid,@amount,@studentid,@class)";
            try
            {
                MySql.dbConn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@firstname", selectedfname.Text);
                cmd.Parameters.AddWithValue("@lastname", selectedlname.Text);
                cmd.Parameters.AddWithValue("@date", dateStamp.Value);
                cmd.Parameters.AddWithValue("@paid", paidbox.Checked);
                cmd.Parameters.AddWithValue("@amount", amountbox.Text);
                cmd.Parameters.AddWithValue("@studentid", idbox.Text);
                cmd.Parameters.AddWithValue("@class", classbox.Text);
                cmd.Connection = MySql.dbConn;
                cmd.ExecuteNonQuery();

                MySql.dbConn.Close();

                MessageBox.Show("Data Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not add data");
            }
            
        }
    }
}

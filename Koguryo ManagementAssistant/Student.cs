using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Koguryo_ManagementAssistant
{
    public class Student
    {
        
        public int Id { get; private set; }

        public String Firstname { get; private set; }

        public String Lastname { get; private set; }

        private Student(int id, String u, String p)
        {
            Id = id;
            Firstname = u;
            Lastname = p;
        }


       public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            String query = "SELECT * FROM students";

           

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = MySql.dbConn;

            MySql.dbConn.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = (int)reader["ID"];
                String username = reader["Firstname"].ToString();
                String password = reader["Lastname"].ToString();

                Student s = new Student(id, username, password);

                students.Add(s);
            }

            reader.Close();

            MySql.dbConn.Close();

            return students;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALStudent
    {
        public static int AddStudent(EntityStudent parameter)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_STUDENT " +
                "(StudentName,StudentSurname,StudentNumber,StudentPhoto,StudentPassword)" +
                " values (@p1,@p2,@p3,@p4,@p5)", Connect.conn);
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",parameter.Name);
            cmd.Parameters.AddWithValue("@p2", parameter.Surname);
            cmd.Parameters.AddWithValue("@p3", parameter.Number);
            cmd.Parameters.AddWithValue("@p4", parameter.Photo);
            cmd.Parameters.AddWithValue("@p5", parameter.Password);
            return cmd.ExecuteNonQuery();

        }
        public static List<EntityStudent> GetAllStudents()
        {
            List<EntityStudent> students = new List<EntityStudent>();
            SqlCommand cmd2 = new SqlCommand("select * from TBL_STUDENT", Connect.conn);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                EntityStudent student = new EntityStudent();
                student.Id = Convert.ToInt32(reader["StudentID"].ToString());
                student.Name = reader["StudentName"].ToString();
                student.Surname = reader["StudentSurname"].ToString();
                student.Number = reader["StudentNumber"].ToString();
                student.Photo = reader["StudentPhoto"].ToString();
                student.Password = reader["StudentPassword"].ToString();
                student.Balance = Convert.ToDouble(reader["StudentBalance"].ToString());
                students.Add(student);
            }
            reader.Close();
            return students;

        }
        public static bool DeleteStudent(int id)
        {
            SqlCommand cmd3 = new SqlCommand("delete from TBL_STUDENT where StudentID=@p1", Connect.conn);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@p1", id);
            return cmd3.ExecuteNonQuery()>0;
        }

        public static List<EntityStudent> StudentDetails(int id)
        {
            List<EntityStudent> students = new List<EntityStudent>();
            SqlCommand cmd4 = new SqlCommand("select * from TBL_STUDENT where StudentID=@p1", Connect.conn);
            cmd4.Parameters.AddWithValue("@p1", id);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            SqlDataReader reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                EntityStudent student = new EntityStudent();
                student.Id = Convert.ToInt32(reader["StudentID"].ToString());
                student.Name = reader["StudentName"].ToString();
                student.Surname = reader["StudentSurname"].ToString();
                student.Number = reader["StudentNumber"].ToString();
                student.Photo = reader["StudentPhoto"].ToString();
                student.Password = reader["StudentPassword"].ToString();
                student.Balance = Convert.ToDouble(reader["StudentBalance"].ToString());
                students.Add(student);
            }
            reader.Close();
            return students;

        }

        public static bool UpdateStudent(EntityStudent id)
        {
            SqlCommand cmd5 = new SqlCommand("Update TBL_STUDENT set " +
                "StudentName=@p1,StudentSurname=@p2,StudentNumber=@p3," +
                "StudentPassword=@p4,StudentPhoto=@p5 " +
                "where StudentID=@p6", Connect.conn);
            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            cmd5.Parameters.AddWithValue("@p1", id.Name);
            cmd5.Parameters.AddWithValue("@p2", id.Surname);
            cmd5.Parameters.AddWithValue("@p3", id.Number);
            cmd5.Parameters.AddWithValue("@p4", id.Password);
            cmd5.Parameters.AddWithValue("@p5", id.Photo);
            cmd5.Parameters.AddWithValue("@p6", id.Id);
            

            return cmd5.ExecuteNonQuery() > 0;
        }
    }
}

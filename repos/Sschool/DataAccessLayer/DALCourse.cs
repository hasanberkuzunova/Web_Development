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
    public class DALCourse
    {
        public static List<EntityCourse> getAllCourses()
        {
            List<EntityCourse> courses = new List<EntityCourse>();
            SqlCommand cmd = new SqlCommand("select * from TBL_COURSE", Connect.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EntityCourse course = new EntityCourse();
                course.Id = Convert.ToInt32(reader["CourseID"].ToString());
                course.CourseName = reader["CourseName"].ToString();
                course.Min =int.Parse( reader["CourseMinCapacity"].ToString() );
                course.Max =int.Parse( reader["CourseMaxCapacity"].ToString() );
              
                courses.Add(course);
            }
            reader.Close();
            return courses;

        }
        public static int newApplication(EntityApplication p)
        {
            SqlCommand cmd2 = new SqlCommand("insert into TBL_APPLICATION (StudentID,CourseID)" +
                "values (@p1,@p2)", Connect.conn);
            cmd2.Parameters.AddWithValue("@p1", p.ApplicationStudentId);
            cmd2.Parameters.AddWithValue("@p2", p.ApplicationCourseId);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            return cmd2.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static int AddStudentBLL(EntityStudent p)
        {
            if (p.Name != null && p.Surname != null && p.Number != null && p.Photo != null && p.Password != null)
            {
                return DALStudent.AddStudent(p);
            }
        return -1;
        }
        public static List<EntityStudent> BLL_List()
        {
            return DALStudent.GetAllStudents();
        }
         public static bool BLLDeleteStudent(int id)
        {
            if(id != null)
            {
                return DALStudent.DeleteStudent(id);
            }
            return false;
        }
        public static List<EntityStudent> BLL_Detail(int id)
        {
            return DALStudent.StudentDetails(id);
        }
        public static bool BLLUpdateStudent(EntityStudent p)
        {
            if (p.Name != null && p.Surname != null && p.Number != null && p.Photo != null && p.Password != null && p.Id>0)
            {
                return DALStudent.UpdateStudent(p);
            }
            return false;
        }
    }
}

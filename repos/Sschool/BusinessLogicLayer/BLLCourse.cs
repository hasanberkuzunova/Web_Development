using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLCourse
    {
        public static List<EntityCourse> BLL_List()
        {
            return DALCourse.getAllCourses();
        }
        public static int addApplication(EntityApplication p)
        {
            if(p.ApplicationStudentId!=null && p.ApplicationCourseId != null)
            {
                return DALCourse.newApplication(p);
            }
            return -1;
        }
    }
}

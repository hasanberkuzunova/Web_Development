using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityApplication
    {
        private int applicationId;
        private int applicationCourseId;
        private int applicationStudentId;

        public int ApplicationId { get => applicationId; set => applicationId = value; }
        public int ApplicationCourseId { get => applicationCourseId; set => applicationCourseId = value; }
        public int ApplicationStudentId { get => applicationStudentId; set => applicationStudentId = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuan5.DAL.Database;

namespace tuan5.BUS
{
    public class MajorService
    {
        public List<Major> GetAllByFaculty(int facultyId)
        {
            StudentDB context = new StudentDB();
            return context.Majors.Where(p=>p.FacultyID == facultyId).ToList();
        }
    }
}

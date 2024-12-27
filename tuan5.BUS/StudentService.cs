using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tuan5.DAL.Database;

namespace tuan5.BUS
{
    public class StudentService
    {

        public List<Student> GetAll()
        {
            StudentDB context = new StudentDB();
            return context.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor()
        {
            StudentDB context = new StudentDB();
            return context.Students.Where(p=>p.MajorID == null).ToList();
        }
        
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            StudentDB context = new StudentDB();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        
        public Student FindById(string studentId)
        {
            StudentDB context = new StudentDB();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }
        public void InsertUpdate(Student s)
        {
            StudentDB context = new StudentDB(); 
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }        
    }
}

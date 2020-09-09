using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Entity;

namespace BLL
{
    public class BLLStudent
    {
        LibraryMSEntities _db = new LibraryMSEntities();
        public List<StudentDetails> getStudents()
        {
            List<StudentDetails> lst = new List<StudentDetails>();
            List<getStudent_Result> lstbk = _db.getStudent().ToList();
            foreach (getStudent_Result item in lstbk)
            {
                lst.Add(new StudentDetails() { StudentID = item.StudentID, FullName = item.FullName, Email = item.Email, PhoneNo = item.PhoneNo, Gender = item.Gender, Photo = item.Photo, RollNo = item.RollNo });
            }
            return lst;
        }
        public int addStudent(StudentDetails sd)
        {
            var student = _db.addStudent(sd.FullName, sd.Gender, sd.RollNo, sd.PhoneNo, sd.Email, sd.Photo);
            if (student != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

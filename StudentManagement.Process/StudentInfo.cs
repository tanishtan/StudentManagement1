using StudentManagement.Commons;
using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Process
{
    public class StudentInfo
    {
        protected Student student;
        public StudentInfo(int rollNo, Person personId, short semester, StreamType type)
        {
            student = new Student(rollNo, personId, semester, type);
        }
        public StudentInfo(Student pInfo2) { student = pInfo2; }

        public override string ToString()
        {
            return $"RollNo: {student.rollNo}, Id: {student.p1.NameofPerson}, Type: {student.Semester}, Balance: {student.type}";
        }

    }
}

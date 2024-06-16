using StudentManagement.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entities
{
    public class Student
    {
        private int _rollNo = 0;
        private Person _personId;
        private short _semester = 0;
        private StreamType _type = StreamType.None;
        public object personId;

        private Student() { }

        public Student(int rollNo, Person personId, short semester, StreamType type)
        {
            _rollNo = rollNo;
            _personId = personId;
            _semester = semester;
            _type = type;
        }

        public int rollNo { get { return _rollNo;} set { _rollNo = value; } }
        public Person p1 { get { return _personId; } set { _personId = value; } }
        public short Semester {  get { return _semester; } set { _semester = value; }}
        public StreamType type { get { return _type; } set { _type = value; } }


        private List<Student> students;
        public void AddStudent(int rollNo, int personId, short semester, string stream)
        {
            // Check if the person exists
            var existingPerson = people.Find(p => p.PersonId == personId);
            if (existingPerson == null)
            {
                Console.WriteLine("Error: Person does not exist. Please add the person first.");
                return;
            }

            var student = new Student
            {
                rollNo = rollNo,
                p1 = Person.,
                Semester = semester,
                type = StreamType.None
            };
            students.Add(student);
            Console.WriteLine($"Student with Roll No. {rollNo} added successfully.");
        }
    }
}

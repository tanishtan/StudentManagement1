using StudentManagement.Commons;
using StudentManagement.Process;
using System;

namespace StudentManagementConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Id of the person");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of the person");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the birthdate of the person (yyyy-MM-dd)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the address of the person");
            string address = Console.ReadLine();

            PersonInfo p = new PersonInfo(id, name, date, address);
            Console.WriteLine(p);
            var x = p.GetPerson();

            Console.WriteLine("Enter the rollno of the student");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the semester of the student");
            short sem = short.Parse(Console.ReadLine());

            // Prompt the user for the stream type
            Console.WriteLine("Enter the stream of the student (ComputerScience, Electronics, Electrical, Mechanical)");
            string streamInput = Console.ReadLine();

            // Parse the stream type and create the StudentInfo object
            if (Enum.TryParse<StreamType>(streamInput, out StreamType stream))
            {
                StudentInfo s = new StudentInfo(rollno, x, sem, stream);
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Invalid stream type. Please enter a valid stream.");
            }
        }
    }
}

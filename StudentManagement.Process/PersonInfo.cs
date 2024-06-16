using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Process
{ 
    public class PersonInfo
    {
        protected Person person;
        public PersonInfo(int PersonId, string nameOfPerson, DateTime birthDate, string address)
        {
            person = new Person(PersonId, nameOfPerson, birthDate, address);
        }
        public PersonInfo(Person pInfo1) { person = pInfo1; }
        public Person GetPerson() 
        {  
            return person; 
        }

        public override string ToString()
        {
            return $"Id: {person.PersonId}, Name: {person.NameofPerson}, Type: {person.DateTime}, Balance: {person.Address}";
        }
    }
}

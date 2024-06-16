using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Entities
{
    public class Person
    {
        private int _PersonId = 0;
        private string _nameofPerson = "";
        private DateTime _birthDate = DateTime.MinValue;
        private string _address = "";

        private Person() { }

        public Person(int PersonId,string nameOfPerson, DateTime birthDate, string address)
        {
            _PersonId = PersonId;
            _nameofPerson = nameOfPerson;
            _birthDate = birthDate;
            _address = address;
        }

        

        public int PersonId { get { return _PersonId; } set { _PersonId = value; } }
        public string NameofPerson { get { return _nameofPerson; } set { _address = value; } }
        public DateTime DateTime { get { return _birthDate; } set { _birthDate = value; } }
        public string Address { get { return _address; } set { _address = value; } }


        private List<Person> people;
        public void AddPerson(int personId, string name, DateTime birthDate, string address)
        {
            var person = new Person
            {
                PersonId = personId,
                NameofPerson = name,
                DateTime=birthDate,
                Address = address
            };
            people.Add(person);
        }
    }
}

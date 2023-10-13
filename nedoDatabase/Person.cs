using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nedoDatabase
{
    internal class Person
    {
        string name;
        string surname;
        string pesel;
        Boolean employee;

        public Person(string name,string surname,string pesel, Boolean employee){
            this.name = name;
            this.surname = surname;
            this.pesel = pesel;
            this.employee = employee;
        }

        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getPesel()
        {
            return pesel;
        }
        public Boolean getEmployee()
        {
            return employee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pracownicy
{
    public class Employee
    {
        private String name;
        private String surname;
        private DateTime birthDate;
        private int salary;
        private JobTitles title;
        private ContractTypes contractType;

        public String Name
        { get { return name; } set { name = value; } }
        public String Surname 
        { get { return surname; } set { surname = value; } }
        public DateTime BirthDate 
        { get { return birthDate; } set { birthDate = value; } }
        public int Salary 
        { get { return salary; } set { salary = value; } }
        public JobTitles Title 
        { get { return title; } set { title = value; } }
        public ContractTypes ContractType 
        { get { return contractType; } set { contractType = value; } }

        public Employee() { }

        public Employee(String name, String surname, DateTime birthDate, int salary, JobTitles title, ContractTypes contractType)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
            this.salary = salary;
            this.title = title;
            this.contractType = contractType;
        }

        public override String ToString()
        {
            return String.Format("{0}, {1}, {2}, {3:d}, {4}, {5}", name, surname, birthDate.ToString("dd/MM/yyyy"), salary, title, contractType);
        }
    }
}

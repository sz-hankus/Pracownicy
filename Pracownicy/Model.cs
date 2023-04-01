using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Model
    {
        private List<Employee> _employees;

        public Model()
        {
            this._employees = new List<Employee>();
        }

        public void AddEmmployee(Employee employee)
        {
            this._employees.Add(employee);
        }

        public Employee GetEmployee(int id)
        {
            return this._employees[id];
        }

        public List<Employee> GetEmployees()
        {
            return this._employees;
        }

        public void LoadFromFile(String path)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this._employees.GetType());
            using (Stream inputFileStream = new FileStream(path, FileMode.Open))
            {
                this._employees = x.Deserialize(inputFileStream) as List<Employee>;
            }
        }

        public void WriteContentsToFile(String path)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this._employees.GetType());
            using (Stream outputFileStream = new FileStream(path, FileMode.Create))
            {
                x.Serialize(outputFileStream, this._employees);
            }
        }
    }
}

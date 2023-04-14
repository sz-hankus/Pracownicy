using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pracownicy
{
    public class Model
    {
        private List<Employee> _employees;

        public Model()
        {
            this._employees = new List<Employee>();
        }

        public bool isEmployeeValid(Employee employee)
        {            
            if (!employee.Name.All(Char.IsLetter) || !employee.Surname.All(Char.IsLetter))
                return false;
            return true;
        }

        public void AddEmployee(Employee employee)
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

        public void WriteContentsToFile(String path)
        {
            if (path.EndsWith(".json"))
                JSONSerialize(path);
            else
                XMLSerialize(path);
        }

        private void JSONSerialize(String path)
        {
            using (Stream outputFileStream = new FileStream(path, FileMode.Create))
                System.Text.Json.JsonSerializer.Serialize(outputFileStream, this._employees);
        }

        private void XMLSerialize(String path)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this._employees.GetType());
            using (Stream outputFileStream = new FileStream(path, FileMode.Create))
                x.Serialize(outputFileStream, this._employees);
        }

        public void LoadFromFile(String path)
        {
            if (path.EndsWith(".json"))
                this._employees = JSONDeserialize(path);
            else
                this._employees = XMLDeserialize(path);
        }

        private List<Employee> JSONDeserialize(String path)
        {
            using (Stream inputFileStream = new FileStream(path, FileMode.Open))
                return System.Text.Json.JsonSerializer.Deserialize<List<Employee>>(inputFileStream);
        }

        private List<Employee> XMLDeserialize(String path)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this._employees.GetType());
            using (Stream inputFileStream = new FileStream(path, FileMode.Open))
                return x.Deserialize(inputFileStream) as List<Employee>;
        }
       
    }
}

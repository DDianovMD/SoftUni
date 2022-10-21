using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        public List<Employee> data = new List<Employee>();
        private string name;
        private int capacity;

        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get => this.name; set => this.name = value; }
        public int Capacity { get => this.capacity; set => this.capacity = value; }
        public int Count { get => this.data.Count; }

        public void Add(Employee employee)
        {
            if (Count < Capacity)
            {
                this.data.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employeeToRemove = this.data.FirstOrDefault(employee => employee.Name == name);

            return this.data.Remove(employeeToRemove);
        }

        public Employee GetOldestEmployee()
        {
            return this.data.OrderByDescending(employee => employee.Age).FirstOrDefault();
        }

        public Employee GetEmployee(string name)
        {
            return this.data.FirstOrDefault(employee => employee.Name == name);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (Employee employee in this.data)
            {
                result.AppendLine(employee.ToString());
            }

            return result.ToString().Trim();
        }
    }
}

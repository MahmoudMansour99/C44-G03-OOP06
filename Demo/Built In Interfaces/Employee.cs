using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Built_In_Interfaces
{
    internal class Employee:ICloneable, IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public Employee()
        {
            
        }

        public object Clone()
        {
            return new Employee(this)
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
            };
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary = {Salary:c}";
        }

        public int CompareTo(Employee? other)
        {
            //if (Salary > other?.Salary)
            //    return 1;
            //else if (Salary < other?.Salary)
            //    return -1;
            //else
            //    return 0; 

            return this.Salary.CompareTo(other?.Salary);
        }
    }
}

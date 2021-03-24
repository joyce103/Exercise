using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習5
{
    class Employee
    {
        private int id;
        private string name;
        private int year;
        private int salary;
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Year
        {
            set
            {
                if (value >= 0)
                {
                    year = value;
                }
                else
                {
                    year = 0;
                }
            }
            get
            {
                return year;
            }
        }
        public int Salary
        {
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    salary = 0;
                }
            }
            get
            {
                return salary;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee A = new Employee(1072010,"Joyce");
            A.Salary = 50000;
            A.Year = 3;
            Console.WriteLine("ID={0}, Name={1}, Salary={2}, Year={3}", A.ID, A.Name, A.Salary, A.Year);
        }
    }
}

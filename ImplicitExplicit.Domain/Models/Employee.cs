

using ImplicitExplicit.Domain.Models;

namespace ImplicitExplicit.Domain.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private static int _id { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
        public DateTime Birthday { get; set; }



        public Employee()
        {
            _id++;
            ID=_id;
        }

        public Employee(string name, string surname, int salary, DateTime birthday)
        {

            Birthday = birthday;
            Name = name;
            Surname = surname;
            Salary = salary;

        }




        public Employee[] Info()
        {
            Employee employee1 = new("Nigar", "Aliyeva", 2100, new DateTime(1999, 02, 20));
            Employee employee2 = new("Murad", "Aliyev", 2400, new DateTime(2000, 11, 12));
            Employee employee3 = new("Eli", "Babayev", 1600, new DateTime(2000, 06, 22));
            Employee employee4 = new("Peri", "Ahmadli", 1900, new DateTime(1995, 09, 09));
            Employee[] employees = { employee1, employee2, employee3, employee4 };
            return employees;
        }

        public void EmployeesCount(DateTime a, DateTime b, int salary)
        {
            Employee[] employees = Info();
            int result = default;

            foreach (var employee in employees)
            {

              if (employee.Salary>=salary && employee.Birthday>=a && employee.Birthday<=b)
                {
                    result++;
                }
            }
            Console.WriteLine(result);



        }

    }
}      
    


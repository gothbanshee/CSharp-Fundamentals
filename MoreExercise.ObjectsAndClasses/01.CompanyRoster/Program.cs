namespace _01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; }
        public double Salary { get; }
        public string Department { get; }

        public override string ToString()
        {
            return $"{Name} {Salary:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split()
                                          .ToArray();

                Employee employee = new Employee(command[0], double.Parse(command[1]), command[2]);
                employees.Add(employee);
            }

            double maxAvg = double.MinValue;
            string maxDept = string.Empty;
            foreach (Employee employee in employees)
            {
                double newAvg = employees.Where(e => e.Department == employee.Department).Select(e => e.Salary).DefaultIfEmpty().Average();

                if (maxAvg > newAvg)
                {
                    maxAvg = newAvg;
                    maxDept = employee.Department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {maxDept}");

            employees = employees.Where(e => e.Department == maxDept)
                                 .OrderByDescending(e => e.Salary)
                                 .ToList();

            employees.ForEach(e => Console.WriteLine(e));
        }
    }
}


namespace _07.CompanyUsers
{
    class Company
    {
        public Company(string name, List<string> employees)
        {
            Name = name;
            Employees = employees;
        }

        public string Name { get; }
        public List<string> Employees { get; }

        public override string ToString()
        {
            return $"{Name}\n{GetEmployees()}";
        }

        private string GetEmployees()
        {
            string result = "";
            foreach (var employee in Employees)
            {
                result += $"-- {employee}\n";
            }
            return result.Trim();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" -> ");

                string name = command[0];
                string employee = command[1];

                Company company = new Company(name, new List<string>());

                if (!companies.ContainsKey(name))
                {
                    companies.Add(name, company);
                }

                if (!companies[name].Employees.Contains(employee))
                {
                    companies[name].Employees.Add(employee);
                }
            }

            foreach (var keyValuePair in companies)
            {
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}
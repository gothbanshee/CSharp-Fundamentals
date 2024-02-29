namespace _05.ShoppingSpree
{
    internal class Person
    {
        public Person(string name, double money, List<string> personsProducts)
        {
            Name = name;
            Money = money;
            PersonsProducts = personsProducts;
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> PersonsProducts { get; set; }

        public override string ToString()
        {
            if (PersonsProducts.Count < 1)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {String.Join(", ", PersonsProducts)}";
            }
        }
    }

    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine()
                                        .Split(';', StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

            List<Person> people = new List<Person>();
            foreach (string p in info)
            {
                string[] personData = p.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personData[0], double.Parse(personData[1]), new List<string>());
                people.Add(person);
            }

            info = Console.ReadLine()
                           .Split(';', StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();

            List<Product> products = new List<Product>();
            foreach (string p in info)
            {
                string[] productInfo = p.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product(productInfo[0], double.Parse(productInfo[1]));
                products.Add(product);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();

                Person currentPerson = people.First(person => person.Name == command[0]);
                Product currentProduct = products.First(product => product.Name == command[1]);

                if (people.Contains(currentPerson) && products.Contains(currentProduct))
                {
                    if (currentPerson.Money >= currentProduct.Price)
                    {
                        currentPerson.Money -= currentProduct.Price;
                        currentPerson.PersonsProducts.Add(command[1]);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }
            }

            people.ForEach(person => Console.WriteLine(person));
        }
    }
}
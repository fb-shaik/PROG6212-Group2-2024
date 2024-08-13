namespace LINQ_Demo_2_G2
{
     class Program
    {
        static void Main(string[] args)
        {
            
            //Create the below lists as our data sources
            //1. List of integers (1-10)
            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};

            //2. List of Person (Id, Name, Age)
            List<Person> people = new List<Person>
            {
                new Person {ID = 1, Name = "Joe", Age = 20 },
                new Person {ID = 2, Name = "Alice", Age = 30 },
                new Person {ID = 3, Name = "Bob", Age = 26 },
                new Person {ID = 4, Name = "Sam", Age = 35 },
                new Person {ID = 5, Name = "Mike", Age = 40 },
                new Person {ID = 6, Name = "Jack", Age = 55 },

            };
            //3. List of Order (PersonId, Product)
            List<Order> orders = new List<Order>
            { 
                new Order {PersonId = 1, Product = "Laptop" },
                new Order {PersonId = 2, Product = "Bike" },
                new Order {PersonId = 3, Product = "Tablet" },
                new Order {PersonId = 4, Product = "Smartphone" },
                new Order {PersonId = 5, Product = "Monitor" },
                new Order {PersonId = 1, Product = "iPad" },
                new Order {PersonId = 2, Product = "Mouse" },
                new Order {PersonId = 3, Product = "Keyboard" },

            };

            //Query 1 - Group by Number (Even & Odd) >>> LINQ query expression way
            var groupedByNumberQuery = from num in numbers //step1: Data Source set
                                       group num by num % 2 == 0 into g
                                       select new { Key = g.Key, Numbers = g };
            //Step 2: Query expression
            //group num by: groups elements based on the criteria (even / odd)
            //num % 2 == 0: criteria used for grouping
            //into g : clause that assigns the grouped result (either even or odd)

            //Key = g.Key: Key property to hold the value of g.Key;
            //Numbers = g: Numbers property to hold the value og the grouped numbers themselves.
            //g holds all numbers that match the even/odd criteria

            Console.WriteLine("Query 1 - Grouped Numbers by even & odd: ");
            //step 3: Query execution
            foreach (var group in groupedByNumberQuery)
            {
                Console.WriteLine(group.Key ? "Even" : "Odd");
                foreach (var num in group.Numbers)
                {
                    Console.WriteLine(num);
                }
            }

            //Query 2: Join people with their orders (LINQ method) (will have Step 1 & step 2)
            var joinMethod = people.Join(orders,
                                         person => person.ID,
                                         order => order.PersonId,
                                         (person, order) => new { person.Name, order.Product });

            //Step 3: Execute the query result
            Console.WriteLine("\nJoin people with their orders:");
            foreach (var item in joinMethod)
            {
                Console.WriteLine($"{item.Name} ordered {item.Product}");
            }


            //Query 3: Find the average age of all people in the Person List
            //LINQ expression syntax
            var averageAgeQuery = (from person in people
                                   select person.Age).Average();

            //Display result
            Console.WriteLine($"\nAverage age of persons in the People List:{averageAgeQuery}");

            
        }


    }
}

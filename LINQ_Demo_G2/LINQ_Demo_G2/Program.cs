namespace LINQ_Demo_G2
{
    //LINQ demo
    //Language integrated query
    //Leverages the System.Linq namespace
     class Program
    {
        static void Main(string[] args)
        {

            //When creating a LINQ query expression there are 3 parts
            //This applies to all LINQ query opertations
            //1. Obtain the data source
            //2. Create the query
            //3. Execute the query

            //1. Data Source
            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};

            //2. Query Creation
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            Console.WriteLine("Result of using LINQ query expression");
            //3. Query Execution
            foreach (var num in numQuery) 
            {
                Console.WriteLine(num);
            }

            //Now using the LINQ method to acheive the above
            //Will still follow the 3 steps
            //1. Data Source >>> numbers collection
            //2. Query creation
            //3. Query Execution

            //Method Syntax
            var numQueryMethod = numbers.Where(num  => num % 2 == 0);

            Console.WriteLine("Result of the LINQ Method Query");
            foreach (var num in numQueryMethod)
            {
                Console.WriteLine(num);
            }

            //Query 2 - Order numnbers in descending order
            //LINQ query expression
            //1. Obtain the data source
            //2. Create the query
                var orderedNumbersQuery = from num in numbers
                                          orderby num descending //query behaviour
                                          select num;
            //3. Execute the query
            Console.WriteLine("Numbers in Descending Order LINQ Query Expression:");
            foreach (var num in orderedNumbersQuery) 
            {
                Console.WriteLine(num);
            }

            //LINQ method
            var orderedNumberMethodQuery = numbers.OrderByDescending(num => num);
            Console.WriteLine("Numbers in Descending Order LINQ Method:");
            foreach (var num in orderedNumberMethodQuery)
            {
                Console.WriteLine(num);
            }

            //LINQ query expression
            //1. Select numbers that are greater 5 (6,7,8,9,10)
            var numGreaterThanFiveQuery = from num in numbers //data source
                                          where num > 5 //query criteria
                                          select num; //return of result
            Console.WriteLine("Filter Query: Greater than 5: LINQ Expression");
            foreach (var num in numGreaterThanFiveQuery) 
            {
                Console.WriteLine(num);
            }

            //Linq method for the above query 
            var numGreaterThanFiveMethod = numbers.Where(num => num > 5);
            Console.WriteLine("Filter Query: Greater than 5: LINQ Method");
            foreach (var num in numGreaterThanFiveMethod)
            {
                Console.WriteLine(num);
            }

            //2. Select the first 5 numbers (1,2,3,4,5)
            //LINQ Query Expression
            var firstFiveNum = (from num in numbers
                                select num).Take(5);
            Console.WriteLine("Filter Query: First 5 elements in collection: LINQ Expression");
            foreach (var num in firstFiveNum)
            {
                Console.WriteLine(num);
            }
            //LINQ method expression
            var fisrtFiveNumMethod = numbers.Take(5);
            Console.WriteLine("Filter Query: First 5 elements in collection: LINQ Method Expression");
            foreach (var num in firstFiveNum)
            {
                Console.WriteLine(num);
            }



        }
    }
}

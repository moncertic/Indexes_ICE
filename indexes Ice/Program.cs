namespace indexes_Ice
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Ingredients ing = new Ingredients(50, "BUNP011", "cheese", "Cheese Burger", "seseme");

            ing[2] = "Cheese Burger";
            Console.WriteLine(ing[0]);

            Console.WriteLine(ing[1]);

            Console.WriteLine(ing[2]);

            Console.WriteLine(ing[3]);

            Console.WriteLine(ing[4]);

            ing["price"] = 215.00;

            Console.WriteLine("Employee number " + ing["itemnum"]);
            Console.WriteLine("Employee Title " + ing["toppings"]);
            Console.WriteLine("Employee Name " + ing["itemname"]);
            Console.WriteLine("Employee Surname " + ing["buntype"]);
            Console.WriteLine("Employee Salary " + ing["price"]);





        }
    }
}

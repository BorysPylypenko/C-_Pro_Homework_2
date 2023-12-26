using C__Pro_Homework_2.Task_1__Money_;
using C__Pro_Homework_2.Task_2__Instruments_;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using C__Pro_Homework_2.Task_3__Structure_;

class Program
{
    static void Main()
    {

        // TASK #1

        //try
        //{
        //    Console.Write("Enter the name of product: ");
        //    string? name = Console.ReadLine();

        //    if (string.IsNullOrEmpty(name))
        //    {
        //        throw new Exception("Need enter product name!");
        //    }

        //    Console.WriteLine("Enter product cost: First dollars, Second cents");
        //    Console.Write("Dollars: ");            

        //    if (int.TryParse(Console.ReadLine(), out int dollars) == false)
        //    {
        //        throw new Exception("Need enter correct type of number!");
        //    }

        //    Console.Write("Cents: ");
            
        //    if (int.TryParse(Console.ReadLine(), out int cents) == false)
        //    {
        //        throw new Exception("Need enter correct type of number!");
        //    }
        //    Console.WriteLine("-----------------------");

        //    Money initialPrice = new Money(dollars, cents);

        //    Product product = new Product(initialPrice, name);

        //    Console.WriteLine("Initial information of product.");
        //    product.DisplayProduct();
        //    Console.WriteLine("-----------------------");

        //    Console.WriteLine("Enter value of discont: First dollars, Second cents");
        //    Console.Write("Dollars: ");            

        //    if (int.TryParse(Console.ReadLine(), out dollars) == false)
        //    {
        //        throw new Exception("Need enter correct type of number!");
        //    }


        //    Console.Write("Cents: ");            

        //    if (int.TryParse(Console.ReadLine(), out cents) == false)
        //    {
        //        throw new Exception("Need enter correct type of number!");
        //    }
        //    Console.WriteLine("-----------------------");

        //    Money reduseValue = new Money(dollars, cents);

        //    product.ReducePrice(reduseValue);
        //    Console.WriteLine("-----------------------");

        //    Console.WriteLine("Product price after discont.");
        //    product.DisplayProduct();
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        /////////////////////////////////////


        // TASK # 2

        //Violin violin = new Violin("Violin", "String instrument");
        //Trombone trombone = new Trombone("Trombone", "Brass instrument");
        //Cello cello = new Cello("Cello", "Large String instrument");
        //Ukulele ukulele = new Ukulele("Ukulele", "String instrument");

        //violin.Show();
        //violin.Desk();
        //violin.History();
        //violin.Sound();

        //Console.WriteLine("------------");

        //trombone.Show();
        //trombone.Desk();
        //trombone.History();
        //trombone.Sound();

        //Console.WriteLine("------------");

        //cello.Show(); 
        //cello.Desk(); 
        //cello.History();
        //cello.Sound();

        //Console.WriteLine("------------");

        //ukulele.Show();
        //ukulele.Desk();
        //ukulele.History();
        //ukulele.Sound();

        /////////////////////////////////////////////


        // TASK # 3

        //try
        //{
        //    Console.WriteLine("Enter number:");            

        //    if (int.TryParse(Console.ReadLine(), out int value) == false)
        //    {
        //        throw new Exception("Need enter correct type of number!");
        //    }

        //    DecimalNumber number = new DecimalNumber(value);

            
        //    Console.WriteLine($"Binary representation: {number.ToBinary()}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Octal representation: {number.ToOctal()}");
        //    Console.WriteLine();
        //    Console.WriteLine($"Hex representation: {number.ToHex()}");

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }
}
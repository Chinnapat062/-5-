using System;

namespace ข้อสอบข้อ5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayofweek;
            int timeofday;
            Console.WriteLine("input day 1-7")
                dayofweek = int.Parse(Console.ReadLine());
            Console.WriteLine("input time 8-18");
                timeofday = int.Parse(Console.ReadLine());
            Console.WriteLine("which menu");
            
            string order = Console.ReadLine();
            int Breakfast =  5 ;
            int weekend =  2 ;
            int coffee =  3 ;

            do
            {
                switch (order)
                {
                    case "Breakfast Set":
                        Breakfast - 1;
                        break;
                    case "Weekend Set":
                        weekend - 1;
                        break;
                    case "Coffee":
                        coffee - 1;
                        break;
                    case "End":
                        return;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu");
                        break;
                }
                if (Breakfast = 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                    return;
                }
                else if (weekend = 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                    return;
                }
                else if (coffee = 0)
                {
                    Console.WriteLine("Sorry your order is out of stock");
                    return;
                }
            } while (true);

            if (timeofday > 11 && order == "Breakfast Set") ;
            {
                Console.WriteLine("Sorry your order is not available");
                return;      
            }
            else if (order == "Weekend Set" && dayofweek == 1 || order == "Weekend Set" && dayofweek == 2 || order == "Weekend Set" && dayofweek == 3 || order == "Weekend Set" && dayofweek == 4 || order == "Weekend Set" && dayofweek == 5) ;
            {
                Console.WriteLine("Sorry your order is not available");
                return;
            }
        }
    }
}

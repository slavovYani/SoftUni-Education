using System;

namespace _7._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            double totalAmount = 0;

            while (input!="Start")
            {

                switch (input)
                {
                    case "1":
                        totalAmount += 1;
                        break;
                    case "2":
                        totalAmount += 2;
                        break;
                    case "0.5":
                        totalAmount += 0.5;
                        break;
                    case "0.2":
                        totalAmount += 0.2;
                        break;
                    case "0.1":
                        totalAmount += 0.1;
                        break;

                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;
                }
                input = Console.ReadLine();
            }
            double productsPrice = 0;
            while (input!="End")
            {

               switch (input)
               {
                case "Nuts":
                    productsPrice = 2;
                       
                    break;
                case "Water":
                    productsPrice = 0.7;
                       
                    break;
                case "Crisps":
                    productsPrice = 1.5;
                        
                    break;
                case "Soda":
                    productsPrice = 0.8;
                       
                    break;
                case "Coke":
                    productsPrice = 1;
                       
                    break;
                    case "Start":
                        break;
                

                default:
                    Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;

                input = Console.ReadLine();
               }


                if (totalAmount>=productsPrice&& input!="Start")
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    totalAmount -= productsPrice;
                }
                else if(totalAmount<productsPrice)
                {
                    
                    Console.WriteLine("Sorry, not enough money");
                }
                
                input = Console.ReadLine();
            
            }
            Console.WriteLine($"Change: {totalAmount:f2}");


        }
    }
}

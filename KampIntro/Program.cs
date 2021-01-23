using System;
using System.Linq;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pants = { "red pants", "yellow pants", "green pants", "black pants", "white pants" };
            string[] tshirts = { "red tshirts", "yellow tshirts", "green tshirts", "black tshirts", "white tshirts" };
            string[] jackets = { "red jackets", "yellow jackets", "green jackets", "black jackets", "white jackets" };
            string[] trousers = { "red trousers", "yellow trousers", "green trousers", "black trousers", "white trousers" };
            string[] shoes = { "red shoes", "yellow shoes", "green shoes", "black shoes", "white shoes" };

            string[] products = pants.Concat(tshirts).Concat(jackets).Concat(trousers).Concat(shoes).ToArray();
            string[] prices = { "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $", "50 $" };

            int counter = 1;

            for(int k = 0; k < products.Length; k++)
            {
                Console.WriteLine(k + 1 + ") " + products[k] + "        " + prices[k]);
            }

            Console.WriteLine("Please enter a product code you wanna buy: ");
            string val;
            val = Console.ReadLine();
            int code = Convert.ToInt32(val);

              do
             {
                switch (code)
                {
                    case 1:
                        Console.WriteLine("1x "+ products[code-1] + " added.");
                        break;
                    case 2:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 3:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 4:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 5:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 6:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 7:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 8:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 9:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 10:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 11:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 12:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 13:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 14:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 15:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 16:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 17:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 18:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 19:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 20:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 21:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 22:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 23:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 24:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    case 25:
                        Console.WriteLine("1x " + products[code - 1] + " added.");
                        break;
                    default:
                        Console.WriteLine("Wrong code detected..");
                        break;

                }
                break;

             }while (true) ;



        }
    }
}

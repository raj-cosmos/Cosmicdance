using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string userdecision = "";
            int totalcost = 0;
            int UserSize = 0;
            do
            {
                do
                {
                    Console.WriteLine("Please select your coffee size: 1 - Small, 2- Med, 3 - Large");
                UserSize = int.Parse(Console.ReadLine());



                
                    switch (UserSize)
                    {
                        case 1:
                            totalcost += 1;
                            break;

                        case 2:
                            totalcost += 2;
                            break;

                        case 3:
                            totalcost += 3;
                            break;
                        default:
                            Console.WriteLine("please select a valid choice");
                            break;
                    }
                } while (UserSize != 1 && UserSize != 3 && UserSize != 3);

                do
                {
                    Console.WriteLine("do wish to buy one more? Yes or No");
                    userdecision = Console.ReadLine().ToLower();

                    if (userdecision != "yes" && userdecision != "no")
                        Console.WriteLine("please enter yes or no");


                } while (userdecision != "yes" && userdecision != "no");
            } while (userdecision == "yes");


            Console.WriteLine("total cost = {0}", totalcost);
            

        }
    }
}

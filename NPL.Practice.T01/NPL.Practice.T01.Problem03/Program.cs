using System;

namespace NPL.Practice.T01.Problem03
{
    class Program
    {
        public static int n;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PhoneBookManagement p = new PhoneBookManagement();
            int choice = -1;
            do
            {
                Console.WriteLine("----Menu Options----");
                Console.WriteLine("1. Add Employees---------");
                Console.WriteLine("2. Remove Employees------");
                Console.WriteLine("3. Sort Employees By Name");
                Console.WriteLine("4. Find Employees By Name");
                Console.WriteLine("5. Exit------------------");
                Console.Write("Enter your selection: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        p.Add();
                        while (true)
                        {
                            Console.Write("1 keep adding 0 back to home screen");
                            n = int.Parse(Console.ReadLine());
                            if (n == 1)
                            {
                                p.Add();
                            }
                            else
                            {
                                p.Display();
                                break;
                            }
                        }
                        break;

                    case 2:
                        p.Remove();
                        break;
                    case 3:
                        p.Sort();

                        break;
                    case 4:
                        p.Find();

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 5);
            Console.ReadKey();
        }
    }
}


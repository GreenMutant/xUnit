using System;

namespace Kalkylator2
{
    public class program
    {

        public static void Menu()
        {
            Console.WriteLine("Kalkylatorn 1.0\n");

            Console.WriteLine("(a) addition");
            Console.WriteLine("(s) subtraktion");
            Console.WriteLine("(m) multiplikation");
            Console.WriteLine("(d) division");
            Console.WriteLine("(e) elevation\n");

            Console.WriteLine("Tryck (enter) för att starta. (q) för att avsluta.\n");

        }
        public static int Operation(int val)

        {
            string inmat;

            Console.WriteLine("Operation (a),(s),(m),(d),(e):");
            inmat = Console.ReadLine();

            if (inmat == "a")
            { val = 1; }

            if (inmat == "s")
            { val = 2; }

            if (inmat == "m")
            { val = 3; }

            if (inmat == "d")
            { val = 4; }

            if (inmat == "e")
            { val = 5; }

            return val;
        }

        public static double[] Addition(double[] numArr)
        {
            numArr[2] = numArr[0] + numArr[1];
            return numArr;
        }
        public static double Addition(double tal1, double tal2)
        {
            double summa = tal1 + tal2;
            return summa;
        }

        public static double[] Subtraktion(double[] numArr)
        {
            numArr[2] = numArr[0] - numArr[1];
            return numArr;
        }

        public static double Subtraktion(double tal1, double tal2)
        {
            double summa = tal1 - tal2;
            return summa;
        }

        public static double Multiplikation(double tal1, double tal2)
        {
            double summa = tal1 * tal2;
            return summa;
        }

        public static double Division(double tal1, double tal2)
        {

            double summa;

            if ((tal1 == 0) || (tal2 == 0))
            {
                summa = 0;
            }
            else

                summa = tal1 / tal2;
            return summa;
        }

        public static double Elevation(double tal1, double tal2)
        {
            double summa = Math.Pow(tal1, tal2);
            return summa;
        }

        static void Main(string[] args)
        {
            int menu = 0;
            bool quit = true;
            int action = 0;
            string inmat = "noll";
            double summa = 0;
            double[] talArr = new double[2];


            if (menu == 0)
            {
                Menu();
            }

            do
            {
                if (menu == 1)
                {
                    Menu();
                    Console.WriteLine("\nSenaste:" + summa + "\n");
                }

                inmat = Console.ReadLine();
                if (inmat == "q")
                {
                    quit = false;
                }

                else
                {

                    Console.WriteLine("Mata in ett tal:");
                    double tal1 = Convert.ToDouble(Console.ReadLine());
                    talArr[0] = tal1;

                    action = Operation(action);

                    Console.WriteLine("Mata in ett tal:");
                    double tal2 = Convert.ToDouble(Console.ReadLine());
                    talArr[1] = tal2;

                    switch (action)
                    {
                        case 1:

                            summa = Addition(tal1, tal2);
                            Console.WriteLine("\n" + tal1 + " + " + tal2 + " = " + summa);
                            break;

                        case 2:

                            summa = Subtraktion(tal1, tal2);
                            Console.WriteLine("\n" + tal1 + " - " + tal2 + " = " + summa);
                            break;

                        case 3:

                            summa = Multiplikation(tal1, tal2);
                            Console.WriteLine("\n" + tal1 + " * " + tal2 + " = " + summa);
                            break;

                        case 4:

                            summa = Division(tal1, tal2);
                            if (summa == 0)
                            {
                                Console.WriteLine("Ogiltigt");
                            }
                            else
                                Console.WriteLine("\n" + tal1 + " / " + tal2 + " = " + summa);
                            break;

                        case 5:

                            summa = Elevation(tal1, tal2);
                            Console.WriteLine(tal1 + " ^ " + tal2 + " = " + summa);
                            break;

                    }

                    Console.WriteLine("\nTryck (enter) Return.");

                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key.Equals(ConsoleKey.Enter))
                    {
                        Console.Clear();
                        menu = 1;
                    }
                }
            }
            while (quit == true);

            Environment.Exit(0);
        }
    }

}


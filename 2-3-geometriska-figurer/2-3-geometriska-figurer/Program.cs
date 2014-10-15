using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    class Program
    {

        public enum ShapeType { none, Rectangle, Ellipse };
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                ViewMenu();
                int input;
                
                if (int.TryParse(Console.ReadLine(), out input) && input >= 0 && input <= 2)
                    {
                        switch (input)
                        {
                            case 0:
                                Console.WriteLine();
                                return;
                            case 1:
                                ViewShapeDetail(CreateShape(ShapeType.Ellipse));
                                break;
                            case 2:
                                ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                                break;
                        }


                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You need to enter a number between 0 and 2!\nPress any key to continue, ESC exits       ");
                        Console.ResetColor();
                    }
               

            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            //Skapar nya lokala variabler.
            double length;
            double width;
            Shape shape;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║   {0,25}                    ║", shapeType);
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();

            length = ReadDoubleGreaterThanZero("Type in the Length: ");
            width = ReadDoubleGreaterThanZero("Type in the Width: ");


          
            if (shapeType == ShapeType.Ellipse)
            {
                return shape = new Ellipse(length, width);
            }
                return shape = new Rectangle(length, width);            
        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            string input;
            double number;

            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                
                try
                {
                    number = Double.Parse(input);
                    if (number < 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL! {0} Är mindre än noll.", input);
                        Console.ResetColor();
                    }
                    return number;
                }
                catch (FormatException)
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! {0} Är !", input);
                    Console.ResetColor();
                    }
              }
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║         What form would you like to use?       ║");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(" 0 - Exit\n 1 - Ellipse\n 2 - Rectangle");
            Console.WriteLine("=======================================");
            Console.Write("Enter your choice [0-2]: ");
        }

        private static void ViewShapeDetail(Shape shapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                   Detaljer                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine(shapeType.ToString());


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press Any Key To Make A New Calculation.\nESC Exits.");
            Console.ResetColor();
        }
    }
}

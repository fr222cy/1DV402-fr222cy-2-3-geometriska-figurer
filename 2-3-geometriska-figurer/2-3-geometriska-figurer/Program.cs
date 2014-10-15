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
        
       
            ViewMenu();
            
            exit = false;
            int input;
            ShapeType whatShape;


            while (true)
            {
                
               
                if (int.TryParse(Console.ReadLine(), out input) && input >= 0 && input <= 2)
                
                {
                    switch (input)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            whatShape = ShapeType.Ellipse;
                            CreateShape(whatShape);
                            break;
                        case 2:
                            whatShape = ShapeType.Rectangle;
                            CreateShape(whatShape);
                            break;
                    }
                }
            }


        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            //Skapar nya lokala variabler.
            double length;
            double width;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║      {0,12}                              ║", shapeType);
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();

            length = ReadDoubleGreaterThanZero("Ange längd:");
            width = ReadDoubleGreaterThanZero("Ange bredd:");

          

            switch (shapeType)
            {

                case ShapeType.Ellipse:
                    return new Ellipse(length, width);
                    
                case ShapeType.Rectangle:
                    return new Rectangle(length, width);

                default:
                    throw new NotImplementedException();
            }

        }

        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            string input;
            double number;

            Console.Write(prompt);

            input = Console.ReadLine();
            number = Double.Parse(input);
            while (true)
            {
                try
                {


                if (number <= 0)
                {
                    throw new ArgumentException();
                }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0} Är inte ett giltigt tal eller nummer!", input);
                    Console.ResetColor();
                }
                return number;
            }
               
            

        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                ║");
            Console.WriteLine("║              Geometriska Figurer               ║");
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

            
        }
    }
}

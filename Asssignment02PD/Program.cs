/*
 * Name: Parth Vinodbhai Darji
 * Course: Software Quality Assurance
 * Purpose: Unit testing
 * Revision History
 *      Created at Feb 08, 2022 by Parth Darji
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment02PD
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            int selectMenu;
            bool loop = true;
            Console.Write("\n\n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write("This Program is to get Area and Perimeter for Rectangle size\n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write("\n\n");


            Console.Write("Please enter the length: ");
            while (!int.TryParse(Console.ReadLine(), out length) || length < 0)
            {
                Console.WriteLine("Please Enter a valid positive integer value!");
                Console.Write("Please enter the length: ");

            }

            Console.Write("Please enter the width: ");
            while (!int.TryParse(Console.ReadLine(), out width) || width < 0)
            {
                Console.WriteLine("Please Enter a valid positive integer value!");
                Console.Write("Please enter the width: ");

            }
            Console.Clear();

            
            Rectangle rect = new Rectangle(length, width);
            while (loop)
            {
                Console.Write("\n\n");
                Console.Write("1. Get Rectangle Length\n" +
                "2. Change Rectangle Length\n" +
                "3. Get Reactang Width\n" +
                "4. Change Rectangle Width\n" +
                "5. Get Rectangle Perimeter\n" +
                "6. Get Rectangle Area\n" +
                "7. Exit\n" +
                "Please SELECT the NUMBER from the above MENU: ");
                while (!int.TryParse(Console.ReadLine(), out selectMenu))
                {
                    Console.WriteLine("Please Enter a valid integer value!");
                    Console.Write("Please SELECT the NUMBER from the above MENU: ");
                }
                Console.WriteLine();
                switch (selectMenu)
                {
                    case 1:
                        Console.WriteLine($"Length is: {rect.GetLength()}");
                        break;
                    case 2:
                        Console.Write("Please enter new length: ");
                        while (!int.TryParse(Console.ReadLine(), out length))
                        {
                            Console.WriteLine("Please Enter a valid integer value!");
                            Console.Write("Please enter new length: ");
                        }
                        rect.SetLength(length);
                        break;
                    case 3:
                        Console.WriteLine($"Length is: {rect.GetWidth()}");
                        break;
                    case 4:
                        Console.Write("Please enter new width: ");
                        while (!int.TryParse(Console.ReadLine(), out width))
                        {
                            Console.WriteLine("Please Enter a valid integer value!");
                            Console.Write("Please enter new width: ");
                        }
                        rect.SetLength(width);
                        break;
                    case 5:
                        int perimeterResult;
                        perimeterResult = rect.GetPerimeter();
                        Console.WriteLine($"Rectangle Perimeter is: {perimeterResult}");
                        break;
                    case 6:
                        int areaResult;
                        areaResult = rect.GetArea();
                        Console.WriteLine($"Rectangle Area is: {areaResult}");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        //To display invalid options
                        Console.WriteLine();
                        Console.WriteLine("\" " + selectMenu + " \" is not in the Menu option. Please select between 1 to 7");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}

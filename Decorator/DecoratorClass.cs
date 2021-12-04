using Decorator.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DecoratorClass
    {
        internal static void Run()
        {

            Console.WriteLine("Decorator Design");

            // Draw Menu
            Console.WriteLine("Decorate Text");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select a Tag-Style   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Show finished text");
            Console.WriteLine("B: Add Bold");
            Console.WriteLine("C: Add Deleted");
            Console.WriteLine("D: Add Emphasized");
            Console.WriteLine("E: Add Important");
            Console.WriteLine("F: Add Inserted");
            Console.WriteLine("G: Add Italic");
            Console.WriteLine("H: Add Marked");
            Console.WriteLine("I: Add Smaller");
            Console.WriteLine("J: Add SubScript");
            Console.WriteLine("K: Add SuperScript");
            Console.WriteLine("X: Quit Program");

            Console.WriteLine("Please enter the text");

            var decor = Factory.CreateText();

            decor.SetUserInput();

            var newdecor = decor;

            while (true)
            {

                Console.WriteLine("Add a tag style or press A for finished: ");
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine($"Decorated text: {decor.GetTextInput()}");
                        decor = newdecor;
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Add Bold text");
                        decor = new Bold(decor);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Add Deleted text");
                        decor = new Deleted(decor);
                        break;

                    case 'd' or 'D':
                        Console.WriteLine("Add Emphasized text");
                        decor = new Emphasized(decor);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Add Important text");
                        decor = new Important(decor);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Add Inserted text");
                        decor = new Inserted(decor);
                        break;

                    case 'g' or 'G':
                        Console.WriteLine("Add Italic text");
                        decor = new Italic(decor);
                        break;

                    case 'h' or 'H':
                        Console.WriteLine("Add Marked text");
                        decor = new Marked(decor);
                        break;
                    case 'i' or 'I':
                        Console.WriteLine("Add Smaller text");
                        decor = new Smaller(decor);
                        break;
                    case 'j' or 'J':
                        Console.WriteLine("Add SubScript text");
                        decor = new SubScript(decor);
                        break;

                    case 'k' or 'K':
                        Console.WriteLine("Add SuperScript text");
                        decor = new SuperScript(decor);
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}

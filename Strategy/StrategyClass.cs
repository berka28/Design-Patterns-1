using Strategy.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class StrategyClass
    {


        public static void Run()
        {

            MessageHandler MessageHandler = new MessageHandler();
            FaceBook FaceBookMessage = new FaceBook();
            Epost Epost = new Epost();
            Sms Sms = new Sms();

            var message = "This is the message";

            // Draw Menu
            Console.WriteLine("Welcome To MessageHandler");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select messagetyp to send   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("S: Sms");
            Console.WriteLine("F: Facebook Message");
            Console.WriteLine("E: Email");
            Console.WriteLine("X: Exit Program");

            while (true)
            {
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 's' or 'S':

                        Console.Write("Using SMS");
                        MessageHandler.Message = Sms;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'f' or 'F':

                        Console.Write("Using Facebook");
                        MessageHandler.Message = FaceBookMessage;
                        MessageHandler.SendMessage(message);
                        break;

                    case 'e' or 'E':

                        Console.Write("Using Email");
                        MessageHandler.Message = Epost;
                        MessageHandler.SendMessage(message);
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

using Strategy.Message;
using Strategy.MessageTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Application : IApplication
    {
        public IMessage Message { get; set; }

        public IMessageTypes Email { get; set; }

        public IMessageTypes Facebook { get; set; }

        public IMessageTypes SMS { get; set; }

        public Application(IMessage message, IEmail email, IFacebook facebook, ISMS sms)
        {
            Message = message;
            Email = email;
            Facebook = facebook;
            SMS = sms;
            message.MessageTypes = Email;
        }

        public void Run()
        {
            Console.WriteLine("Choose which type to send your message");
            Console.WriteLine("---------------------");
            Console.WriteLine("S: Send message");
            Console.WriteLine("1: Send Email message");
            Console.WriteLine("2: Send Facebook message");
            Console.WriteLine("3: Send SMS message");
            Console.WriteLine("Q: Quit");

            while (true)
            {
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 's' or 'S':
                        Message.Send();
                        break;

                    case '1':
                        Console.Write("Send Email message");
                        Message.MessageTypes = Email;
                        break;

                    case '2':
                        Console.Write("Send Facebook message");
                        Message.MessageTypes = Facebook;
                        break;

                    case '3':
                        Console.Write("Send SMS message");
                        Message.MessageTypes = SMS;
                        break;

                    case 'q' or 'Q':
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

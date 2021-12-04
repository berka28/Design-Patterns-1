using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class Application : IApplication
    {
        public IDataRepository DataRepository { get; set; }

        public Application(IDataRepository dataRepository)
        {
            DataRepository = dataRepository;
        }

        public void Run()
        {
            
            Console.WriteLine("S: Start");
            Console.WriteLine("1: Get animal");
            Console.WriteLine("2: Get customer");
            Console.WriteLine("3: Get data");
            Console.WriteLine("E: Exit Program");

            //Main Game Loop
            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 's' or 'S':
                      
                        Console.WriteLine(DataRepository.GetAllData());
                        break;

                    case 'e' or 'E':
                       
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;
                    case '1':
                       
                        Console.WriteLine(DataRepository.GetAnimal());
                        break;
                    case '2':
                      
                        Console.WriteLine(DataRepository.GetCustomer());
                        break;
                    case '3':
                       
                        Console.WriteLine(DataRepository.GetData());
                        break;

                    default:
                       
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}

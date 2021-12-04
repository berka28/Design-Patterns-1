using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class RegularText : IRegularText
    {
        public string TextInput { get; set; }

        public RegularText()
        {
            TextInput = "";
        }

        public string GetTextInput()
        {
            return TextInput;
        }

        public void SetUserInput()
        {
            bool validInput = false;
            while (!validInput)
            {
                string userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    TextInput = userInput;
                }
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TextDecorator : IText
    {
        public IText Text { get; set; }
        public string StartTag;
        public string EndTag;

        public TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetTextInput()
        {
            return StartTag + Text.GetTextInput() + EndTag;
        }

        public void SetUserInput()
        {
            throw new NotImplementedException();
        }
    }
}

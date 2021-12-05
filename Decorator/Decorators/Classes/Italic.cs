using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Italic : TextDecorator, IItalic
    {
        public Italic(IText text) : base(text)
        {
            StartTag = "<i>";
            EndTag = "</i>";
        }
    }
}

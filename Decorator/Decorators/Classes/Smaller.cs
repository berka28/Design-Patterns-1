using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Smaller : TextDecorator, ISmaller
    {
        public Smaller(IText text) : base(text)
        {
            StartTag = "<small>";
            EndTag = "</small>";
        }
    }
}

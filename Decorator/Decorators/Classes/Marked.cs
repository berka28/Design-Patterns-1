using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Marked : TextDecorator, IMarked
    {
        public Marked(IText text) : base(text)
        {
            StartTag = "<mark>";
            EndTag = "</mark>";
        }
    }
}

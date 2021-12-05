using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class Inserted : TextDecorator, IInserted
    {
        public Inserted(IText text) : base(text)
        {
            StartTag = "<ins>";
            EndTag = "</ins>";
        }
    }
}

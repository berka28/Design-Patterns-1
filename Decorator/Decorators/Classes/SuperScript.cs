using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class SuperScript : TextDecorator, ISuperScript
    {
        public SuperScript(IText text) : base(text)
        {
            StartTag = "<sup>";
            EndTag = "</sup>";
        }
    }
}

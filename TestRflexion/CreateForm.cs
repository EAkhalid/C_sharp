using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_Reflexion
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class CreateForm : Attribute
    {
        public string Name { get; set; }
        public int Number { get; set; }
        
    }
}

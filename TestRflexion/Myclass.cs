using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRflexion
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class Myclass : Attribute
    {
        public string Name { get; set; }
        public int Number { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestRflexion
{
    [Myclass(Name ="class2",Number =2)]
    public class A
    {
        [View(form ="TextBox",length =200,name ="Name")]
        public string Name { get; set; }
        [View(form = "Number", name = "Age")]
        public int Age { get; set; }
        [View(form = "TextArea", length = 400, name = "Description")]
        public string Description { get; set; }
        public A() { }
        public A (string name, int age, string description)
        {
            Name = name;
            Age = age;
            Description = description;
        }
        
    }
}

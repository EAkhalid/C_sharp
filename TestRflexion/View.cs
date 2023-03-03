using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_Reflexion
{
    [AttributeUsage (AttributeTargets.Property)]
    public class View :Attribute
    {
        public string name { get; set; }
        public int lblWidth { get; set; }
        public int lblheigth { get; set; }
        public int size { get; set; }
        public int length { get; set; }
        public string type { get; set; }
        public string[] items { get; set; }

        public View(string name, int length, string type)
        {
            this.name = name;
            this.length = length;
            lblWidth = 100;
            lblheigth = 25;
            this.type = type;
        }
        public View(string name, int lblWidth, int lblheigth, int length,string type, int size) 
        {
            this.name = name;
            this.lblWidth = lblWidth;
            this.lblheigth = lblheigth;
            this.length = length;
            this.type = type;
            this.size = size;
        }

        public View(string type) {
            length = 10;
            lblWidth = 100;
            lblheigth = 25;
            this.type = type;
        }
        public View() { }
        

    }
}

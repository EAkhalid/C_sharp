using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Annotation_Reflexion;

namespace Models
{
    [CreateForm(Name ="Person Form",Number =0)]
    public class Person 
    {
        [View(name = "Status", type = "ComboBox", items = new string[] { "Mlle", "Mme","Mr" }, lblheigth = 25, lblWidth = 150,size =300)]
        public string Status { get; set; }
        [View(name ="Name",length =150,lblheigth =25,lblWidth =150,type = "TextBox",size =300)]
        public string Name { get; set; }
        [View(name = "Cin", length = 150, lblheigth = 25, lblWidth = 150, type = "TextBox",size =50)]
        public string Cin { get; set; }
        [View(name = "Sex",type = "RadioButton",items =new string[] {"M","F"},lblheigth =25,lblWidth =150)]
        public char Sex { get; set; }
        [View(name = "Adress", length = 150, lblheigth = 20, lblWidth = 150, type = "TextArea", size = 300)]
        public string Adress { get; set; }
        public Person() { }
        public Person(string status, string name, string cin, char sex, string adress)
        {
            Status = status;
            Name = name;
            Cin = cin;
            Sex = sex;
            Adress = adress;
        }
        public string ToString()
        {
            return this.Name + " " + this.Cin + " " + this.Sex;
        }
    }
}

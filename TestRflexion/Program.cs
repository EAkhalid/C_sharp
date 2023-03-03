using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_Reflexion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //A t = new A();
            var am = Assembly.GetExecutingAssembly();
            IEnumerable<Type> classes = am.GetExportedTypes().Where(ta => ta.IsClass);
            foreach(Type c in classes)
            { 
                MemberInfo classInfo =c;
                if(c.IsDefined(typeof(CreateForm), false) == true)
                {
                    foreach (object attrib in classInfo.GetCustomAttributes(true))
                    {
                        Console.WriteLine("Attribute Value: " + ((CreateForm)attrib).Name);
                        Console.WriteLine("Attribute Value: " + ((CreateForm)attrib).Number);
                    }
                }
                
            }

            /*foreach (PropertyInfo p in t.GetType().GetProperties())
            {
                // for every property loop through all attributes
                foreach (Attribute a in p.GetCustomAttributes(false))
                {
                    View v = (View)a;
                    Console.WriteLine("attribute " + a.GetType().Name + " " + v.name + " " + v.form);
                   
                }
            }*/
            Console.ReadKey();
        }
    }
}

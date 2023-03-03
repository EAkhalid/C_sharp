using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DictionnaryManagement <T>
    {
        public T Value { get; set; }
        private Dictionary<string, T> myDictionnaire;
        public DictionnaryManagement()
        {
            this.myDictionnaire = new Dictionary<string, T>();
        }
        public DictionnaryManagement(T value)
        {
            this.Value = value;
            this.myDictionnaire = new Dictionary<string, T>();
        }
        public int AddPerson(string key ) {
            int tmp = 0;
            if (!myDictionnaire.ContainsKey(key))
            {
                myDictionnaire.Add(key,Value);
                tmp = 1;
            }
            return tmp;
        }
        public int RemovePerson(string key)
        {
            int tmp = 0;
            if (myDictionnaire.ContainsKey(key))
            {
                myDictionnaire.Remove(key);
                tmp = 1;
            }
            return tmp;
        }
        public T FindPerson(string key)
        {
            
            if (myDictionnaire.ContainsKey(key))
            {
                return myDictionnaire[key];
            }
            else
            {
                return default(T);
            }
           
          
        }

        public int NbrPersonne()
        {
            return this.myDictionnaire.Count();
        }
    }
}

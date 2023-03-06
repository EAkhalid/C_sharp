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
        private IDictionary<string, T> myDictionary;
        public DictionnaryManagement()
        {
            this.myDictionary = new Dictionary<string, T>();
        }
        public DictionnaryManagement(T value)
        {
            this.Value = value;
            this.myDictionary = new Dictionary<string, T>();
        }
        public int AddPerson(string key ) {
            int tmp = 0;
            if (!myDictionary.ContainsKey(key))
            {
                myDictionary.Add(key,Value);
                tmp = 1;
            }
            return tmp;
        }
        public int RemovePerson(string key)
        {
            int tmp = 0;
            if (myDictionary.ContainsKey(key))
            {
                myDictionary.Remove(key);
                tmp = 1;
            }
            return tmp;
        }
        public T FindPerson(string key)
        {
            
            if (myDictionary.ContainsKey(key))
            {
                return myDictionary[key];
            }
            else
            {
                return default(T);
            }
           
          
        }

        public int NbrPersonne()
        {
            return this.myDictionary.Count();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc4_泛型反射
{
    class dictionary<T,V>
    {
        Hashtable ht = new Hashtable();

        public V this[T key]
        {
            get { return (V)ht[key]; }
            set { ht[key] = value; }
        }

        public void Add(T t,V v)
        {
            ht.Add(t, v);
        }

        public ICollection<T> GetKeys()
        {
            List<T> list = new List<T>();
            foreach (T item in ht.Keys)
            {
                list.Add(item);
            }
            return list;
        }

        public int Count
        {
            get { return ht.Count; }
        }

    }
}

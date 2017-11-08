using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc4_泛型反射
{
    class MyDictionary<T,V>
    {
        Hashtable ht = new Hashtable();

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public V this[T key]
        {
            get
            {
                return (V)ht[key];
            }
            set
            {
                ht[key] = value;
            }
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(T key,V value)
        {
            ht.Add(key, value);
        }

        /// <summary>
        /// 获得所有的键
        /// </summary>
        /// <returns></returns>
        public ICollection<T> Keys()
        {
            List<T> keysList = new List<T>();
            foreach (T key in ht.Keys)
            {
                keysList.Add(key);
            }
            return keysList;
        }


        public int Count()
        {
            return ht.Count;
        }

    }
}

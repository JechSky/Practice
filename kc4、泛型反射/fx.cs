using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc4_泛型反射
{
    class fx<T>
    {
        int growth = 1;
        int index = 0;
        T[] arr;
        T[] arrNew;

        public fx()
        {
            arr = new T[growth];
        }

        public void Add(T num)
        {
            if(index>=arr.Length)
            {
                arrNew = new T[index+1];// T[arr.Length + growth];
                arr.CopyTo(arrNew, 0);
                arr = arrNew;
            }
            arr[index] = num;
            index++;
        }

         
        public T this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
            
        }

        public int Count
        {
            get { return arr.Length; }
        }


    }
}

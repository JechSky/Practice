using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc4_泛型反射
{
    class MyTestG<T>
    {
        //const 
        int growth = 1;
        int index = 0;
        T[] arr;
        T[] arrNew;
        public MyTestG()
        {
            arr = new T[growth];
        }

        /// <summary>
        /// 新增元素
        /// </summary>
        /// <param name="num"></param>
        public void Add(T num)
        {
            if(index>=arr.Length)
            {
                arrNew = new T[arr.Length + growth];
                arr.CopyTo(arrNew, 0);
                arr = arrNew;
            }
            arr[index] = num;
            index++;
        }

        /// <summary>
        /// 下标索引器，取值
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i]= value;
            }
        }

        public int Count()
        {
            return arr.Length;
        }


    }
}

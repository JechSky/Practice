using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kc
{
    class Program
    {
        static readonly int A = B * 10;
        static readonly int B = 10;

        static void Main(string[] args)
        {
            Program p = new kc.Program();

            #region 控制台

            //00*   1(2i-1)   2(n-i)    1(i)
            //0***  3           1       2
            //****  4           0       3

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 0; j < 3-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //} 

            //1*1=1
            //2*1=2 2*2=4
            //3*1=3 3*2=6   3*3=9
            //4*1=4 4*2=8   4*3=12  4*4=16
            //5*1=5 5*2=10  5*3=15  5*4=20  5*5=25

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region for循环 ||

            //for (int j = 0, i = 0; j < 3 && i < 5; j++, i++)
            //{
            //    //Console.WriteLine(j); // 0 1 2
            //    Console.WriteLine(i + " " + j);//0 1 2
            //}

            //for (int j = 0, i = 0; j < 3 || i < 5; j++, i++)
            //{
            //    //Console.WriteLine(j); // 0 1 2 3 4
            //    Console.WriteLine(i + " " + j);//0 1 2 3 4
            //}

            #endregion

            #region 运算符

            // & 与  对应位相同 值为1
            // | 或  对应位有一个为1 值为1
            // ^ 异或 对应为相同值为0，不同值为1.
            // << 左移    左移多少位*2的多少次方
            // >> 右移    右移多少位/2的多少次方

            #region 异或交换值

            //a1 = a ^ b
            //b = b ^ a1 = b ^ a ^ b = a
            ////此时a1=a^b
            //a = a1 ^ b = a ^ b ^ a = b
            //注意：
            //a = a ^ b ^ (b = a);//此类形式是不正确的UB行为，在不同编译器中会有不同的结果，切勿使用
            //这样就完成了a与b的交换。
            //综上：同一变量与另一变量和其异或值异或等于另一个数，如（a ^ b）^ a = b。
            //用例：可使用于加密算法某一环节或更多环节，使算法更复杂，不易被破解，安全性更高。 

            //int a = 1, b = 2;
            //a = a ^ b;
            //b = b ^ a;
            //a = a ^ b;
            //Console.WriteLine("a:{0},b:{1}", a, b);

            //int[] arr = new int[] { 1, 2};
            //arr[0] = arr[0] ^ arr[1];
            //arr[1] = arr[1] ^ arr[0];
            //arr[0] = arr[0] ^ arr[1];
            //Console.WriteLine("{0},{1}",arr[0],arr[1]);

            //原码

            //反码

            //补码

            //移码 左移 *2的n次方  右移 /2的n次方
            //int a = 1;
            //Console.WriteLine(a << 3); 

            #endregion

            #endregion


            #region 1、字符串驻留性 恒定性

            //字符串恒定性：当字符串在内存中已经被创建后，程序员再次创建相同值的字符串对象时，clr做了优化，直接把第一个字符串的引用赋给了第二个变量。
            //string str2 = str + str1;
            //string str4 = "123" + "45";
            //注意：如果代码里是直接将两个字符串相加，那么在clr编译il时，就会直接将相加拼接后的新字符串作为变量的值。
            //如果代码里是将两个字符串变量相加的话，那么clr会在编译il时调用string.Concat(string,string)方法来拼接两个字符串变量的值，最终返回一个新的字符串变量。

            //string aa = "1";
            //string ab = aa;
            //ab = "2";
            //Console.WriteLine(ab);


            //string str = "123";
            //string ss = "123";
            //string str1 = "45";
            //string str2 = str + str1;
            //string str4 = "123" + "45";
            //string str3 = "12345";
            ////Equals 比较值
            ////ReferenceEquals 比较对象实例
            //Console.WriteLine(str == ss);
            //Console.WriteLine(str=="123");
            //Console.WriteLine( ReferenceEquals(ss,str));
            //Console.WriteLine(str2 == str3);//true
            //Console.WriteLine(ReferenceEquals(str2, str3));//false
            //Console.WriteLine(ReferenceEquals(str4, str3));//true


            //  == 
            //1、如果比较的是值类型，则比较两个对象的值。
            //2、如果比较的是引用类型，则比较两个对象的引用是否相同(堆地址是否相同)。

            //Equals  
            //1、此方法是object类里的虚方法。string.Equals 默认用==进行比较。
            //2、但是大部分微软的类及用户自定义的类都重写了该虚方法，也就是微软和用户各自为自己编写的Object的子类定义了相等比较规则。

            //person p1 = new person("1",10);
            //person p2 = new person("1",10);
            //if(p1==p2)
            //{

            //}
            //Console.WriteLine("{0}",p1.Equals(p2));

            //str.ToCharArray();
            //str.ToLower();
            //str.ToUpper();
            //str.Equals();
            //str.IndexOf(''); //查找某个字符串在一个特定字符串对象里的下标
            //str.Split('');//分割字符串
            //string.Join("", new object[] { });//数组里添加字符串
            //string.Format(""); //格式化字符串
            //string.IsNullOrEmpty(); //判断字符串null或空
            //StringBuilder //修改字符串不会创建新的对象

            //string strArr = "safd sf sd";
            //string[] arr = strArr.Split(' ');
            //StringBuilder sb = new StringBuilder();
            //foreach (string item in arr)
            //{
            //    //追加字符串
            //    sb.Append(item);
            //}
            //sb.Insert(3, "000");
            ////sb.Remove(1, 2);
            //sb.Replace("000","111");
            //Console.WriteLine(sb.ToString());



            #endregion

            #region 2、值类型、引用类型

            #region 值类型、引用类型 理论

            //值类型：int、double、bool、结构、枚举
            //引用类型：class、string、数组、委托、接口
            //内存分配：值类型：栈。引用类型：地址在栈上，对象在堆上。
            //值传递时：值类型：值的副本。引用类型：地址。
            //装箱：值类型转引用类型。
            //拆箱：引用类型转值类型。

            #endregion



            //int i = 0, j = 1;
            //object o = (object)i;
            //i = 2;
            //j = (int)o;
            //o = 3;
            //int m = (int)o;
            //Console.WriteLine("i={0},j={1},o={2},m={3}", i, j, o, m);

            //引用类型包含值类型
            //A a = new A() { a = 1, b = 2 };
            //A a1 = a;
            //a1.a = 2;
            //Console.WriteLine("{0},{1}", a.a, a1.a);

            //值类型包含引用类型
            //b bObj = new b();
            //bObj.name = "1";
            //b bObj1 = new b();
            //bObj1 = bObj;
            //bObj1.name = "2";
            //Console.WriteLine(bObj.name);

            #endregion

            #region 3、枚举

            //有时为了固定一个变量的“范围”，也方便程序员的使用，可以使用枚举
            //枚举语法 [public] enum 枚举名{成员1，成员2...} 使用：声明--赋值--使用

            //Console.WriteLine(Convert.ToInt32( BuyType.Normal ));
            //数值转成枚举项 强转
            //Console.WriteLine((BuyType)1 );
            //Console.WriteLine(Convert.ToInt32( BuyType.Dis9) );

            #endregion

            #region 4、类和结构

            #region 理论

            //类型：结构：值类型 类：引用类型
            //声明的语法：class struct

            //类new 1、在堆中开辟空间。2、堆中创建对象。3、调用构造函数初始化。
            //结构new的对象在栈中开辟空间。
            //结构的new只做了一件事情：调用结构的构造函数。

            //构造函数相同点：无论是结构还是类，本身会有一个默认的无参的构造函数。
            //不同点：
            //1、类可以继承。结构不能继承。
            //2、在类中写了一个新的构造函数后，默认的无参构造函数就没有了。
            //在结构中写了一个新的构造函数，默认的无参构造函数依然存在。
            //3、在类中，构造函数可以重载。
            //结构中，构造函数要给全部字段、属性赋值。

            //如果只是单独存储数据，推荐使用结构。
            //如果想用面向对象的思想开发程序，推荐使用类。结构并不具备面向对象的特征。

            #endregion

            //PersonStruct ps = new PersonStruct();
            //ps.M2();
            //PersonStruct.M1();

            #endregion

            #region 5、ref out

            //int a=1;
            //int b;
            //p.test(ref  a,out  b);

            #endregion

            #region 6、const readonly

            #region const readonly 理论

            //1.const在编译时是可被完全计算的，所以不会出现const int a = b + 1; 这样的声明，而readonly是在计算时执行的（用到时才确定值），可以添加一个运算来确定他的初始值。
            //    如msdn中的列子：public static readonly uint timeStamp = (uint)DateTime.Now.Ticks;
            //2.const默认是静态的，而readonly不是。

            #endregion

            //testconstreadonly test = new kc.testconstreadonly();
            //Console.WriteLine(test.value2);

            //Console.WriteLine("A is {0},B is {1} ", A, B);

            #endregion

            #region 7、try catch finally return
            //try { }里有一个return语句，那么紧跟在这个try后的finally { } 里的代码会不会被执行，什么时候被执行?
            //会执行，在return前执行。
            //Console.WriteLine(aa());
            //Console.WriteLine(p.GetPerson().Age);

            //public int QueryCount()
            //{  
            //    try
            //    {
            //        return cmd.ExecuteScalar();
            //    }
            //    finally
            //    {
            //        cmd.Dispose();
            //    }
            //}

            //先执行cmd.ExecuteScalar()，把返回值暂时存起来，然后再去执行finally（钱放在这，我去劫个色），然后把返回值返回。return都是最后执行，但是return后的表达式的计算则是在finally之前。
            //如果C#设计的是先执行cmd.Dispose()再执行return就会出现return执行失败了，因为cmd已经Dispose了。

            #endregion

            #region 8、递归

            //Console.WriteLine(p.test(0));
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(p.test(i));
            //}
            //Console.WriteLine(p.jc(4));

            #endregion

            #region 9、排序

            //int[] vec = new int[] { 3, 0, 1, 11, 10, 3, 0, 2, 1 };
            ////p.select(vec);
            ////p.mp(vec);
            ////p.QuickSort(vec, 0, vec.Length - 1);
            ////p.quicksort(vec, 0, vec.Length - 1);
            ////p.QuickSort1(vec, 0, vec.Length - 1);
            //p.heapSort(vec);
            //foreach (int item in vec)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 10、集合

            #region 集合 理论

            //string.Empty  static readonly空字符串 特定的静态运行时空字符串 不会被回收。
            //foreach只能读取数据，不能修改。  yield  
            //try catch   DivideByZeroException 除零catch
            //Stopwatch w1=new Stopwatch(); w1.Elapsed  -- 消耗时间


            //常用操作 添加、遍历、移除
            //命名空间System.Collections
            //ArrayList可变长度数组，使用类似于数组
            //属性Capacity（集合众可以容纳元素的个数，翻倍增长）;
            //Count(集合中实际存放的元素的个数。)

            //方法
            //Add() AddRange(lcollection c) RemoveAt() Clear()
            //Contains() ToArray() Sort()排序\Reverse()反转
            //Hashtable 键值对的集合，类似于字典，Hashtable在查找元素的时候，速度很快。

            //    Add(Object key, object value);
            //    hash["key"]
            //    hash["key"] = "修改";
            //	  .ContainsKey("key");

            //    Remove("key");
            //    遍历；
            //hash.Keys;
            //hash.Values/DictionaryEntry

            #region ArrayList

            //object里的Equals比较的是地址
            //默认ArrayList删除元素时，使用的是Object的Equals方法，比较的是两个元素的地址。
            //而重写Equals后，比较的是重写后的方法。
            //capacity 容量
            //一旦扩容不会改变

            //ArrayList真正储存数据的是Object[]数组

            //ArrayList al=new ArrayList();
            //al.add(1);//第一次添加数据时，object数组被初始化成4个长度的数组对象。
            //al.add(1);
            //al.add(1);
            //al.add(1);
            //al.add(1);//容量已满，进行扩容，数组长度*2。
            //al.add(1);


            #region 索引器

            //public class MyCollection
            //{
            //private ArrayList arr = new ArrayList();
            //public void Add(object o)
            //{
            //    arr.Add(o);
            //}
            //public object this[int index]
            //{
            //    get { return arr[index]; }
            //}
            //public object this[string key]
            //{
            //    get { return arr[0]; }
            //}
            //}

            //MyCollection m = new MyCollection();
            //m.Add(0);
            //m.Add("aa");
            //object o = m[0];
            //object obj = m["aa"];

            #endregion

            #endregion

            #region HashTable

            //bucket[] 数组存储数据
            //IDictionaryEnumerator
            //DictionaryEntry  --  value

            //[SturctLayout(LayoutKind.Sequential)]
            //private struct bucket
            //{
            //  public object key; -- 键
            //  public object value; -- 值
            //  public int hash_coll; -- 对象的hash码
            //}

            //Hash算法：能够快速定位对象。
            //Hash码是通过当前对象hash算法得出来。

            //Hashtable储存元素时，是根据key的hash值%数组长度求来的一个下标

            //1、hashtable里的键是不可重复的，当我们向hashtable中add元素时，
            //元素储存在hashtable数组里的下标是根据key的hash值算出来的
            //（但因为hash值取模数组长度，所以肯定不会超过当前数组长度。）
            //2、注意：每个对象算出的HashCode并不是唯一的，有可能出现多个对象的HashCode相同。
            //解决机制：2.1再次hash一次。2.2桶装模式，将两个相同hashcode的对象装入同一个位置。
            //3、当新增时，HashTable里的容器数组已经满了，则以数组的两倍长度扩容。
            //4、当我们从HashTable里取元素时（根据key来取），会根据key的hash值算出要取的元素的下标，
            //并且比较元素里的key和当前要找的key参数的hash值是否相等，同时还要比较两个key的引用是否一致。如果都满足，则确定找到要取的元素。

            #endregion



            #region linq

            //Where 过滤；延迟
            //Select  选择；延迟
            //Distinct    查询不重复的结果集；延迟
            //Count   返回集合中的元素个数，返回INT类型；不延迟
            //LongCount   返回集合中的元素个数，返回LONG类型；不延迟
            //Sum 返回集合中数值类型元素之和，集合应为INT类型集合；不延迟
            //Min 返回集合中元素的最小值；不延迟
            //Max 返回集合中元素的最大值；不延迟
            //Average 返回集合中的数值类型元素的平均值。集合应为数字类型集合，其返回值类型为double；不延迟
            //Aggregate   根据输入的表达式获取聚合值；不延迟

            #endregion

            #endregion

            #region 集合中字母出现的次数

            //string str = "Welcome to Chinaworld";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //string strNew = str.ToLower();
            //Regex reg = new Regex("^\\s*$");
            //if(!string.IsNullOrEmpty(strNew)&&!reg.IsMatch(strNew))
            //{
            //    for (int i = 0; i < strNew.Length; i++)
            //    {
            //        if(string.IsNullOrEmpty(strNew[i].ToString()))
            //        {
            //            continue;
            //        }
            //        if(dic.ContainsKey(strNew[i]))
            //        {
            //            dic[strNew[i]]++;
            //        }
            //        else
            //        {
            //            dic[strNew[i]]= 1;
            //        }

            //    }
            //    foreach (KeyValuePair<char,int> item in dic)
            //    {
            //        Console.WriteLine("字母{0}出现了{1}次",item.Key,item.Value);
            //    }
            //}

            #endregion


            //Union //并集
            //Intersect //交集
            //Except //差集

            #endregion

            #region 11、深浅拷贝

            //浅表拷贝：得到一个与原始对象类型、值相同的新实例。如果字段是引用类型，该引用被拷贝，而不是拷贝引用的对象。
            //深层拷贝：包含对象直接或间接引用的对象的所有拷贝。

            //对象X引用对象A，对象A引用对象M。对象X的“浅表”克隆对象Y，同样也引用了对象A。相对比的是，对象X的“深层”克隆对象Y，却直接引用了对象B，并且间接引用对象N，这里，对象B是对象A的拷贝，对象N是对象M的拷贝。

            //X引用A引用M
            //浅表Y 引用A
            //深层Y 直接引用B（对象A的拷贝）间接引用N（对象N的拷贝）

            //X - A - M
            //浅表Y - A
            //深层Y - B(A的拷贝) - N(N的拷贝)

            testClone tt = new testClone() { testint = 1, teststr = "aa" };
            testClone tc = (testClone)tt.Clone();
            Console.WriteLine(tc.teststr);
            
            testClone tc1 = (testClone)p.DeepCopy(tt);
            Console.WriteLine(tc1.teststr);

            #endregion
        }

        #region 11、深浅拷贝

        [Serializable]
        class testClone
        {
            public int testint { get; set; }
            public string teststr { get; set; }
            public Object Clone()
            {
                return (Object)this.MemberwiseClone();
            }
        }

        object DeepCopy(object src)
        {
            BinaryFormatter formatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, src);
                stream.Position = 0;
                return formatter.Deserialize(stream);
            }
        }
        
        #endregion

        public class PersonClass
        {
            //字段、属性、方法、构造函数
            string str = "";
            int age { get; set; }

            public void person()
            {
                str = "0";
                age = 10;
            }
            public void person(string name)
            {

            }

        }

        public struct PersonStruct
        {
            string name;
            int age;
            char gender;

            string str { get; set; }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    age = value;
                }
            }

            public char Gender
            {
                get
                {
                    return gender;
                }

                set
                {
                    gender = value;
                }
            }
            
            public static void M1()
            {
                Console.WriteLine("结构中的静态方法");
            }
            public void M2()
            {
                Console.WriteLine("结构中的非静态方法");
            }

            public PersonStruct(string name,int age,char gender)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
                this.str = "00";
            }

        }

        public enum BuyType
        {
            //如果为第一个赋值了，后面的枚举项依次递增。
            Normal=1,
            Dis8=1,
            Dis9,
            Cut1=5
        }
      
        class person
        {
            string name;
            int age;
            public person(string name,int age)
            {
                this.name = name;
                this.age = age;
            }
            public override bool Equals(object obj)
            {
                person anotherPerson = obj as person;
                return this.name == anotherPerson.name && this.age == anotherPerson.age;
            }
        }

        #region Sort

        //选择排序又叫简单你选择排序。基本思想是每一趟从待排序的数据元素中选出最小（或最大）的一个元素，顺序放在已排好的数列的最后。直到全部待排序的数据元素排完。
        //选择排序法的排序过程：
        //1、初始状态下无序区为R[0,n-1]，有序区为空。
        //2、第一趟排序在无序区R[0,n-1]中选出关键字最小的记录R[k]，将它与无序区的第一个记录R[0]交换，使R[0,0]变为有序区，R[1，n-1]变为记录个数减少1个的新无序区。
        //3、当第i趟排序开始时，当前有序区和无序区分别为R[0,i-2]和R[i-1,n-1]。该趟排序从当前无序区中选出关键字最小的记录R[k]，将它与无序区的第一个记录R[i-1]交换，这样R[0,i-1]和R[i,n-1]分别为记录个数增加1个的新有序区和记录个数减少1个的新无序区。
        //4、当进行了n-1次查找最小（最大）并交换的操作后，n个记录的文件直接选择排序可经过n-1趟直接选择排序得到有序数列。
        /// <summary>
        /// 选择排序   取出最小索引，后交换值
        /// 最好情况时间复杂度 O(n)  平均条件下时间复杂度O(n²)  最坏条件下时间复杂度O(n²)  辅助空间O(1)  稳定性 不稳定
        /// </summary>
        /// <param name="list"></param>
        void select(int[] list)
        {
            int min = 0;
            for (int i = 0; i < list.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    int temp = 0;
                    temp = list[i];
                    list[i] = list[min];
                    list[min] = temp;
                }
            }

        }

        // 基本思想：顺序地将待排序的记录按关键码的大小插入到已排序的记录子序列的适当位置。子序列的记录个数从1开始逐渐增大，当子序列的记录个数与顺序表中的记录个数相同时排序完毕。
        // 设待排序的顺序表list中有n个记录，初始时子序列中只有一个记录list[0]。第一次排序时，准备把记录list[1]插入到已排好序的子序列中，这时只需要比较list[0]和list[1]的大小，若list[0]<=list[1]，说明序列已有序，否则将list[1]插入到list[0]的前面，这样子序列的大小增大为2。
        // 第二次排序时，准备把记录list[2]插入到已排好序的子序列中，这需要先比较list[2]和list[1]以确定是否需要把list[2]插入到list[1]之前。如果list[2]插入到list[1]之前，再比较list[2]和list[0]以确定是否需要把list[2]插入到list[0]之前。这样的过程一直进行到list[n-1]插入到子序列中为止。
        /// <summary>
        /// 直接插入排序
        /// 时间复杂度：最好：o(n) 平均：o(n²) 最坏：o(n²) 
        /// 空间复杂度：o(1)
        /// </summary>
        /// <param name="list"></param>
        void InsertSort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if(list[i]<list[i-1])
                {
                    int temp = list[i];
                    int j = 0;
                    for (j = i-1; j >=0&&temp<list[j]; j--)
                    {
                        list[j + 1] = list[j];
                    }
                    list[j + 1] = temp;
                }
            }
        }

        //n个记录进行冒泡排序的方法：
        //首先将第一个记录的关键字和第二个记录的关键字进行比较，若为逆序，则交换这两个记录的值，然后比较第二个记录和第三个记录的关键字，依此类推，直到第n-1个记录和第n个记录的关键字比较过为止。
        //上述过程称为第一趟冒泡排序，其结果是关键字最大的记录被交换到第n个记录的位置上。然后进行第二趟冒泡排序，对前n-1个记录进行同样的操作，其结果是关键字次大的记录被交换到第n-1个记录的位置上。
        //最多进行n-1趟，所有记录有序排列。若在某趟冒泡排序过程没有进行相邻位置的元素交换处理，则可结束排序过程。
        //冒泡排序法在最好情况下（待排序列已按关键码有序），只需做一趟排序，元素的比较次数为n-1且不需要交换元素，因此总比较次数为n-1次，总交换次数为0次。
        //在最坏情况下（元素已经逆序排列），进行第j趟排序时，最大的j-1个元素已经排好序，其余的n-（j-1）个元素需要进行n-j次比较和n-j次交换，因此总比较次数为n（n-1）/2，总交换次数为n（n-1）/2，
        /// <summary>
        /// 冒泡:每次比较只要相邻两位前者比后者小或者大就交换
        /// 最好情况时间复杂度 O(n)  平均条件下时间复杂度O(n²)  最坏条件下时间复杂度O(n²)  辅助空间O(1)  稳定性 稳定
        /// </summary>
        /// <param name="list"></param>
        void mp(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - i - 1; j++)
                {
                    if (list[j + 1] > list[j])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
                //for (int j = i+1; j < list.Length; j++)
                //{
                //    if(list[i]>list[j])
                //    {
                //        int temp = list[i];
                //        list[i] = list[j];
                //        list[j] = temp;
                //    }
                //}
            }
        }

        /// <summary>
        /// 快速排序
        /// 最好情况时间复杂度 O(n*logn)  平均条件下时间复杂度O(n*logn)  最坏条件下时间复杂度O(n²)  辅助空间O(n*logn)  稳定性 不稳定
        /// </summary>
        /// <param name="list"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        void QuickSort(int[] list, int low, int high)
        {
            if (low < high)
            {
                int pivot, p_pos, i;
                p_pos = low;            // p_pos指向low,即位索引为0位置。
                pivot = list[p_pos];    //将0位置上的数值赋给pivot;
                for (i = low + 1; i <= high; i++)
                {                       //1位置的数与0位置数作比较: a[1]>a[0]
                    if (list[i] > pivot)
                    {
                        p_pos++;        //2位与1位比较,3位与2位比较......
                        //swap(list, p_pos, i);
                    }
                }

                //list[low] = list[low] ^ list[p_pos];
                //list[p_pos] = list[p_pos] ^ list[low];
                //list[low] = list[low] ^ list[p_pos];

                swap(list, low, p_pos);
                QuickSort(list, low, p_pos - 1);
                QuickSort(list, p_pos + 1, high);

            }

        }

        void swap(int[] list, int i, int j)
        {
            int temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        //任意取一个数作为枢纽元素，遍历整个数组，low位索引从前往后，high位索引从后往前，直到low位找到比枢纽大的位置，high找到比枢纽小的位置，交换这两个数据，然后low位索引继续往后，high位索引继续往前遍历。
        //第一趟遍历完后，如果当前high位比低位大，再把低位到当前high位的数据进行上面的遍历交换，如果当前low位比最高位小，再把当前low位到最高位进行前面的遍历交换。最后整个数列就是有序排列了。
        void QuickSort1(int[] pDataNum, int left, int right)
        {
            int i, j, jizhunshu, temp;
            i = left;
            j = right;
            jizhunshu = i; //(i + j) / 2; -- 枢纽数
            do
            {
                while ((pDataNum[i].CompareTo(pDataNum[jizhunshu]) < 0) && i < right)
                {
                    i++;
                }
                while ((pDataNum[j].CompareTo(pDataNum[jizhunshu]) > 0) && j > left)
                {
                    j--;
                }
                if (i <= j)
                {
                    if (pDataNum[i] > pDataNum[j])
                    {
                        temp = pDataNum[i];
                        pDataNum[i] = pDataNum[j];
                        pDataNum[j] = temp;
                    }
                    i++;
                    j--;
                }

            }
            while (i < j);
            if (left < j)
                QuickSort1(pDataNum, left, j);
            if (right > i)
                QuickSort1(pDataNum, i, right);
        }

        #region 堆排序

        //在直接选择中，顺序表是一个线性结构。要从有n个记录的顺序表中选择出一个最小的记录需要比较n-1次。
        //如能把待排序的n个记录构成一个完全二叉树结构，则每次选择出一个最大（或最小）的记录比较的次数就是完全二叉树的高度，即log2 n 次，则排序算法的时间复杂度就是o（nlog2 n）。这就是堆排序（Heap Sort）的基本思想。
        int left(int i)
        {
            return 2 * i;
        }

        int right(int i)
        {
            return 2 * i + 1;
        }

        /// <summary>
        /// 维护最大堆
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="length"></param>
        void maxHeapify(int[] a,int i,int length)
        {
            int l = left(i);
            int r = right(i);
            int max;
            if(l<length&&a[l]>a[i])
            {
                max = l;
            }
            else
            {
                max = i;
            }
            if(r<length&&a[r]>a[max])
            {
                max = r;
            }
            if(max!=i)
            {
                swap(a, i, max);
                maxHeapify(a, max, length);
            }

        }

        /// <summary>
        /// 建堆
        /// </summary>
        /// <param name="a"></param>
        void buildMaxHeap(int[] a)
        {
            for (int i = a.Length / 2 + 1; i >= 0; i--)
            {
                maxHeapify(a, i, a.Length);
            }
        }

        void heapSort(int[] a)
        {
            //建立最大堆，完成后第一个元素为最大值
            buildMaxHeap(a);
            int length = a.Length;
            for (int i = a.Length-1; i >=1; i--)
            {
                //将第一个最大元素移到后面，并且在maxHeapify的过程中通过减小length忽略它。
                swap(a, i, 0);
                length--;
                maxHeapify(a, 0, length);
            }
        }

        #endregion

        #endregion


        #region 5、ref out

        public void test(ref int a, out int b)
        {
            b = 0;
        } 

        #endregion

        #region 7、try catch finally return

        public static int aa()
        {
            try
            {
                return 11;
            }
            catch (Exception)
            {
                Console.WriteLine("catch");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            return 10;
        }

        public Person GetPerson()
        {
            Person p = new Person();
            p.Age = 8;
            try
            {
                p.Age++;
                Console.WriteLine("a");
                return p;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("b");
                p.Age++;
            }
        }

        public class Person
        {
            public int Age { get; set; }
        }
        #endregion

        #region  8、递归

        public int test(int i)
        {
            if (i <= 0)
            {
                return 0;
            }
            else if (i <= 2)
                return 1;
            else if (i == 2)
                return 2;
            else
                return test(i - 1) + test(i - 2);
        }

        public int jc(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * jc(n - 1);
        } 

        #endregion

    }



    public class testconstreadonly
    {
        public const int value1 = 100;
        public readonly int value2 ;
        public testconstreadonly()
        {
            value2 = value1 + 1;
        }

    }


    public struct b
    {
        public string name { get; set; }
    }

    public class A
    {
        public int a = 0;
        public int b = 0;
    }


}

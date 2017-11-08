using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc3_委托事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            #region 1、委托

            #region 委托 理论

            //委托的作用有两个
            //1、将方法作为参数使用
            //   1.1委托里可以包含签名与委托一致的方法。
            //   1.2委托里包含的方法访问权限和委托本身的访问权限无关。
            //   1.3凡是将方法直接赋给委托对象的地方，编译时，都会帮我们使用生成对应的new委托方法。 

            //声明委托目的是为了包装N个相同签名的方法

            //多播委托
            //1、可以向委托上注册多个方法。
            //2、也可以从委托上移出已注册的方法。
            //3、如果委托上注册了多个有返回值的方法，那么调用后委托返回的是最后一个方法的返回值。

            //event关键字的好处
            //1、创建了一个对应的私有委托对象。
            //2、封装了对私有委托对象的外部操作。 

            #endregion

            #region 练习

            #region 两个委托相加

            //SayHi sayHi = new SayHi(p.SayHiInChinese) + new SayHi(p.SayHiInEnglist);
            //// sayHi += p.SayHiInEnglist;
            //sayHi("jingjing");

            #endregion

            #region 处理字符串

            ProcessDelegate pro = new ProcessDelegate(p.ToAddYinHao);
            p.ProcessInArray(pro);

            #endregion

            #region 排序

            List<Person> list = new List<Person>() { new Person() { age=1,name="111"},new Person() { age=0,name="000"} };
            foreach (Person item in list)
            {
                Console.WriteLine("name={0},age={1}", item.name,item.age);
            }
            Comparison<Person> com = new Comparison<Person>(p.Comparison);
            list.Sort(p.Comparison);

            //List<Person> listPerson = new List<Person>()
            //{
            //    new Person() {age=20,name="12" },
            //    new Person() {age=30,name="111" },
            //    new Person() {age=23,name="000" }
            //};
            //foreach (Person item in listPerson)
            //{
            //    Console.WriteLine("name:{0},age:{1}", item.name, item.age);
            //}

            //Comparison<Person> s = new Comparison<Person>(p.Comparison);
            //listPerson.Sort(p.Comparison);

            //Console.WriteLine("排序后：");
            //foreach (Person item in listPerson)
            //{
            //    Console.WriteLine("name:{0},age:{1}", item.name, item.age);
            //}

            #endregion

            #region 取最大值

            //Person[] perArr =
            //{
            //    new Person() {name="111",age=20 },
            //    new Person() {name="000",age=30 },
            //    new Person() {name="aa",age=10 }
            //};

            //Person olestp = p.GetMax<Person>(perArr, p.compareFun<Person>);
            //Console.WriteLine("name:{0},age:{1}", olestp.name, olestp.age); 

            #endregion

            #endregion //练习end

            #endregion //1、委托end



            #region 2、事件

            //p.testEvent += p.testEvent1;
            //p.testEvent += p.testEvent2;

            //p.testEvent();

            #endregion

        }


        #region 两个委托相加

        delegate void SayHi(string name);
        void SayHiInChinese(string name)
        {
            Console.WriteLine(name + "SayHiInChinese");
        }
        void SayHiInEnglist(string name)
        {
            Console.WriteLine(name + "SayHiInEnglist");
        }

        #endregion

        #region 练习处理字符串

        delegate string ProcessDelegate(string strOld);
        string ToUpper(string strOld)
        {
            return strOld.ToUpper();
        } 

        string ToLower(string strOld)
        {
            return strOld.ToLower();
        }

        string ToAddYinHao(string strOld)
        {
            return "\"" + strOld + "\"";
        }

        void ProcessInArray(ProcessDelegate methodPtr)
        {
            string[] values = new string[] { "a", "bD" };
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = methodPtr(values[i]);
            }
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region 排序

        public int Comparison(Person p1, Person p2)
        {
            if (p1.age > p2.age)
            {
                return 1;
            }
            else if (p1.age < p2.age)
            {
                return -1;
            }
            else
                return 0;
        }

        #endregion


        #region 取最大值
         
        delegate int CompareDelegate<T>(T value1, T value2);
        
        T GetMax<T>(T[] objs, CompareDelegate<T> compare)
        {
            T maxObj = objs[0];
            foreach (T obj in objs)
            {
                if (compare(maxObj, obj) < 0)
                {
                    maxObj = obj;
                }
            }
            return maxObj;
        }

        int compareFun<T>(T a,T b)
        {
            Person p1 = a as Person;
            Person p2 = b as Person;
            return p1.age - p2.age;
        }

        #endregion

        delegate void testDelegate();
        event testDelegate testEvent;

        void testEvent1()
        {
            Console.WriteLine("test1");
        }
        void testEvent2()
        {
            Console.WriteLine("test2");
        }


    }
   

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public interface Observer
    {
        void Response();
    }

    public interface Subject
    {
         void Add(Observer obs);
    }


    public class Mouse : Observer
    {
        string name;
        public Mouse(string name,Subject sub)
        {
            this.name = name;
            sub.Add(this);
        }
        public void Response()
        {
            Console.WriteLine(name + " run");
        }
    }

    public class Master:Observer
    {
        public Master(Subject sub)
        {
            sub.Add(this);
        }

        public void Response()
        {
            Console.WriteLine("Host Waken！");
        }
    }

    public class Cat : Subject
    {
        List<Observer> list = new List<Observer>();
        public void Add(Observer obs)
        {
            list.Add(obs);
        }

        public void Cry()
        {
            Console.WriteLine("猫叫");
            foreach (Observer item in list)
            {
                item.Response();
            }
        }

    }



}

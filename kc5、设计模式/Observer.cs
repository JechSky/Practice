using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc5_设计模式
{
    public interface Observer
    {
        void Response();
    }

    public interface Subject
    {
        void AimAt(Observer observer);
    }

    public class Mouse:Observer
    {
        string name;
        public Mouse(string name,Subject subject)
        {
            this.name = name;
            subject.AimAt(this);
        }

        public void Response()
        {
            Console.WriteLine(name+"mouse run!");
        }
    }

    public class Master : Observer
    {
        public Master(Subject subject)
        {
            subject.AimAt(this);
        }

        public void Response()
        {
            Console.WriteLine("Host Waken");
        }
    }

    public class Cat:Subject
    {
        List<Observer> Observers = new List<Observer>();
        public void AimAt(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Cry()
        {
            Console.WriteLine("cat cryed!");
            foreach (Observer item in Observers)
            {
                item.Response();
            }
        }

    }


}

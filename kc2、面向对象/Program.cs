using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kc2_面向对象
{

    #region 方法 父子类 概念

    //重载：方法名必须相同、参数列表必须不同，返回值类型可以相同。
    //重写：方法名、参数列表和返回值都相同。

    //构造函数：和类名相同，如果不写，编译器会自动生成一个无参的构造函数。
    //对象的初始化，不能显示调用，只能在创建时用new来调用。
    //静态构造函数：第一次实例化该类的时候调用，之后不再初始化。一般构造方法每次new该类的时候调用一次。
    //析构函数：对象在销毁时系统自动执行。

    //类：
    //单根性：一个类只能有一个父类。
    //部分类：partial示将类、结构、接口、方法的定义拆分到两个或多个文件中。同一程序集关键字不能相冲。
    //密封类：sealed不能被其他类继承，但可以继承其他类。不能用作基类，因此不能示抽象。防止派生。

    //里氏替换：子类可替换父类位置，父类不能替换子类。
    //子类可重写父类方法：1、如果没有重写，声明的是哪个类型就调用哪个类型的方法。2、如果有重写，无论声明的是哪个类型都调用子类方法。
    //子类可直接调用父类虚方法，也可以重写该虚方法。

   //1.构造函数：
   // 构造函数的主要用来为对象分配存储空间，完成初始化操作（如给类的成员变量赋值等）。
   // 在C#中，类的构造函数遵循以下规定：
   // （1）构造函数的名称和类名相同。
   // （2）当某个类没有构造函数时，系统将自动为其创建默认构造函数。
   // （3）构造函数的访问修饰符总是public。
   // （4）构造函数没有返回值。
   // （5）构造函数可以带参数也可不带参数。
   //构造方法是名字与类名相同的特殊函数，它通常用在new关键字的后面，来完成对象的一些初始化操作。

   // 2.析构函数：
   // 析构函数在对象销毁时被调用，常用来释放对象占用的存储空间。析构函数具有以下特点：
   // （1）析构函数不能带有参数
   // （2）析构函数不能拥有访问修饰符
   // （3）不能显示地调用析构函数
   // （4）析构函数在对象销毁时自动调用

    #endregion

    #region 抽象 抽象类、接口、抽象方法、虚方法

    //抽象的目的：制定规则，约束子类。
    //抽象类：制定规则，约束子类，传递一些特性给子类。（抽象类定义的是公共的实现和能力）
    //抽象类不能被密封
    //抽象类必须为在该类的基类列表中列出接口的所有成员，提供它自己的实现，也可以为虚。
    //但允许抽象类将接口方法映射到抽象方法上。

    //如果抽象类实现接口：
    //则可以把接口中方法映射到抽象类中作为抽象方法，让子类去实现。
    //也可以在抽象类中直接实现该方法。

    //抽象特点：
    //1、需要用abstract关键字标记。
    //2、抽象类不能实例化。抽象类的作用：为了让子类继承。
    //3、抽象类中可以包括抽象成员，可以包括有具体代码的成员。可以有非抽象成员。
    //4、抽象方法不能用static修饰。
    //5、抽象成员必须包含在抽象类中。
    //6、抽象方法不能有任何方法实现/方法体。
    //7、由于抽象成员没有任何实现，所以子类必须将抽象成员重写（除非子类也是抽象类）。
    //一个类只能继承一个抽象类（类的单根继承性）
    //抽象方法是隐式的虚方法；只允许在抽象类中使用抽象方法声明。 

    //静态方法不能标记override、virtual、abstract
    //类不能new的情况：static，构造函数私有化，抽象类

    //为什么抽象方法不能用static修饰？
    //static abstract 不存在
    //static 没有override
    //如果用static修饰，只能被静态类继承,静态类里面没有override。
    //假设有，静态成员也不能new成实例对象，所以抽象方法不能用static修饰。


    //默认访问修饰符protected。
    //类、方法 默认访问修饰符 private。
    //接口 默认public，可加可不加。
    //接口里的成员默认public，不能添加。


    //虚方法，抽象方法
    //父类中如果有方法需要让子类重写，则可以将该方法标记为virtual
    //虚方法在父类中必须有实现，哪怕是空实现。
    //虚方法子类可以重写，也可以不重写。


    //抽象类实现了oop中的一个原则，把可变与不可变分离。
    //抽象类和接口就是定义不可变的，把可变的让子类去实现。


    //接口本质：特殊的抽象类。
    //接口作用：定义规则。降低耦合。
    //IFlyable fly = new Fly();
    //面向接口编程：不关心接口的具体实现，直接通过调用接口方法来完成编码。

    //没有一定关系，侧重单一的某种能力。多继承。没有具体的实现，只有方法声明。
    //可以有 方法、属性、索引器、事件。不能有字段、常量、域、构造函数、析构函数、静态成员。
    //继承类必须实现所有成员。

    //接口不具备继承的任何特点，它仅仅承诺了能够调用的方法。
    //接口支持回调，继承不具备这个特点。

    //接口里没有构造函数
    //抽象类里有构造函数，虽然不能实例化。 

    #endregion

    class Program
    {
        static void Main(string[] args)
        {

            #region 1、初始化顺序

            //Child c = new Child();

            #endregion

            #region 2、父子类 重写

            //重写
            //father f = new father();
            //f.dosth();
            //father do

            //father f = new sun();
            //f.dosth();
            //sun do

            //sun s = new sun();
            //s.dosth();
            //sun do 

            //无重写 new 声明的是谁调用谁
            //father f = new father();
            //f.dosth1();
            //father do1

            //father f = new sun();
            //f.dosth1();
            //father do1

            //sun s = new sun();
            //s.dosth1();
            //sun do1

            #endregion

            #region 3、抽象类

            //MobileStorage ms = new  UDisk();
            ////Computer computer = new Computer();
            ////computer.CpuRead(ms);
            ////computer.CpuWrite(ms);

            //Computer1 computer = new Computer1();
            //computer.Ms = ms;
            //computer.CpuRead();
            //computer.CpuWrite();

            #endregion

            #region 4、接口

            //IFlyable obj = new MaQue();
            //obj.Fly();

            //Bird bird = (Bird)obj;
            //bird.EatAndDrink();

            //new MaQue().EatAndDrink();
            //new MaQue().Fly();


            //Bird1 bd1 = new Bird1();
            //bd1.Fly();

            //IFlyable ifly = new Bird1();
            //ifly.Fly();

            #endregion

            #region 5、抽象类和接口

            xiaohai xh = new xiaohai();
            xh.Run();
            xh.how();

            abserson.Hello();

            #endregion


        }
    }

    #region MyRegion

    public class Base
    {
        static int number = 1;
        int number2 = 2;
        static Base()
        {

        }
        public Base()
        {

        }

    }
    public class Child : Base
    {
        static int number = 1;
        int number2 = 2;
        static Child()
        {

        }
        public Child()
        {

        }

    } 

    #endregion



    interface IFlyable
    {
        void Fly();
    }
    interface ISpeak
    {
        void Speak();
    }

    class Bird
    {
        public double Wings
        { get; set; }
        public void EatAndDrink()
        {
            Console.WriteLine("Bird类会吃喝方法");
        }
    }

    class Bird1 : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟飞的方法");
        }
        void IFlyable.Fly()
        {
            Console.WriteLine("接口的飞方法");
        }
    }

    class MaQue : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }

    class YingWu : Bird, IFlyable, ISpeak
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }

        public void Speak()
        {
            Console.WriteLine("鹦鹉可以学习人说话");
        }
    }


    #region abstract

    abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入");
        }
    }

    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘正在读取");
        }

        public override void Write()
        {
            Console.WriteLine("U盘正在写入");
        }
    }

    class Computer
    {
        public void CpuRead(MobileStorage ms)
        {
            ms.Read();
        }
        public void CpuWrite(MobileStorage ms)
        {
            ms.Write();
        }
    }

    class Computer1
    {
        MobileStorage ms;
        public MobileStorage Ms
        {
            get { return ms; }
            set { ms = value; }
        }

        public void CpuRead()
        {
            ms.Read();
        }
        public void CpuWrite()
        {
            ms.Write();
        }

    } 

    #endregion


}

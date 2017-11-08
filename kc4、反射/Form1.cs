using Mode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kc4_反射
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assembly[] aseArr = AppDomain.CurrentDomain.GetAssemblies();
            //Assembly ase = Assembly.LoadFrom(@"H:\kc\Mode\bin\Debug\Mode.dll");

            //Person person = new Person();
            //Type type = typeof(Person);
            //Type t = person.GetType();
            //FieldInfo[] fields = type.GetFields();
            //MethodInfo[] methods = type.GetMethods();
            //PropertyInfo[] pros = type.GetProperties();

            //IsAssignableFrom 判断testSun是否继承于testFather(类和接口都可以)，实质是判断testSun是否可强转成testFather
            //MessageBox.Show( typeof(testFather).IsAssignableFrom(typeof(testSun)).ToString() );

            //Type typeFather= typeof(testFather);
            //Type typeSun = typeof(testSun);
            //Type typeSun1 = typeof(testSun1);
            //Type typeInter = typeof(testInterfance);
            //Type typeIRun = typeof(IRun);

            //testFather father = new testFather();
            //testSun sun = new testSun();
            //testSun1 sun1 = new testSun1();

            //string isAssign = typeFather.IsAssignableFrom(typeSun).ToString();
            //string isAssignFromInterfance = typeIRun.IsAssignableFrom(typeSun).ToString();
            //string isAssignFromInterfance1 = typeIRun.IsAssignableFrom(typeSun1).ToString();
            //MessageBox.Show(string.Format("{0},{1},{2}",isAssign,isAssignFromInterfance,isAssignFromInterfance1 ) );



            //IsInstanceOfType 判断对象是否是某个type所对应的实例
            //bool isInstance = typeSun.IsInstanceOfType(sun);
            //bool isInstance1 = typeSun.IsInstanceOfType(father);
            //MessageBox.Show(string.Format("{0},{1}", isInstance, isInstance1));

            //IsSubclassOf 判断某个类是否是另一个类的子类，只能用来判断类的继承，不能用来判断接口。
            //bool isSubF= typeSun.IsSubclassOf(typeFather);
            //bool isSubS = typeSun1.IsSubclassOf(typeFather);
            //bool isS = typeInter.IsSubclassOf(typeIRun);
            //MessageBox.Show(string.Format("{0},{1},{2}", isSubF, isSubS,isS));


            //MethodInfo method = typeSun.GetMethod("Shout");
            //MessageBox.Show(method.Invoke(sun, null).ToString() );  //method.Invoke(sun,null));

            //通过方法参数的类型数组来区分重载
            //获得不带参数的Shout方法
            //MethodInfo method1 = typeSun.GetMethod("Shout",new Type[0]);
            //MessageBox.Show(method1.Invoke(sun, null).ToString());  //method.Invoke(sun,null));

            //获得带一个参数的Shout方法
            //MethodInfo methodWidthPara = typeSun.GetMethod("Shout", new Type[] { typeof(string) } );
            //string str=methodWidthPara.Invoke(sun,new object[] { "123"}).ToString() ;
            //MessageBox.Show(str);

            //获得带两个参数的Shout方法
            //MethodInfo methodWidthParas = typeSun.GetMethod("Shout",new Type[] {typeof(string),typeof(int) });
            //MessageBox.Show( methodWidthParas.Invoke(sun, new object[] {"nameparas",111 }).ToString()  ) ;

            //调用私有方法
            //MethodInfo methodPrivate = typeSun.GetMethod("priFunc",BindingFlags.NonPublic|BindingFlags.Instance);
            //MessageBox.Show(methodPrivate.Invoke(sun,null).ToString() );



            //string strClassName = "Mode.Person";
            //Type type1 = ase.GetType(strClassName);
            //// object objNew = Activator.CreateInstance(type1);
            //Person objNew =(Person) Activator.CreateInstance(type1);

            //foreach (FieldInfo item in type1.GetFields())
            //{
            //    MessageBox.Show(item.Name);
            //}

            //PropertyInfo pro = type1.GetProperty("Name");
            //pro.SetValue(objNew, "setNameValue", null);

            //string strproValue = pro.GetValue(objNew, null).ToString();
            //MessageBox.Show(strproValue);

            //MethodInfo method = type1.GetMethod("SayHi");
            //MessageBox.Show(method.Invoke(objNew,new object[1] {"jing" }).ToString() );

            //Person perModel = new Person();
            //changeTypeTToV<object, Person>(objNew, perModel);//changeType<Person>(objNew, typeof(Person)); //(Person)Convert.ChangeType(objNew,typeof( Person));
            //perModel.name = "modelName";
            //perModel.age = 111;
            //perModel.Test = "te";


        }

        //T changeType<T>(object model,Type type)
        //{
        //    T obj = (T)Convert.ChangeType(model, type);
        //    return obj;
        //}

        V changeTypeTToV<T,V>(T entityFrom,V entityTo)
        {
            Type typeFrom = typeof(T);
            Type typeTo = typeof(V);
            PropertyInfo[] prosFrom = typeFrom.GetProperties();
            PropertyInfo[] prosTo = typeTo.GetProperties();
            foreach (var itemFrom in prosFrom)
            {
                foreach (var itemTo in prosTo)
                {
                    if(itemFrom.Name.Equals(itemTo.Name))
                    {
                        itemTo.SetValue(entityTo, itemFrom.GetValue(entityFrom));
                    }
                }
            }
            return entityTo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array array = typeof(testEnum).GetEnumValues();
            foreach (var item in array)
            {
                FieldInfo field = Enum.Parse(typeof(testEnum), item.ToString()).GetType().GetField(item.ToString());
                string des = ((DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute))).Description;
                MessageBox.Show(des);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            PropertyInfo[] infos = typeof(Person).GetProperties();//per.GetType().GetProperties();
            foreach (PropertyInfo item in infos)
            {
                //IsDefined 是否为指定类型的自定义特性随即应用于指定的成员
                if (item.IsDefined(typeof(testAttribute)))
                {
                    MessageBox.Show("Test");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            PropertyInfo[] infos = typeof(Person).GetProperties();//per.GetType().GetProperties();
            foreach (PropertyInfo item in infos)
            {
                //IsDefined 是否为指定类型的自定义特性随即应用于指定的成员
                if (item.IsDefined(typeof(testAttribute)))
                {
                    if (((testAttribute)item.GetCustomAttribute(typeof(testAttribute))).isDisplay)
                    {
                        MessageBox.Show(item.GetValue(per).ToString());
                    }
                    //MessageBox.Show("Test");
                }
            }
        }
    }
}

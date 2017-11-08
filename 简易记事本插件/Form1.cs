using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 插件接口;

namespace 简易记事本插件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAddOn();
        }

        void LoadAddOn()
        {
            //获得当前程序集的路径
            string strAssPath = Assembly.GetExecutingAssembly().Location;
            strAssPath = Path.Combine(Path.GetDirectoryName(strAssPath), "AddOn");

            //加载文件夹里的dll程序集
            //获得所有可用程序集的路径
            string[] strDllPath = Directory.GetFiles(strAssPath,"*.dll");

            //根据程序集里的类，创建类型对象
            //加载可用插件程序集
            Assembly assAddOn;
            //获得插件接口类型
            Type typeIAddOn = typeof(IAddOn);

            //遍历所有插件路径
            foreach (string strPath in strDllPath)
            {
                //加载插件程序集
                assAddOn = Assembly.LoadFrom(strPath);
                //获得程序集中所有类的类型
                Type[] types = assAddOn.GetTypes();

                //循环类型
                foreach (Type ty in types)
                {
                    //判断当前循环类是否实现了插件接口IAddOn
                    if(typeIAddOn.IsAssignableFrom(ty))
                    {
                        //创建接口对象
                        IAddOn addOn = (IAddOn)Activator.CreateInstance(ty);
                        
                        MethodInfo method = ty.GetMethod("WithPara", new Type[] { typeof(string) });
                        string str = method.Invoke(addOn, new object[] { "named" }).ToString();

                        string ss = ty.GetMethod("WithPara").Invoke(addOn, new object[] { "aaa" }).ToString();

                        //创建按钮对象
                        ToolStripItem tsItem = new ToolStripMenuItem(ss); //addOn.Excuteing());
                        //将接口对象存入按钮的Tag中
                        tsItem.Tag = addOn;
                        //将按钮对象加入菜单
                        this.tsmiOperator.DropDownItems.Add(tsItem);
                    }
                }

            }

        }

    }
}

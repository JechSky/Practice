using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class CangKu
    {
        //存储货物
       public static  List<List<ProductFacther>> list = new List<List<ProductFacther>>();

        public CangKu()
        {
            list.Add(new List<ProductFacther>() { new ProductFacther(Guid.NewGuid().ToString(), 10, "Banana", 10) });
            list.Add(new List<ProductFacther>() { new ProductFacther(Guid.NewGuid().ToString(), 20, "JiangYou", 10) });
            list.Add(new List<ProductFacther>() { new ProductFacther(Guid.NewGuid().ToString(), 1000, "Banana", 10) });
        }

        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("超市有：" + item[0].Name + "总共：" + item[0].Inventory + "个" + "\t 每个 " + item[0].Price + "元");
            }
        }

        Dictionary<string, List<string>> prosInfo = new Dictionary<string, List<string>>()
        {
            //货架  名称  单价
            {"Banana",new List<string>() {"0","香蕉","10" } },
            {"JiangYou",new List<string>() {"1","酱油" ,"20"} },
            {"SamSung",new List<string>() { "2","三星笔记本","1000"} }
        };

        public void JinPros(string strType,int Count)
        {
            list[int.Parse(prosInfo[strType][0])].ForEach(p => p.Inventory = (p.Inventory + Count));
        }

        public List<ProductFacther> QuPros(string strType, int count)
        {
            list[int.Parse(prosInfo[strType][0])].ForEach(p => p.Inventory = (p.Inventory - count));

            List<ProductFacther> listQ = new List<ProductFacther>();
            string AssemblyNM = "超市收银系统";
            string classnm = AssemblyNM + "." + strType.ToString();
            Assembly assemblyObj = Assembly.Load(AssemblyNM);

            object[] args = new object[]
            {
                Guid.NewGuid().ToString(),
                Convert.ToDouble(prosInfo[strType][2]),
                prosInfo[strType][1],
                count
            };
            ProductFacther pro = (ProductFacther)assemblyObj.CreateInstance(classnm, true, BindingFlags.Default, null, args, null, null);
            listQ.Add(pro);

            return listQ;
        }


    }
}

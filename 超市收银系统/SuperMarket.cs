using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class SuperMarket
    {
        CangKu ck = new CangKu();

        Dictionary<int, string> dicCalType = new Dictionary<int, string>()
        {
            {1,"CalNormal" },{2,"CalRate" },{3,"CalMN" }
        };

        Dictionary<int, double> dicRate = new Dictionary<int, double>()
        {
            {2,0.9 }
        };

        Dictionary<int, List<int>> dicMN = new Dictionary<int, List<int>>()
        {
            {3,new List<int>() {300,50 } }
        };

        public SuperMarket()
        {
            ck.JinPros("Banana", 200);
            ck.JinPros("JiangYou", 300);
            ck.JinPros("SamSung", 100);
        }

        public void AskBuing()
        {
            Console.WriteLine("现在有Banana，JiangYou，SamSung ");
            Console.WriteLine("请输入需要的商品：");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());

            List<ProductFacther> pros = ck.QuPros(strType, count);

            double realMoney = GetMoney(pros);
            Console.WriteLine("总共应付{0}元",realMoney);
            Console.WriteLine("请选择打折方式：1--不打折  2--打九折  3--满300送50");

            string input = Console.ReadLine();

            CallFather cal = GetCal(int.Parse(input));

            if(cal!=null)
            {
                double totalMoney = cal.GetTotalMoney(realMoney);
                Console.WriteLine("打完折后，您应付{0}元",totalMoney);

                Console.WriteLine("购物信息：");
                foreach (var item in pros)
                {
                    Console.WriteLine("编号：{0}，名称：{1}，单价：{2}", item.ID, item.Name, item.Price);
                }

                Console.WriteLine("仓库信息：");
                foreach (var item in CangKu.list)
                {
                    Console.WriteLine("编号：{0}，名称：{1}，单价：{2}，库存：{3}", item[0].ID, item[0].Name, item[0].Price,item[0].Inventory);
                }

            }

        }

        public CallFather GetCal(int input)
        {
            CallFather cal = null;

            string AssemblyNM = "超市收银系统";
            Assembly AssemblyObj = Assembly.Load(AssemblyNM);
            string classnm = AssemblyNM + "." + (dicCalType[input]).ToString();
            object[] args = null;
            if(input==2)
            {
                args = new object[1];
                args[0] = dicRate[input];
            }
            else if(input==3)
            {
                args = new object[2];
                args[0] = dicMN[input][0];
                args[1] = dicMN[input][1];
            }
            cal = (CallFather)AssemblyObj.CreateInstance(classnm, true, BindingFlags.Default, null, args, null, null);

            return cal;

        }

        public double GetMoney(List<ProductFacther> pros)
        {
            double realMoney = 0;
            realMoney = pros[0].Price * pros[0].Inventory;
            return realMoney;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }



    }
}

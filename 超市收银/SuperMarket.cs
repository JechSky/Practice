using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银
{
    class SuperMarket
    {
        CangKu ck = new CangKu();

        Dictionary<int, string> dicCalType = new Dictionary<int, string>()
        {
            {1,"CalNormal" }, {2,"CalRate" }, {3,"CalMN" }
        };

        Dictionary<int, double> dicRate = new Dictionary<int, double>()
        {
            {2,0.9 }
        };

        Dictionary<int, List<int>> dicMN = new Dictionary<int, List<int>>()
        {
            {3,new List<int> () {300,50 } }
        };

        public void AskBuing()
        {
            Console.WriteLine("现在有商品Banana，JiangYou");
            Console.WriteLine("请输入您需要的商品：");
            string strType = Console.ReadLine();
            Console.WriteLine("需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());

            ProductFather proQ = ck.QuHuo(strType, count);

            double realMoney = GetMoney(proQ);
            Console.WriteLine("总共应付{0}元",realMoney);

            Console.WriteLine("请选择打折方式：1--不打折  2--打九折  3--满300送50");
            string input = Console.ReadLine();
            CallFather cal = GetCal(int.Parse(input));
            if(cal !=null)
            {
                double totalMoney = cal.GetTotalMoney(realMoney);
                Console.WriteLine("打完折后应付：{0}元", totalMoney);

                Console.WriteLine("购物信息：");
                Console.WriteLine("商品名称：{0}，单价：{1}，数量：{2}", proQ.Name, proQ.Price, proQ.Inventory);

                Console.WriteLine("仓库信息：");
                foreach (var item in ck.list)
                {
                    Console.WriteLine("商品名称：{0}，单价：{1}，库存：{2}", item.Name, item.Price, item.Inventory);
                }
            }

        }

        double GetMoney(ProductFather pro)
        {
            return pro.Price * pro.Inventory;
        }

        CallFather GetCal(int input)
        {
            CallFather cal = null;
            string AssemblyNM = "超市收银";
            Assembly AssemblyObj = Assembly.Load(AssemblyNM);
            string classNM = AssemblyNM + "." + dicCalType[input].ToString();
            object[] args = null;
            if (input == 2)
            {
                args = new object[] {
                    Convert.ToDouble(dicRate[input])
                };
            }
            else if(input==3)
            {
                args = new object[]
                {
                    dicMN[input][0],
                    dicMN[input][1]
                };
            }
            cal = (CallFather)AssemblyObj.CreateInstance(classNM, true, BindingFlags.Default, null, args, null, null);
            return cal;
        }

        public void ShowProdcts()
        {
            ck.ShowList();
        }

    }
}

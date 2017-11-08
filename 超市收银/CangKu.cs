using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银
{
    class CangKu
    {
        public  List<ProductFather> list = new List<ProductFather>();

        Dictionary<string, List<string>> prosInfo = new Dictionary<string, List<string>>()
        {
            {"Banana", new List<string>() {"香蕉", "20" } },
            {"JiangYou", new List<string>() {"酱油", "50" } },
        };

        public CangKu()
        {
            list.Add(new ProductFather(Guid.NewGuid().ToString(), "Banana", 20, 10));
            list.Add(new ProductFather(Guid.NewGuid().ToString(), "JiangYou", 50, 80));
        }

        public void ShowList()
        {
            if(list.Count>0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine("现有商品{0}，单价：{1}，库存：{2}",item.Name,item.Price,item.Inventory);
                }
            }
            
        }

        public void JinHuo(string strType,int count)
        {
            list.Where(p => p.Name == strType).ToList().ForEach(p => p.Inventory = p.Inventory + count);
        }

        public ProductFather QuHuo(string strType, int count)
        {
            list.Where(p => p.Name == strType).ToList().ForEach(p => p.Inventory = p.Inventory - count);

            string assemblyNM = "超市收银";
            string classNM = assemblyNM+"."+ strType.ToString();
            Assembly assemblyObj = Assembly.Load(assemblyNM);
            object[] args = new object[]
            {
                Guid.NewGuid().ToString(),
                prosInfo[strType][0],
                Convert.ToDouble( prosInfo[strType][1]),
                count
            };
            ProductFather proQ = (ProductFather)assemblyObj.CreateInstance(classNM, true, BindingFlags.Default,null, args, null, null);

            return proQ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 火车购票
{
    class TrainTickets
    {
        public static List<TrainTicketEntity> list = new List<TrainTicketEntity>();

        Dictionary<int, List<string>> dicTicketInfo = new Dictionary<int, List<string>>()
        {
            {(int)TrainTicketCategoryEnum.G,new List<string>() { "G","500" } },
            { (int)TrainTicketCategoryEnum.D,new List<string>() {"D" ,"300" } },
            { (int)TrainTicketCategoryEnum.Z,new List<string>() {"Z","230" } }
        };

        public TrainTickets()
        {
            list.Add(new TrainTicketEntity() {
                ID = Guid.NewGuid().ToString(),
                CategoryEnum = TrainTicketCategoryEnum.Z,
                No = TrainTicketCategoryEnum.Z + "01",
                PlaceStart = "杭州",
                PlaceArrive= "北京",
                DTStart= DateTime.Now,
                DTArrive= DateTime.Now.AddHours(9),
                Price=Convert.ToDouble(dicTicketInfo[(int)TrainTicketCategoryEnum.Z][1]),
                Inventory=300
            });

            list.Add(new TrainTicketEntity()
            {
                ID = Guid.NewGuid().ToString(),
                CategoryEnum = TrainTicketCategoryEnum.G,
                No = TrainTicketCategoryEnum.G+ "02",
                PlaceStart = "杭州",
                PlaceArrive = "上海",
                DTStart = DateTime.Now,
                DTArrive = DateTime.Now.AddHours(10),
                Price = Convert.ToDouble(dicTicketInfo[(int)TrainTicketCategoryEnum.G][1]),
                Inventory = 100
            });

            list.Add(new TrainTicketEntity()
            {
                ID = Guid.NewGuid().ToString(),
                CategoryEnum = TrainTicketCategoryEnum.D,
                No = TrainTicketCategoryEnum.D + "03",
                PlaceStart = "杭州",
                PlaceArrive = "上海",
                DTStart = DateTime.Now,
                DTArrive = DateTime.Now.AddHours(15),
                Price = Convert.ToDouble(dicTicketInfo[(int)TrainTicketCategoryEnum.D][1]),
                Inventory = 200
            });

        }

        public void ShowTickets()
        {
            if (list.Count > 0)
            {
                Console.WriteLine("目前有票：");
                foreach (var item in list)
                {
                    //string desNM = EnumDescription.GetDescription(item.CategoryEnum);

                    FieldInfo fi = item.CategoryEnum.GetType().GetField(item.CategoryEnum.ToString());
                    DescriptionAttribute desAttr = (DescriptionAttribute)fi.GetCustomAttribute(typeof(DescriptionAttribute));

                    Console.WriteLine("车次：{0}\t类型：{1}\t{2}\t价格：{3}\t数量：{4}", item.No, desAttr.Description, item.TicketName, item.Price, item.Inventory);
                }
            }
        }

        public int SelectTickets(string TicketNo)
        {
            return list.Count(p => p.No.ToLower().Equals(TicketNo.ToLower()));
        }

        public void AddTickets(string TicketNo,int Count)
        {
            list.Where(p => p.No.Equals(TicketNo)).ToList().ForEach(r => r.Inventory += Count);
        }

        public TrainTicketEntity QuTickets(string TicketNo,int Count)
        {
            //TrainTicketEntity tick = list.Where(p => p.No.ToLower().Equals(TicketNo.ToLower())).FirstOrDefault();
            //TrainTicketEntity tickQ = null;
            //if (tick!=null)
            //{
            //    if(tick.Inventory>=Count)
            //    {
            //        tick.Inventory -= Count;
            //        tickQ = tick.Clone();
            //        tickQ.Inventory = Count;
            //    }
            //}

            TrainTicketEntity tick = list.Where(p => p.No.ToLower().Equals(TicketNo.ToLower())).FirstOrDefault();
            tick.Inventory -= Count;
            TrainTicketEntity tickQ = tick.Clone();
            tickQ.Inventory = Count;
            return tickQ;
        }

    }
}

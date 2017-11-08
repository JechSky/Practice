using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 火车购票
{
    class TrainTicketEntity:Base
    {
        public new string ID { get; set; }
        //编号（车次）
        public string No { get; set; }
        //类别
        //public TrainTicketCategory Category { get; set; }
        public TrainTicketCategoryEnum CategoryEnum { get; set; }
        //名称
        public string TicketName { get { return PlaceStart + " -- " + PlaceArrive + "\t" + DTStart + " -- " + DTArrive; }   }
        //出发地点
        public string PlaceStart { get; set; }
        //达到地点
        public string PlaceArrive { get; set; }
        //出发时间
        public DateTime DTStart { get; set; }
        //达到时间
        public DateTime DTArrive { get; set; }
        //价格
        public double Price { get; set; }
        //总票数
        public int Inventory { get; set; }

        public TrainTicketEntity Clone()
        {
            return (TrainTicketEntity)this.MemberwiseClone();
        }
    }



    public enum TrainTicketCategoryEnum
    {
        [Description("高铁")]
        G = 1,
        [Description("动车")]
        D = 2,
        [Description("普通列车")]
        Z = 3
    }

}

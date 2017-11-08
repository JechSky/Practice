using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银
{
    public class ProductFather
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }

        public ProductFather(string id,string name,double price,int inventory)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.Inventory = inventory;
        }

    }
}

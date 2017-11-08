using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    public class ProductFacther
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }

        public ProductFacther(string id,double price,string name,int inventory)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
            this.Inventory = inventory;
        }
        
    }
}

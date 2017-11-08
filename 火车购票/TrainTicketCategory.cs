using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 火车购票
{
    class TrainTicketCategory
    {
        public int CategoryId { get; set; }

        public string CategoryName
        {
            get
            {
                return dicTicketsCategory[CategoryId];
            }
        }

        Dictionary<int, string> dicTicketsCategory = new Dictionary<int, string>()
        {
            {1,"高铁" }, {2,"动车" }, {3,"普通列车" }
        };

    }

}

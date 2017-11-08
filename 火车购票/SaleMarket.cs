using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 火车购票
{
    class SaleMarket
    {
        TrainTickets tickInfo = new TrainTickets();

        public void AskBuing()
        {
            Console.WriteLine("欢迎光临");
            tickInfo.ShowTickets();
            Console.WriteLine("请问您需要购买哪个车次？");

            try
            {
                string strTicketNo = Console.ReadLine();
                if (!string.IsNullOrEmpty(strTicketNo))
                {
                    if(tickInfo.SelectTickets(strTicketNo)>0)
                    {
                        Console.WriteLine("请输入所需张数：");
                        string strCount = Console.ReadLine();
                        int Counts = 0;
                        if(!string.IsNullOrEmpty(strCount) && int.TryParse(strCount,out Counts))
                        {
                            if (CheckCounts(strTicketNo, Counts))
                            {
                                TrainTicketEntity ticket = tickInfo.QuTickets(strTicketNo, Counts);
                                if (ticket != null)
                                {
                                    double realMoney = ticket.Price;
                                    Console.WriteLine("请输入您的身份证号！");
                                    List<string> idCardsList = new List<string>();
                                    string strIdCards = string.Empty;
                                    for (int i = 0; i < Counts; i++)
                                    {
                                        strIdCards = Console.ReadLine();
                                        if (!string.IsNullOrEmpty(strIdCards) && strIdCards.Length >= 15 && strIdCards.Length <= 18)
                                        {
                                            idCardsList.Add(strIdCards);
                                        }
                                        else
                                        {
                                            Console.WriteLine("请输入正确的身份证号！");
                                        }
                                    }
                                    if (idCardsList.Count > 0)
                                    {
                                        double totalMoney = 0.0;
                                        for (int i = 0; i < idCardsList.Count; i++)
                                        {
                                            if (!string.IsNullOrEmpty(idCardsList[i]))
                                            {
                                                CallFather cal = GetCal(idCardsList[i]);
                                                if (cal != null)
                                                {
                                                    double resultMoney = cal.GetTotalMoney(realMoney);
                                                    totalMoney += resultMoney;
                                                    Console.WriteLine("身份证号为：{0}的乘客，您应付{1}元。以下是您的购票信息：", idCardsList[i], resultMoney);
                                                    Console.WriteLine("车次：{0}\t车票信息：{1}\t价格：{2}", ticket.No, ticket.TicketName, resultMoney);

                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("请输入正确的身份证号！");
                                            }

                                        }

                                        Console.WriteLine("");
                                        Console.WriteLine("购票成功！您已成功购买车次为:{0}的票 {1} 张，总共{2}元", ticket.No, ticket.Inventory, totalMoney);
                                        Console.WriteLine("");

                                        tickInfo.ShowTickets();

                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("车票不足！");
                                return;
                            }

                        }
                        else
                        {
                            Console.WriteLine("请输入正确张数！");
                            return;
                        }

                    }
                    else
                    {
                        Console.WriteLine("目前没有该车次！");
                        return;
                    }

                }
                else
                {
                    Console.WriteLine("请输入正确车次！");
                    return;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        bool CheckCounts(string TicketNo,int Count)
        {
            TrainTicketEntity tick = TrainTickets.list.Where(p => p.No.ToLower().Equals(TicketNo.ToLower())).FirstOrDefault();
            if (tick != null)
            {
                if (tick.Inventory >= Count)
                {
                    return true;
                }
            }
            return false;
        }

        //获取折扣率
        CallFather GetCal(string IdCard)
        {
            int rate = (DateTime.Now.Year - int.Parse(IdCard.Substring(6, 4)) < 18) ? (int)CalType.CalRate : (int)CalType.CalNormal;

            #region MyRegion

            CallFather cal = null;
            switch (rate)
            {
                case 0:
                    cal = new CalNormal();
                    break;
                case 1:
                    cal = new CalRate(0.5);
                    break;
                default:
                    break;
            }

            #endregion

            //string AssemblyNM = "火车购票";
            //Assembly AssemblyObj = Assembly.Load(AssemblyNM);
            //string classNM = AssemblyNM + "." + ((CalType)rate).ToString();
            //object[] args = null;
            //if (rate.Equals((int)CalType.CalRate))
            //{
            //    args = new object[1];
            //    args[0] = 0.5;
            //}
            //CallFather cal = (CallFather)AssemblyObj.CreateInstance(classNM, true, BindingFlags.Default, null, args, null, null);
            return cal;
        }

        public enum CalType
        {
            CalNormal=0,
            CalRate=1
        }

        //获取总价
        public double GetMoney(TrainTicketEntity ticket)
        {
            return ticket.Price * ticket.Inventory;
        }

    }
}

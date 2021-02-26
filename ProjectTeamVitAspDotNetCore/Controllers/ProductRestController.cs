using Microsoft.AspNetCore.Mvc;
using ProjectTeamVitAspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTeamVitAspDotNetCore.Controllers
{
    [Route("api/product")]
    public class ProductRestController : Controller
    {
        private JwelleryContext db = new JwelleryContext();

        [HttpGet("findyear")]
        public List<Revenue> findYear()
        {
            List<Revenue> revenues = new List<Revenue>();
            DateTime Current = DateTime.Now;
            List<Order> orderCurrentYears = db.Order.Where(x => x.CreateTime.Year == Current.Year).ToList();
            List<OrderDetail> listOrderDetails = new List<OrderDetail>();
            foreach (Order order in orderCurrentYears)
            {
                List<OrderDetail> orderDetails = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetails.AddRange(orderDetails);
            }
            double Sum = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetails)
            {
                Sum += listOrderDetail.TotalPrice;
            }
            Revenue revenue = new Revenue();
            revenue.Time = "2021";
            revenue.Money = Sum;
            revenues.Add(revenue);
            ///
            List<Order> orderCurrentYears1 = db.Order.Where(x => x.CreateTime.Year == Current.Year-1).ToList();
            List<OrderDetail> listOrderDetails1 = new List<OrderDetail>();
            foreach (Order order in orderCurrentYears1)
            {
                List<OrderDetail> orderDetails1 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetails1.AddRange(orderDetails1);
            }
            double Sum1 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetails1)
            {
                Sum1 += listOrderDetail.TotalPrice;
            }
            Revenue revenue1 = new Revenue();
            revenue1.Time = "2020";
            revenue1.Money = Sum1;
            revenues.Add(revenue1);
            //
            List<Order> orderCurrentYears2 = db.Order.Where(x => x.CreateTime.Year == Current.Year-2).ToList();
            List<OrderDetail> listOrderDetails2 = new List<OrderDetail>();
            foreach (Order order in orderCurrentYears2)
            {
                List<OrderDetail> orderDetails2 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetails2.AddRange(orderDetails2);
            }
            double Sum2 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetails2)
            {
                Sum2 += listOrderDetail.TotalPrice;
            }
            Revenue revenue2 = new Revenue();
            revenue2.Time = "2019";
            revenue2.Money = Sum2;
            revenues.Add(revenue2);


            return revenues;
        }

            [HttpGet("findall")]
        public List<Revenue> findAll()
        {
            List<Revenue> revenues = new List<Revenue>();
            DateTime now = DateTime.Now;

            List<Order> orderT1 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 1).ToList();
            List<OrderDetail> listOrderDetail1 = new List<OrderDetail>();
            foreach (Order order in orderT1)
            {
                List<OrderDetail> orderDetails1 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail1.AddRange(orderDetails1);
            }
            double Sum1 = 0;
            
            foreach (OrderDetail listOrderDetail in listOrderDetail1)
            {
                Sum1 += listOrderDetail.TotalPrice;
            }
            Revenue revenue1 = new Revenue();
            revenue1.Time = "January";
            revenue1.Money = Sum1;
            revenues.Add(revenue1);


            ////
            List<Order> orderT2 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 2).ToList();
            List<OrderDetail> listOrderDetail2 = new List<OrderDetail>();
            foreach (Order order in orderT2)
            {
                List<OrderDetail> orderDetails2 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail2.AddRange(orderDetails2);
            }
            double Sum2 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail2)
            {
                Sum2 += listOrderDetail.TotalPrice;
            }
            Revenue revenue2 = new Revenue();
            revenue2.Time = "February";
            revenue2.Money = Sum2;
            revenues.Add(revenue2);
            ////
            List<Order> orderT3 = db.Order.Where(x=>x.CreateTime.Year == now.Year && x.CreateTime.Month == 3).ToList();
            List<OrderDetail> listOrderDetail3 = new List<OrderDetail>();
            foreach (Order order in orderT3)
            {
                List<OrderDetail> orderDetails3 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail3.AddRange(orderDetails3);
            }
            double Sum3 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail3)
            {
                Sum3 += listOrderDetail.TotalPrice;
            }

            Revenue revenue3 = new Revenue();
            revenue3.Time = "March";
            revenue3.Money = Sum3;
            revenues.Add(revenue3);
            ///
            List<Order> orderT4 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 4).ToList();
            List<OrderDetail> listOrderDetail4 = new List<OrderDetail>();
            foreach (Order order in orderT4)
            {
                List<OrderDetail> orderDetails4 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail4.AddRange(orderDetails4);
            }
            double Sum4 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail4)
            {
                Sum4 += listOrderDetail.TotalPrice;
            }
            
            Revenue revenue4 = new Revenue();
            revenue4.Time = "April";
            revenue4.Money = Sum4;
            revenues.Add(revenue4);
            ///
            List<Order> orderT5 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 5).ToList();
            List<OrderDetail> listOrderDetail5 = new List<OrderDetail>();
            foreach (Order order in orderT5)
            {
                List<OrderDetail> orderDetails5 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail5.AddRange(orderDetails5);
            }
            double Sum5 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail5)
            {
                Sum5 += listOrderDetail.TotalPrice;
            }
            Revenue revenue5 = new Revenue();
            revenue5.Time = "may";
            revenue5.Money = Sum5;
            revenues.Add(revenue5);
            ///
            List<Order> orderT6 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 6).ToList();
            List<OrderDetail> listOrderDetail6 = new List<OrderDetail>();
            foreach (Order order in orderT6)
            {
                List<OrderDetail> orderDetails6 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail6.AddRange(orderDetails6);
            }
            double Sum6 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail6)
            {
                Sum6 += listOrderDetail.TotalPrice;
            }

            Revenue revenue6 = new Revenue();
            revenue6.Time = "June";
            revenue6.Money = Sum6;
            revenues.Add(revenue6);
            ///
            List<Order> orderT7 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 7).ToList();
            List<OrderDetail> listOrderDetail7 = new List<OrderDetail>();
            foreach (Order order in orderT7)
            {
                List<OrderDetail> orderDetails7 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail7.AddRange(orderDetails7);
            }
            double Sum7 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail7)
            {
                Sum7 += listOrderDetail.TotalPrice;
            }
            Revenue revenue7 = new Revenue();
            revenue7.Time = "July";
            revenue7.Money = Sum7;
            revenues.Add(revenue7);

            ////
            List<Order> orderT8 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 8).ToList();
            List<OrderDetail> listOrderDetail8 = new List<OrderDetail>();
            foreach (Order order in orderT8)
            {
                List<OrderDetail> orderDetails8 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail8.AddRange(orderDetails8);
            }
            double Sum8 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail8)
            {
                Sum8 += listOrderDetail.TotalPrice;
            }
            Revenue revenue8 = new Revenue();
            revenue8.Time = "August";
            revenue8.Money = Sum8;
            revenues.Add(revenue8);
            ///
            List<Order> orderT9 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 9).ToList();
            List<OrderDetail> listOrderDetail9 = new List<OrderDetail>();
            foreach (Order order in orderT9)
            {
                List<OrderDetail> orderDetails9 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail9.AddRange(orderDetails9);
            }
            double Sum9 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail9)
            {
                Sum9 += listOrderDetail.TotalPrice;
            }
            Revenue revenue9 = new Revenue();
            revenue9.Time = "September";
            revenue9.Money = Sum9;
            revenues.Add(revenue9);
            ///
            List<Order> orderT10 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 10).ToList();
            List<OrderDetail> listOrderDetail10 = new List<OrderDetail>();
            foreach (Order order in orderT10)
            {
                List<OrderDetail> orderDetails10 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail10.AddRange(orderDetails10);
            }
            double Sum10 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail10)
            {
                Sum10 += listOrderDetail.TotalPrice;
            }
            Revenue revenue10 = new Revenue();
            revenue10.Time = "October";
            revenue10.Money = Sum10;
            revenues.Add(revenue10);
            ///
            List<Order> orderT11 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 11).ToList();
            List<OrderDetail> listOrderDetail11 = new List<OrderDetail>();
            foreach (Order order in orderT11)
            {
                List<OrderDetail> orderDetails11 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail11.AddRange(orderDetails11);
            }
            double Sum11 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail11)
            {
                Sum11 += listOrderDetail.TotalPrice;
            }
            Revenue revenue11 = new Revenue();
            revenue11.Time = "November";
            revenue11.Money = Sum11;
            revenues.Add(revenue11);
            ///
            List<Order> orderT12 = db.Order.Where(x => x.CreateTime.Year == now.Year && x.CreateTime.Month == 12).ToList();
            List<OrderDetail> listOrderDetail12 = new List<OrderDetail>();
            foreach (Order order in orderT12)
            {
                List<OrderDetail> orderDetails12 = db.OrderDetail.Where(x => x.OdId == order.Id).ToList();
                listOrderDetail12.AddRange(orderDetails12);
            }
            double Sum12 = 0;
            foreach (OrderDetail listOrderDetail in listOrderDetail12)
            {
                Sum12 += listOrderDetail.TotalPrice;
            }
            Revenue revenue12 = new Revenue();
            revenue12.Time = "December";
            revenue12.Money = Sum12;
            revenues.Add(revenue12);

            return revenues;
        }
    }
}

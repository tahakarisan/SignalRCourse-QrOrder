using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int ActiveOrderCount()
        {
            return _orderDal.ActiveOrderCount();
        }

        public void Add(Order entity)
        {
            _orderDal.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();  
        }

        public Order GetById(int id)
        {
            return _orderDal.GetById(id);   
        }

        public int InProgressOrderCount()
        {
            return _orderDal.InProgressOrderCount();
        }

        public decimal LastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public int PasssiveOrderCount()
        {
            return _orderDal.PasssiveOrderCount();
        }

        public decimal TodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public int TotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        public void Update(Order entity)
        {
            if (entity != null)
            {
                _orderDal.Update(entity);
            }
            else
            {
                throw new ArgumentNullException(nameof(entity), "Order entity cannot be null"); 
            }
        }
    }
}

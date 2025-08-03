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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;
        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }
        public void Add(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void Delete(Basket entity)
        {
            _basketDal.Delete(entity);
        }

        public List<Basket> GetAll()
        {
            return _basketDal.GetAll();
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            return _basketDal.GetBasketByMenuTableNumber(id);
        }

        public Basket GetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public void Update(Basket entity)
        {
            _basketDal.Update(entity);  
        }
    }
}

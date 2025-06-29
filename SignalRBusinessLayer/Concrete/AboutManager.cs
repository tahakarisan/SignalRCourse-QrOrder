using SignalR.EntityLayer.Entities;
using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {

        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void Add(About entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
            }
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
            }
            _aboutDal.Delete(entity);
        }

        public List<About> GetAll()
        {
            var abouts = _aboutDal.GetAll();
            if (abouts == null || !abouts.Any())
            {
                throw new InvalidOperationException("No About records found.");
            }
            return abouts;
        }

        public About GetById(int id)
        {
           return _aboutDal.GetById(id) ?? throw new KeyNotFoundException($"About with ID {id} not found.");
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}

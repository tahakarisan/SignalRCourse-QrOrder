﻿using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void Delete(Contact entity)
        {
            _contactDal.Delete(entity); 
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
            
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id); 
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}

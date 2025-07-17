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
    public class MenuTableManager:IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;
        
        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void Add(MenuTable entity)
        {
            _menuTableDal.Add(entity);
        }

        public void Delete(MenuTable entity)
        {
            _menuTableDal.Delete(entity);
        }

        public List<MenuTable> GetAll()
        {
            return _menuTableDal.GetAll();
        }

        public MenuTable GetById(int id)
        {
            return _menuTableDal.GetById(id);   
        }

        public int TableCount()
        {
            return _menuTableDal.TableCount();
        }

        public void Update(MenuTable entity)
        {
            _menuTableDal.Update(entity);
        }

        public void UpdateStatus(string tableName)
        {
            _menuTableDal.UpdateStatusTable(tableName); 
        }
    }
}

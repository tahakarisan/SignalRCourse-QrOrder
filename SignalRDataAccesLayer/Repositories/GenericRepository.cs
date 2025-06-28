using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }
        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}

using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfMenuTableDal : GenericRepository<MenuTable>,IMenuTableDal
    {
        public EfMenuTableDal(SignalRContext context) : base(context)
        {
        }
        public int TableCount()
        {
            using (SignalRContext context = new SignalRContext())
            {
                return context.Set<MenuTable>().Count();
            }
        }

        public void UpdateStatusTable(string tableName)
        {
            using (SignalRContext context = new SignalRContext())
            {
                var lowerTable = tableName.ToLower();

                var tableInfo = context.Orders
                    .Where(o => o.TableNumber.ToLower() == lowerTable)
                    .Select(o => new { o.TableNumber, o.Status })
                    .FirstOrDefault();


                if (tableInfo != null)
                {
                    var menuTable = context.Set<MenuTable>()
                        .FirstOrDefault(m => m.Name.ToLower() == tableInfo.TableNumber.ToLower());

                    if (menuTable != null)
                    {
                        // 3. Status'ü tersine çevir
                        menuTable.Status = tableInfo.Status;

                        // 4. Güncelle
                        context.Set<MenuTable>().Update(menuTable);
                        context.SaveChanges();
                    }
                }


            }

        }
    }
}

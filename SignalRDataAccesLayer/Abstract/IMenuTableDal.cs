using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Abstract
{
    public interface IMenuTableDal:IGenericDal<SignalREntityLayer.Entities.MenuTable>
    {
        int TableCount();   
        void UpdateStatusTable(string tableName);   
    }
}

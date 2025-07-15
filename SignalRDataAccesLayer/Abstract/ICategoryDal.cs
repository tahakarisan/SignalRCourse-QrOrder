using SignalR.EntityLayer.Entities;

namespace SignalRDataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        int CategoryCount();
        Category GetCategoryByName(string name);
        int ActiveCategoryCount();
        int PassiveCategoryCount();
    }
}

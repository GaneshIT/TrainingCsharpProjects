using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmtLibrary
{
    public interface IFoodItemRepository
    {
        string AddFoodItem(EventModel eventModel);
        string UpdateFoodItem(EventModel eventModel);
        string DeleteFoodItem(int foodId);
        List<EventModel> SelectFoodItems();
        EventModel SelectFoodItem(int foodId);
    }
}

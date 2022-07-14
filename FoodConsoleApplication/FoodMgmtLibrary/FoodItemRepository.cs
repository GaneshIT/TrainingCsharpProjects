using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmtLibrary
{
    public class FoodItemRepository : IFoodItemRepository
    {
        public string AddFoodItem(EventModel eventModel)
        {
            //ADO.NET CONNECTION
            return "Item Added";
        }

        public string DeleteFoodItem(int foodId)
        {
            return "Item Deleted";
        }

        public EventModel SelectFoodItem(int foodId)
        {
            return new EventModel { Description="Test",Id= foodId,Name="Veg"};
        }

        public List<EventModel> SelectFoodItems()
        {
            return new List<EventModel>
            {
                new EventModel { Description="Test",Id=1,Name="Veg" }
            };
    
        }

        public string UpdateFoodItem(EventModel eventModel)
        {
            return "Updated";
        }
    }
}

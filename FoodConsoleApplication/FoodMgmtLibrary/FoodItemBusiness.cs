using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmtLibrary
{
    public class FoodItemBusiness
    {
        private readonly FoodItemRepository _foodItemRepository = null;
        public FoodItemBusiness(FoodItemRepository foodItemRepository)
        {
            _foodItemRepository = foodItemRepository;   
        }
        public string AddFoodItem(EventModel eventModel)
        {
            return _foodItemRepository.AddFoodItem(eventModel);
        }
        public string UpdatedFoodItem(EventModel eventModel)
        {
            return _foodItemRepository.UpdateFoodItem(eventModel);
        }
    }
    
    //
}

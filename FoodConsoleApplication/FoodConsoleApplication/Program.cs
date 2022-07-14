using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodMgmtLibrary;
namespace FoodConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FoodItemRepository object
            FoodItemRepository foodItemRepository = new FoodItemRepository();
            //connecting business class and pass repo object
            FoodItemBusiness foodItemBusinessObj = new FoodItemBusiness(foodItemRepository);

            //eventmodel data
            EventModel eventModel = new EventModel();
            eventModel.Id = 1;
            eventModel.Name = "Veg";
            eventModel.Description = "Test";
            //calling addfooditem
            foodItemBusinessObj.AddFoodItem(eventModel);

            //Delegates
            Calculator obj = new Calculator();

            //            int intoperation = 1;
            //            int operatorX = 20;
            //            int operatorY = 10;

            //            //invoke inbuild - auto trigger
            //           int result= obj.GetDelegateRef(intoperation).Invoke(operatorX, operatorY);

            //Console.WriteLine(result);

            CalculatorDelegate delegateObj = null;
            //multicast delegate
            delegateObj += obj.Add;
            delegateObj += obj.Sub;
            delegateObj += obj.Multi;
            delegateObj -= obj.Multi;

            //Performs Add,Sub,Multi one by one.
           Console.WriteLine(delegateObj.Invoke(10, 20));

            //FoodDbConnection foodDbConnection = new FoodDbConnection();
            ////InsertItem
            //Console.Write("Enter FoodName: ");
            //string foodName = Console.ReadLine();
            //Console.Write("Enter FoodDesc ");
            //string foodDesc = Console.ReadLine();
            //string msg = foodDbConnection.InsertFoodItem(foodName, foodDesc);

            //UpdateItem
            //Console.Write("Enter Food Id To Change: ");
            //int fId =Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter FoodName To Change: ");
            //string foodName = Console.ReadLine();
            //Console.Write("Enter FoodDesc To Change: ");
            //string foodDesc = Console.ReadLine();
            //string msg = foodDbConnection.UpdateFoodItem(fId,foodName, foodDesc);
            //Console.Write(msg);

            //DataTable dtResult= foodDbConnection.SelectFoodItems();
            //for (int i = 0; i < dtResult.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dtResult.Columns.Count; j++)
            //    {
            //        Console.WriteLine(dtResult.Rows[i][j]);
            //    }
            //}
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmtLibrary
{
    public class FoodDbConnection
    {
        public static string connectionStr = @"Data Source=AZ-5CG1394FS0\SQLEXPRESS;Initial Catalog=FoodMgmtDb;Integrated Security=True";
        public string InsertFoodItem(string foodName, string foodDesc)
        {
            #region connectedmode
            ////Connection Establishment
            //SqlConnection conn = new SqlConnection(connectionStr);
            //conn.Open();//connection state opened
            //string qry = "insert into FoodData values('" + foodName + "','" + foodDesc + "')";
            ////Passing sql qry with connection object
            //SqlCommand cmd = new SqlCommand(qry, conn);
            //int row = cmd.ExecuteNonQuery();//Execute sqlcommand by using cmd object
            //conn.Close();//connection state closed
            #endregion

            #region DisconnectedMode
            //Connection Establishment
            SqlConnection conn = new SqlConnection(connectionStr);
            string qry = "insert into FoodData values('" + foodName + "','" + foodDesc + "')";
            //Passing sql qry with connection object
            SqlDataAdapter adp = new SqlDataAdapter(qry, conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            #endregion
            return "Inserted";
        }
        public string UpdateFoodItem(int foodId, string foodName, string foodDesc)
        {
            //Connection Establishment
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state opened
            string qry = "update FoodData set foodname='" + foodName + "' , fooddesc='" + foodDesc + "' where fid=" + foodId + "";
            //Passing sql qry with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();//Execute sqlcommand by using cmd object
            conn.Close();//connection state closed
            return "Updated";
        }
        public string DeleteFoodItem(int foodId)
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state opened
            string qry = "delete from FoodData where fid=" + foodId + "";
            //Passing sql qry with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            int row = cmd.ExecuteNonQuery();//Execute sqlcommand by using cmd object
            conn.Close();//connection state closed
            return "Deleted";
        }
        public DataTable SelectFoodItems()
        {
            SqlConnection conn = new SqlConnection(connectionStr);
            conn.Open();//connection state opened
            string qry = "select * from FoodData";
            //Passing sql qry with connection object
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataReader dr = cmd.ExecuteReader();//Execute sqlcommand by using cmd object
            DataTable dt = new DataTable();//Row & Column format
            dt.Load(dr);//converting dr into table 
            conn.Close();//connection state closed
            return dt;
        }
    }
}

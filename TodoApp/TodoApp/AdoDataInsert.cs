using TodoApp.Models;
 using System; 
 using System.Collections.Generic; 
 using System.Data.SqlClient; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks; 
 
 
 namespace TodoApp
 { 
   /// <summary> 
   ///  
   /// </summary> 
   public partial class AdoData
   { 

     public bool InsertItems(Models.Items items)
     { 
       var n = new SqlParameter("name", items.ItemName); 
       var query = "insert into TodoApp.Items(ItemName, Complete, Active) values (@name, 1, 1)"; 
 
 
       return InsertData(query, n) == 1; 
     } 
 
 
     private int InsertData(string query, params SqlParameter[] parameters)
     { 
       int result; 
 
 
       using (var connection = new SqlConnection(connectionString)) 
       { 
         var cmd = new SqlCommand(query, connection); 
 
 
         connection.Open(); 
         cmd.Parameters.AddRange(parameters); 
         result = cmd.ExecuteNonQuery(); 
       } 
 
       return result; 
     } 
   } 
 } 
 

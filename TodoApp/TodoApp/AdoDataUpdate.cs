using TodoApp.Models; 
using System; 
using System.Collections.Generic; 
using System.Data.SqlClient; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 


namespace MonsterApp.DataAccess
{ 
  public partial class AdoData
  { 
    public bool UpdateGender(TodoApp.Models.Items items)
    { 
      var query = "update ToDoApp.Items set ItemName = @name, Complete = @complete, Active = @active where ItemId = @id"; 
      var name = new SqlParameter("name", items.ItemName); 
      var complete = new SqlParameter("complete", items.Complete ? 1 : 0);
      var active = new SqlParameter("active", items.Active ? 1 : 0);
      var id = new SqlParameter("id", items.ItemId); 
      int result; 
 
 
      using (var connection = new SqlConnection(connectionString)) 
      { 
        var cmd = new SqlCommand(query, connection); 
  
        connection.Open(); 
        cmd.Parameters.AddRange(new SqlParameter[] { id, name, active}); 
        result = cmd.ExecuteNonQuery(); 
      } 
      return result >= 0; 
    } 
  } 
} 

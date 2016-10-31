using Models = TodoApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
  public partial class AdoData
  {
    private string connectionString = ConfigurationManager.ConnectionStrings["ItemsDB"].ConnectionString;



    public List<Models.Items> GetItems()
    {
      try
      {
        var ds = GetDataDisconnected("select * from ToDo.Gender;");
        var items = new List<Models.Items>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          items.Add(new Models.Items()
          {
            ItemId = int.Parse(row[0].ToString()),
            ItemName = row[1].ToString(),
            Complete = bool.Parse(row[2].ToString()),
            Active = bool.Parse(row[3].ToString())
          });
        }
        return items;
      }
      catch (Exception)
      {
        return null;
      }
    }


    private DataSet GetDataDisconnected(string query)
    {
      SqlDataAdapter da;
      DataSet ds;
      SqlCommand cmd;

      using (var connection = new SqlConnection(connectionString))
      {
        cmd = new SqlCommand(query, connection);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        da.Fill(ds);

      }

      return ds;
    }

  }
}


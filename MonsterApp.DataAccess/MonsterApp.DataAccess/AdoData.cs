using MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  /// <summary>
  /// 
  /// </summary>
  public class AdoData
  {
    private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;

    #region Methods

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Gender> GetGenders()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.Gender;");
        var genders = new List<Gender>();

        foreach(DataRow row in ds.Tables[0].Rows)
        {
          genders.Add(new Gender
          {
            GenderId = int.Parse(row[0].ToString()),
            GenderName = row[1].ToString(),
            Active = bool.Parse(row[2].ToString())
          });
        }
        return genders;
      }
      catch (Exception)
      {
        return null;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<MonsterType> GetMonsterType()
    {
      throw new NotImplementedException("todo");

    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Title> GetTitles()
    {
      throw new NotImplementedException("todo");

    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>

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

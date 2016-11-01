using MonsterApp.DataAccess;
using DA = MonsterApp.DataAccess.Models;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterApp.DataClient
{
  public class MonsterTypeMapper
  {
    public static MonsterTypeDAO MapToMonsterTypeDAO(DA.MonsterType monster)
    {
      var m = new MonsterTypeDAO();

      m.Id = monster.MonsterTypeId;
      m.Name = monster.Name;

      return g;
    }

    public static DA.MonsterType MapToMonsterType(MonsterTypeDAO monster)
    {

      throw new NotImplementedException();

    }

    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));

      }

      return ob;
    }

  }
}

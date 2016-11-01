using MonsterApp.DataAccess;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MonsterApp.DataClient
{
  
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonsterService" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select MonsterService.svc or MonsterService.svc.cs at the Solution Explorer and start debugging.
  public class MonsterService : IMonsterService
  {
    private AdoData data = new AdoData();

    public List<GenderDAO> GetGenders()
    {
      var g = new List<GenderDAO>();

      foreach (var gender in data.GetGenders())
      {
        g.Add(GenderMapper.MapToGenderDAO(gender));
      }

      return g;

    }

    public List<MonsterTypeDAO> GetMonsterTypes()
    {
      var m = new List<MonsterTypeDAO>();

      foreach (var monster in data.GetMonsterTypes())
      {
        m.Add(GenderMapper.MapToMonsterTypeDAO(monster));
      }

      return m;
      
    }

    public List<TitleDAO> GetTitles()
    {
      var t = new List<TitleDAO>();

      foreach (var title in data.GetTitles())
      {
        t.Add(GenderMapper.MapToTitleDAO(title));
      }

      return t;

    }

  }
}

using MonsterApp.DataAccess;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonsterApp.Tests
{
  public partial class AdoDataTests
  {
    [Fact]
    public void Test_GetGenders()
    {

      AdoData data = new AdoData();

      var actual = data.GetGenders();

      Assert.NotNull(actual);

    }

    //public void Test_GetMonsterTypes()
    //{

    //  AdoData data = new AdoData();

    //  var actual = data.GetMonsterType();

    //  Assert.NotNull(actual);

    //}

    //public void Test_GetTitles()
    //{

    //  AdoData data = new AdoData();

    //  var actual = data.GetTitles();

    //  Assert.NotNull(actual);

    //}

  }
}

using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class EfDataTests
  {
    [Fact]

    public void Test_GetGenders()
    {
      var data = new EfData();
      var actual = data.GetGenders();

      Assert.NotNull(actual);


    }

    [Fact]
    public void Test_InsertGender()
    {
      var data = new EfData();
      var expected = new Gender() { GenderName = "Martian", Active = true };

      var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

      Assert.True(actual);
    }

    //[Fact]
    //public void Test_UpdateGender()
    //{

    //  var data = new EfData();
    //  var expected = Gender( GenderName = "Martian", Active = false );

    //  var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Modified);

    //  Assert.True(actual);

    //}

    //[Fact]
    //public void Test_DeleteGender()
    //{
    //  var data = new EfData();
    //  var expected = Gender(GenderName = "Martian");

    //  var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Deleted);

    //  Assert.True(actual);

    //}


    //}
  }
}

using TodoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TodoApp.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class EfDataTests
  {
    [Fact]
    public void Test_GetItems()
    {
      var data = new EfData();
      var actual = data.GetItems();

      Assert.NotNull(actual);
    }

    [Fact]
    public void Test_InsertItems()
    {
      var data = new EfData();
      var expected = new Items() { ItemName = "Bowl", Complete = true, Active = true };

      var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

      Assert.True(actual);
    }
  }
}


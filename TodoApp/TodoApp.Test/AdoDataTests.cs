using TodoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TodoApp.Tests
{
  public partial class AdoDataTests
  {
    [Fact]
    public void Test_GetItems()
    {
      var data = new AdoData();
      var actual = data.GetItems();

      Assert.NotNull(actual);
    }
  }
}


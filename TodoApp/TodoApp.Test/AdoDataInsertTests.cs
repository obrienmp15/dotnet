using TodoApp;
using Models = TodoApp.Models;
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
    private Models.Gender gender;

    public AdoDataTests()
    {
      gender = new Models.Items() { Name = "TestItems" };
    }

    [Fact]
    public void Test_InsertItems()
    {
      var data = new AdoData();
      var actual = data.InsertItems(items);

      Assert.True(actual);
    }

    [Theory(items = new Models.Items() { ItemName = "Stuff", Complete = true, Active = true })]
    [Theory(items = new Models.Items() { ItemName = "markers", Complete = true, Active = true })]
    [Theory(items = new Models.Items() { ItemName = "Bowls", Complete = false, Active = true })]
    public void Theory_InsertItems(Models.Items items)
    {
      var data = new AdoData();
      var actual = data.InsertItems(items);

      Assert.True(actual);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Tests
{
  [TestClass]
  public class AdoDataMSTests
  {
    private Models.Items items;

    [TestInitialize]
    public void Initialize()
    {
      gender = new DataAccess.Models.Gender() { Name = "TestGender" };
    }

    [TestCleanup]
    public void Cleanup()
    {
      GC.Collect();
    }

    [TestMethod]
    public void Test_InsertGender()
    {
      var data = new AdoData();
      var actual = data.InsertGender(gender);

      Assert.IsTrue(actual);
    }
  }
}


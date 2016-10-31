using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TodoApp.Models;


namespace TodoApp
{
  public class EfData
  {
    private ItemsDBEntities db = new ItemsDBEntities();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Items> GetItems()
    {
      return db.Items.ToList();
    }


    public bool InsertItems(Items items)
    {
      db.Items.Add(items);
      return db.SaveChanges() > 0;
    }

    public bool ChangeItems(Items items, EntityState state)
    {
      var entry = db.Entry<Items>(items);

      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public void SearchItems()
    {
      var actives = db.Items.Where(a => a.Active);
      var complete = db.Items.Select(c => c.Complete);
      var name = db.Items.Where(n => n.ItemName.ToLower().Contains("b"));
    }
  }
}


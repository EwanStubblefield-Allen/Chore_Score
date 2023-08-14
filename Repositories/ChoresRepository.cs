using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chore_Score.Repositories
{
  public class ChoresRepository
  {
    private List<Chore> chores;
    public ChoresRepository()
    {
      chores = new List<Chore>();
      chores.Add(new Chore("Dishes", "Kitchen", "Do it", 5, false));
      chores.Add(new Chore("Laundry", "Laundry Room", "Fold it", 10, true));
      chores.Add(new Chore("Dusting", "Everywhere", "Dust it", 5, false));
    }

    internal List<Chore> getChores()
    {
      return chores;
    }

    internal Chore GetChoreById(Guid choreId)
    {
      Chore chore = chores.Find(c => c.Id == choreId);
      return chore;
    }

    internal Chore CreateChore(Chore choreData)
    {
      chores.Add(choreData);
      return choreData;
    }

    internal Chore UpdateChore(Chore choreData)
    {
      Chore foundChore = GetChoreById(choreData.Id);
      foundChore.Name = choreData.Name;
      foundChore.Room = choreData.Room;
      foundChore.IsDone = choreData.IsDone;
      return foundChore;
    }

    internal Chore RemoveChore(Guid choreId)
    {
      Chore foundChore = GetChoreById(choreId);
      chores.Remove(foundChore);
      return foundChore;
    }
  }
}
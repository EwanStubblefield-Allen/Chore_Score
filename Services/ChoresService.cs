using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chore_Score.Services
{
  public class ChoresService
  {
    private readonly ChoresRepository _choresRepository;
    public ChoresService(ChoresRepository choresRepository)
    {
      _choresRepository = choresRepository;
    }
    internal List<Chore> GetChores()
    {
      List<Chore> chores = _choresRepository.getChores();
      return chores;
    }

    internal Chore GetChoreById(Guid choreId)
    {
      Chore chore = _choresRepository.GetChoreById(choreId);
      if (chore == null)
      {
        throw new Exception($"No chore matches the id: {choreId}");
      }
      return chore;
    }

    internal Chore CreateChore(Chore choreData)
    {
      Chore chore = _choresRepository.CreateChore(choreData);
      return chore;
    }

    internal Chore UpdateChore(Chore choreData)
    {
      Chore chore = _choresRepository.UpdateChore(choreData);
      return chore;
    }

    internal Chore RemoveChore(Guid choreId)
    {
      Chore chore = _choresRepository.RemoveChore(choreId);
      return chore;
    }
  }
}
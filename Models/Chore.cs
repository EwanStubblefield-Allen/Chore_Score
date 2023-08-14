using Microsoft.IdentityModel.Protocols;

namespace Chore_Score.Models
{
  public class Chore
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Room { get; set; }
    public string Instructions { get; set; }
    public int Duration { get; set; }
    public bool IsDone { get; set; }


    public Chore(string name, string room, string instructions, int duration, bool isDone)
    {
      Id = Guid.NewGuid();
      Name = name;
      Room = room;
      Instructions = instructions;
      Duration = duration;
      IsDone = isDone;
    }
  }
}
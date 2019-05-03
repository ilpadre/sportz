using System;

namespace sportz.Models
{
  public class GameResult
  {
    public DateTime Date { get; set; }
    public string HomeTeam { get; set; }
    public int HomeScore { get; set; }
    public string VisitingTeam { get; set; }
    public int VisitingScore { get; set; }
  }
}

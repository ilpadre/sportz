using System;

namespace sportz.Models
{
  public class GameResult
  {
    DateTime Date { get; set; }
    string HomeTeam { get; set; }
    int HomeScore { get; set; }
    string VisitingTeam { get; set; }
    int VisitingScore { get; set; }
  }
}

using sportz.Models;
using System;
using System.Collections.Generic;

namespace SportzTests
{
  public class TestData
  {
    public List<GameResult> GetGameResults()
    {
      return new List<GameResult> {
        new GameResult {
          Date = new DateTime(2018, 03, 14),
          HomeTeam = "Narwhals",
          HomeScore = 12,
          VisitingTeam  = "Zebras",
          VisitingScore = 8
        },

        new GameResult
        {
          Date = new DateTime(2018, 03, 14),
          HomeTeam = "Brewers",
          HomeScore = 1,
          VisitingTeam = "Scooters",
          VisitingScore = 77
        }
      };
    }
  }
}

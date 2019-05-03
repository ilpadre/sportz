using sportz.Models;
using System;
using System.Collections.Generic;

namespace SportzTests
{
  public static class TestData
  {
    public static List<Team> GetTeams()
    {
      return new List<Team>
      {
        new Team("East", "Narwhals"),
        new Team("East", "Zebras"),
        new Team("West", "Brewers"),
        new Team("West", "Scooters"),
        new Team("East", "Aardvarks"),
        new Team("East", "Ligers"),
        new Team("West", "Defenestrators"),
        new Team("West", "")
      };
    }


    public static List<GameResult> GetGameResults()
    {
      return new List<GameResult> {
        new GameResult {
          Date = new DateTime(2018, 03, 14),
          HomeTeam = "Narwhals",
          HomeScore = 12,
          VisitingTeam  = "Zebras",
          VisitingScore = 8
        },

        new GameResult {
          Date = new DateTime(2018, 03, 14),
          HomeTeam = "Brewers",
          HomeScore = 1,
          VisitingTeam = "Scooters",
          VisitingScore = 77
        },

        new GameResult {
          Date = new DateTime(2018, 03, 27),
          HomeTeam = "Aardvarks",
          HomeScore = 23,
          VisitingTeam = "Ligers",
          VisitingScore = 13
        }

      };
    }
  }
}

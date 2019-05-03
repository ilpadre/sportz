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
        new Team("West", "Veronicas")
      };
    }

    public static List<GameResult> GetGameResults()
    {
      return new List<GameResult>
      {
        new GameResult
        {
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
        },

        new GameResult
        {
          Date = new DateTime(2018, 03, 27),
          HomeTeam = "Aardvarks",
          HomeScore = 23,
          VisitingTeam = "Ligers",
          VisitingScore = 13
        },

        new GameResult
        {
          Date = new DateTime(2018, 03, 27),
          HomeTeam = "Defenestrators",
          HomeScore = 34,
          VisitingTeam = "Veronicas",
          VisitingScore = 19
        },

        new GameResult
        {
          Date = new DateTime(2018, 04, 06),
          HomeTeam = "Ligers",
          HomeScore = 2,
          VisitingTeam = "Narwhals",
          VisitingScore = 2
        },

        new GameResult
        {
          Date = new DateTime(2018, 04, 08),
          HomeTeam = "Zebras",
          HomeScore = 17,
          VisitingTeam = "Aardvarks",
          VisitingScore = 31
        },

        new GameResult
        {
          Date = new DateTime(2018, 04, 10),
          HomeTeam = "Veronicas",
          HomeScore = 56,
          VisitingTeam = "Brewers",
          VisitingScore = 3
        },

        new GameResult
        {
          Date = new DateTime(2018, 04, 08),
          HomeTeam = "Scooters",
          HomeScore = 8,
          VisitingTeam = "Defenestrators",
          VisitingScore = 15
        },
      };
    }
  }
}

using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using sportz;
using sportz.Models;

namespace SportzTests
{
  public class Tests
  {
    private List<Team> teams = null;
    private List<GameResult> games = null;

    [SetUp]
    public void Setup()
    {
        teams = TestData.GetTeams();
        games = TestData.GetGameResults();
    }

    [Test]
    public void Test1()
    {
      Assert.Pass();
    }

    [Test]
    public void ShouldComputeWinLossForBrewers()
    {
      var result = WinLoss.CalculateWinLossPercentage(teams.First(t => t.TeamName == "Brewers"));
      Assert.AreEqual(0, result);
    }
  }
}
using System.Collections.Generic;
using NUnit.Framework;
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
  }
}
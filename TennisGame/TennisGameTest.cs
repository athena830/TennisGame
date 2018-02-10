using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame
{
    [TestClass]
    public class TennisGameTest
    {
        TennisGame tennisGame = new TennisGame("Lulu", "Steve");

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            GivenSecondPlayerScoreTimes(1);
            ScoreShouldBe("Love Fifteen");
        }

        [TestMethod]
        public void Love_Thirty()
        {
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            GivenFirstPlayerScoreTimes(1);
            GivenSecondPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_When_4_4()
        {
            GivenFirstPlayerScoreTimes(4);
            GivenSecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void First_player_Advantage()
        {
            GivenFirstPlayerScoreTimes(4);
            GivenSecondPlayerScoreTimes(3);
            ScoreShouldBe("Lulu Adv");
        }

        [TestMethod]
        public void Second_player_Advantage()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(4);
            ScoreShouldBe("Steve Adv");
        }

        [TestMethod]
        public void Second_player_Win()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(5);
            ScoreShouldBe("Steve Win");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.FirstPlayerScore();
            }
        }
        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                tennisGame.SecondPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.Score());
        }
    }
}

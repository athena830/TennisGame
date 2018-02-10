using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public string Score()
        {
            if (isSameScore())
            {
                if (_firstPlayerScoreTimes >= 3)
                {
                    return "Deuce";
                }
                return _scoreLookup[_firstPlayerScoreTimes] + " All";
            }
            else
            {
                return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
            }

        }

        private bool isSameScore()
        {
            return _firstPlayerScoreTimes == _secondPlayerScoreTimes;
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}
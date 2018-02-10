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
            if (_firstPlayerScoreTimes == _secondPlayerScoreTimes)
            {
                return _scoreLookup[_firstPlayerScoreTimes] + " All";
            }
            else
            {
                return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
            }

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
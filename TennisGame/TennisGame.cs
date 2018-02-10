using System;
using System.Collections.Generic;

namespace TennisGame
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

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
                if (_firstPlayerScoreTimes>3 || _secondPlayerScoreTimes>3)
                {
                    return AdvPlayer() + (isAdv() ? " Adv" : " Win");
                    if (isAdv())
                    {
                        return AdvPlayer() + " Adv";
                    }
                    return AdvPlayer() + " Win";

                }
                return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
            }

        }

        private bool isAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes-_secondPlayerScoreTimes)==1;
        }

        private string AdvPlayer()
        {
            var advPlayer = _firstPlayerScoreTimes > _secondPlayerScoreTimes
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayer;
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
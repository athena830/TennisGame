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
            return IsSameScore()
                ? (IsDeuce() ? Deuce() : SameScore())
                : (IsReadyForWin() ? AdvState() : NormalScore());
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private string SameScore()
        {
            return _scoreLookup[_firstPlayerScoreTimes] + " All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScoreTimes>3 || _secondPlayerScoreTimes>3;
        }

        private string NormalScore()
        {
            return _scoreLookup[_firstPlayerScoreTimes] + " " + _scoreLookup[_secondPlayerScoreTimes];
        }

        private string AdvState()
        {
            return AdvPlayer() + (IsAdv() ? " Adv" : " Win");
        }

        private bool IsAdv()
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

        private bool IsSameScore()
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
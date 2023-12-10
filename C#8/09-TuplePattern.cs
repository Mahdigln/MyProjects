using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.Features
{
    public static class TuplePattern
    {
        public static string RockPaperScissors(string firstMove, string secondMove)
            => (firstMove, secondMove) switch
            {
                ("rock", "paper") => "paper wins",
                ("rock", "scissors") => "scissors wins",
                ("paper", "rock") => "paper wins",
                ("paper", "scissors") => "scissors wins",
                ("scissors", "rock") => "rock wins",
                ("scissors", "paper") => "scissors wins",
                (_, _) => "tie"
            };
    }
}

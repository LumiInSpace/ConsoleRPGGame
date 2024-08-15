using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.src.Main
{
    public class IllegalCharacterClassException : Exception
    {
        public IllegalCharacterClassException(string? message) : base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPGGame.src.Utilitys
{
    public class CheckedInput
    {
        public bool IsValid {  get; set; }
        public int Value { get; set; }

        public CheckedInput(bool _isValid, int _value)
        {
            IsValid = _isValid;
            Value = _value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Validation
    {

        public bool validateInput(char userInput)
        {
            char value = Char.ToLower(userInput);
            if (value != 'r' && value != 'p' && value != 's') return false;
            return true;
        }

        public bool ValidateResponse(char response)
        {
            if (char.ToUpper(response) != 'Y' && char.ToUpper(response) != 'N')
                return false;
            return true;
        }

        public bool ValidateGameTypeResponse(char response)
        {
            if (char.ToUpper(response) != 'S' && char.ToUpper(response) != 'L')
                return false;
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NumberGuessWCF
{
   public class Service1 : IService1
    {
        public string GuessNumber(int number)
        {
            string response = "";

            Random random = new Random();
            int randomNr = random.Next(1, 10);

            if(number == randomNr)
            {
                response = "You guessed right!";
            }
            else
            {
                response = "Wrong! Try again!";
            }

            return response;
        }
    }
}

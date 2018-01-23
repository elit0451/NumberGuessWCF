using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NumberGuessWCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GuessNumber(int number);
        
    }

    [DataContract]
    public class House
    {
        [DataMember]
        public int RoomsNumber { get; set; }

        [DataMember]
        public string HouseColour { get; set; }

    }
}

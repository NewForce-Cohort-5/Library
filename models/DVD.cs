using System.Collections.Generic;

namespace library5
{
    public class DVD : IMedia, IDigitalMedia {
        public string Title {get; set;}

        public string Director {get; set;}

        public string Genre {get; set;}
        public string RunTime { get; set; }
        public List<string> Cast { get; set; }
        public string ISBN { get; set; }
    }

}
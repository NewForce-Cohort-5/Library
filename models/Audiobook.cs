using System.Collections.Generic;

namespace library5
{
    public class Audiobook : IMedia, IDigitalMedia
    {
        public string RunTime { get; set; }
        public List<string> Cast { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
    }
}
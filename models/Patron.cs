using System.Collections.Generic;

namespace library5
{
    public class Patron {
        public string Name {get; set;}

        public string Email {get; set;}

        // List of books
        public List<IMedia> CheckedOutMedia = new List<IMedia>();

        public List<IDigitalMedia> CheckedOutDigitalMedia = new List<IDigitalMedia>();
    }

}
namespace library5 {
    public class Magazine : IMedia, IPrintMedia
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public int NumberOfPages { get; set; }
        public string Author { get; set; }
    }
}
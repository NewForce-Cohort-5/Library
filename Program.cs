using System;


namespace library5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Things I need to track: patrons, books, audiobooks (CDs or digital), DVDs, magazines

            Book greenEggsAndHam = new Book();
            greenEggsAndHam.Title = "Green Eggs and Ham";
            greenEggsAndHam.Author = "Dr. Seuss";

            Audiobook catInTheHat = new Audiobook();
            catInTheHat.Title = "Cat In the Hat";
            // catInTheHat.Author = "Dr. Seuss";

            Patron brandi = new Patron();
            brandi.CheckedOutMedia.Add(greenEggsAndHam);
            brandi.CheckedOutMedia.Add(catInTheHat);
            brandi.CheckedOutMedia.Add(new Magazine());
            brandi.CheckedOutMedia.Add(new DVD());

        }
    }
}

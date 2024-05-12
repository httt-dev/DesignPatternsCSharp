namespace StateDesign.Repository
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
    }

    public class BookedMovie
    {
        public Movie Movie { get; set; }
        public int NoOfTickets { get; set; }
    }

}
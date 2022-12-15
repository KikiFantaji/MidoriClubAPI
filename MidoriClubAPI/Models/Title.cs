namespace MidoriClubAPI.Models
{
    public class Title
    {
        public int Id { get; set; }

        public string Headline { get; set; }

        public string AlternativeHeadline { get; set; }

        public DateOnly DateCreated { get; set; }

        public string Image { get; set; }

        public string Type { get; set; }

        public string Episodes { get; set; }

        public string EpisodeDuration { get; set; }

        public string Rating { get; set; }
    }
}

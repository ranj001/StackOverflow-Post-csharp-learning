namespace StackOverflow
{
    public class Post
    {
        private string Title { get; set; }
        private string Description{ get; set; }
        private DateTime CreatedAt { get; set; }

        public int Votes { get; private set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            Votes = 0;
        }
        public void UpVote()
        {
            Votes++;
        }
        public void DownVote()
        {
            Votes--;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nCreated At: {CreatedAt}\nVotes: {Votes}";
        }


    }
}
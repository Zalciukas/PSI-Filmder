public class LobbyMovie
    {
        public int LobbyId { get; set; }
        public Lobby Lobby { get; set; } = null!;
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
        
        public bool IsAnonymousSuggestion { get; set; } = false;
        
        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
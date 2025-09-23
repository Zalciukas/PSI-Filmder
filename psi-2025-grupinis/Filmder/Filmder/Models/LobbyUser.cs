 using System.ComponentModel.DataAnnotations;

 public class LobbyUser
    {
        public int LobbyId { get; set; }
        public Lobby Lobby { get; set; } = null!;
        
        public string UserId { get; set; } = string.Empty;
        public AppUser User { get; set; } = null!;
        
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
        
        public bool IsReady { get; set; } = false; // For game rounds
    }
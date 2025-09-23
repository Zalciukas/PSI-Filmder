 using System.ComponentModel.DataAnnotations;

 public class Lobby
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(10)]
        public string Code { get; set; } = string.Empty; // Short join code like "ABC123"
        
        public string CreatorId { get; set; } = string.Empty;
        public AppUser Creator { get; set; } = null!;
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime ExpiresAt { get; set; } = DateTime.UtcNow.AddHours(24); // Auto-expire after 24h
        
        // Navigation properties
        public ICollection<LobbyUser> Members { get; set; } = new List<LobbyUser>();
        public ICollection<LobbyMovie> Movies { get; set; } = new List<LobbyMovie>();
    }
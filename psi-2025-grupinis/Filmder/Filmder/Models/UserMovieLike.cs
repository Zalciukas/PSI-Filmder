 using System.ComponentModel.DataAnnotations;
 
 public class UserMovieLike
    {
        public string UserId { get; set; } = string.Empty;
        public AppUser User { get; set; } = null!;
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        
        public DateTime LikedAt { get; set; } = DateTime.UtcNow;
    }
using System.ComponentModel.DataAnnotations;

public class UserMovieDislike
    {
        public string UserId { get; set; } = string.Empty;
        public AppUser User { get; set; } = null!;
        
        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;
        
        public DateTime DislikedAt { get; set; } = DateTime.UtcNow;
    }
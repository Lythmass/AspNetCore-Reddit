using System.ComponentModel.DataAnnotations;

namespace Reddit.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Community>? OwnedCommunities { get; set; } = new List<Community>();
        public virtual ICollection<Community>? SubscibedCommunities { get; set; } = new List<Community>();
        public virtual ICollection<Post>? Posts { get; set; } = new List<Post>();
    }
}
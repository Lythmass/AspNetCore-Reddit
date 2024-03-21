using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reddit.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int OwnerId {  get; set; }
        [ForeignKey(nameof(OwnerId))]
        public virtual User Owner { get; set; }
        public virtual ICollection<User>? SubscribedUsers { get; set; } = new List<User>();
        public virtual ICollection<Post>? Posts { get; set; } = new List<Post>();

    }
}

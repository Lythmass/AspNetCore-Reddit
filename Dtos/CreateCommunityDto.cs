using Reddit.Models;

namespace Reddit.Dtos
{
    public class CreateCommunityDto
    {
        public string Name { get; set; }
        public string Description {  get; set; }
        public int OwnerId { get; set; }

    }
}

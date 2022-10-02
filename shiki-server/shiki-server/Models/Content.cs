using Microsoft.Extensions.Hosting;

namespace shiki_server.Models
{
    public class Content
    {
        public Guid ContentId { get; set;}
        public string? Title { get; set;}
        public string? Description { get; set; }
        public ContentType? Type { get; set; }

        public List<File>? Files { get; } = new();

    }

    public enum ContentType
    {
        Anime,
        Manga,
        Novel
    }
}

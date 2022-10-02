namespace shiki_server.Models
{
    public class File
    {
        public Guid FileId{ get; set; }

        public Content? Content { get; set; }
        public Guid? ContentId { get; set; }

        public string? Path { get; set; }
    }
}

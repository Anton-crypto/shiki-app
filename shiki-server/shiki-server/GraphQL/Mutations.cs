using shiki_server.Models;

namespace shiki_server.GraphQL
{

    /// <summary>
    /// Мутации GraphQL
    /// </summary>
    public class Mutations
    {
        [UseProjection]
        [UseFiltering()]
        [UseSorting()]
        public IQueryable<Content> Create([Service] ShikiContext context, Content content)
        {
            content.ContentId = Guid.NewGuid();
            return context.Contents;
        }
    }
}

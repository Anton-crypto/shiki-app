using shiki_server.Models;

namespace shiki_server.GraphQL
{
    /// <summary>
    /// Запросы GraphQL
    /// </summary>
    public class Query
    {
        //[UseProjection]
        //[UseFiltering()]
        //[UseSorting()]
        public IQueryable<Content> Read([Service] ShikiContext context)
        {
            return context.Contents;
        }
    }
}

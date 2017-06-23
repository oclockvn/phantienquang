using System.Collections.Generic;

namespace phantienquang.Entities
{
    public class Series : TEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int SortOrder { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
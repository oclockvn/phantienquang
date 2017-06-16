using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace phantienquang.Entities
{
    public class Post : TEntity
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public string Search { get; set; }
        public string Seo { get; set; }
        public bool IsPublished { get; set; }
        public int View { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
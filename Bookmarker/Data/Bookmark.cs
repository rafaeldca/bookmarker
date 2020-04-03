using System;
namespace Bookmarker.Data
{
    public class Bookmark
    {
        public int Id { get; set; }

        public Uri BookmarkUri { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public Category Category { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }

        public Bookmark()
        {
        }
    }
}

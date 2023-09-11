using System.Collections.Generic;
using System;

namespace CodePulse.API.Core.Entities
{
    public class Blogpost
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Content { get; set; }

        public string FeaturedImageUrl { get; set; }

        public string UrlHandle { get; set; }

        public DateTime PublishedDate { get; set; }

        public string Author { get; set; }

        public bool IsVisible { get; set; }

    }
}

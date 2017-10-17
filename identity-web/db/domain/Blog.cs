using System;
using System.Collections.Generic;

namespace identity_web.db.domain
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
        public Blog()
        {
            Posts = new List<Post>();
        }
    }
}
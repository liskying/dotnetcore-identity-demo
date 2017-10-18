using System;
namespace identity_web.db.domain
{
        /// <summary>
        /// 评论
        /// </summary>
    public class Post
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// BlogID
        /// </summary>

        public int BlogId { get; set; }
        /// <summary>
        /// Blog
        /// </summary>
        public Blog Blog { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace identity_web.Data.Domain
{
    /// <summary>
    /// Blog
    /// </summary>
    [Table("Blog")]
    public class Blog
    {

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// URL地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 评价
        /// </summary>
        public int Rating { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        public List<Post> Posts { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public Blog()
        {
            Posts = new List<Post>();
        }
    }
}
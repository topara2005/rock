using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class ArticleItemDto
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int Likes { get; set; }
    }
}

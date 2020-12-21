using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string  Description { get; set; }

        public int LikesNum { get; set; }


    }
}

﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IArticlesService
    {
        IEnumerable<Article> LoadArticles();
        void IncreaseArticleCount(int articleId);
    }
}

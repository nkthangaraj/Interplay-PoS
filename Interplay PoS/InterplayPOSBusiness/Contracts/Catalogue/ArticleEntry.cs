using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Contracts.Catalogue
{
    public class ArticleEntry
    {
        public string version { get; set; }
        public string name { get; set; }
        public string referenceArticleId { get; set; }
        public List<SimpleArticle> simpleArticles { get; set; }

    }
}

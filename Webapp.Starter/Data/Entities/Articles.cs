using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapp.Starter.Data.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime CreatedDate { get; set; }
        public string AuthorId { get; set; }
    }
}

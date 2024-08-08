using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Articles
    {
        public long Id { set; get; }
        public Articles() 
        {
            Random random = new Random();
            Id = random.Next(0, 10000000);
        }

        public long CreateArticles () 
        { 
            Articles articles = new Articles();
            return Id; 
        }
    }
}

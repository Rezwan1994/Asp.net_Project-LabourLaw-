using LLP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LLP.Web
{
    public class BookChapter
    {
        public List<Chapter> ChapterList { get; set; }
        public List<ChapterContent> ContentList { get; set; }
    }
}
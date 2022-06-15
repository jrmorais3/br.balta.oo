using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Url { get; set; }

        public Content(string title, string url)
        {
            var Id = new Guid();
            Title = title;
            Url = url;
        }
    }
}

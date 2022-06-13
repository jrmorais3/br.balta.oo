using Balta.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
        public Course()
        {
            var Modules = new List<Module>();
            var Lectures = new List<Lecture>();
        }
    }
}

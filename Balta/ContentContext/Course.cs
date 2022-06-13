using System;
using System.Collections.Generic;
using System.Text;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public Course()
        {
            var Modules = new List<Module>();
            var Lectures = new List<Lecture>();
        }

        public class Module
        {
            public int Order { get; set; }
            public string Title { get; set; }
            public IList<Lecture> Lectures { get; set; }

            public Module()
            {
                Lectures = new List<Lecture>();
            }

        }

        public class Lecture
        {
            public int Ordem { get; set; }
            public string Title { get; set; }
        }


    }
}

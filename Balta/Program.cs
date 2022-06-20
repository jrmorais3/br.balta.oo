using Balta.ContentContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Balta
{
    public class Program
    {
        static void Main(string[] args)
        {
            var courses = new List<Course>();
            var courseCsharp = new Course("curso de C#", "cursodeC#.com.br");
            var courseOOP = new Course("curso de orientação a objetos", "cursoOOP.com.br");
            var courseDotnet = new Course("curso de dotnet", "cursodotnet.com.br");
            courses.Add(courseCsharp); 
            courses.Add(courseOOP); 
            courses.Add(courseDotnet);

            
            var careers = new List<Career>();
            var careerDotnet = new Career("careerDotnet", "careerDotnet.com.br");
            var DotnetItem = new CareerItem(3, "Especialista .NET",
                "Formação .net", courseDotnet);
            var CSharpItem = new CareerItem(1, "Especialista C#",
                "Formação .net", courseCsharp);
            var OOPItem = new CareerItem(2, "Orientação a objetos",
                "Formação .net", null);

            careerDotnet.Items.Add(CSharpItem);
            careerDotnet.Items.Add(OOPItem);
            careerDotnet.Items.Add(DotnetItem);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                }
            }
        }
    }
}
 
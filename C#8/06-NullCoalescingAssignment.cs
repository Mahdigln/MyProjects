using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.Features
{
    public static class NullCoalescingAssignment
    {
        public static void Demo()
        {
            var filter = new FilterCoursesViewModel();
            /*if(filter.Courses == null)
            {
                filter.Courses = new List<string>();
            }*/

            filter.Courses ??= new List<string>();  //??=  =null

            filter.Courses.Add("asp.net core");
            foreach (var course in filter.Courses)
            {
                Console.WriteLine(course);
            }
        }
    }

    public class FilterCoursesViewModel
    {
        public List<string> Courses { get; set; }

        /*public FilterCoursesViewModel()
        {
            this.Courses = new List<string> { "blazor" };
        }*/
    }
}

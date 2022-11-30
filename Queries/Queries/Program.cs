using Queries.Core.Domain;
using Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork(new LearningContext());

            // by Expression Function
            //var CousesByFind = unitOfWork.Courses.Find(a => a.Name == "C# Basics");
            //foreach (var c in CousesByFind)
            //{
            //    Console.WriteLine(c.Name);
            //}

            //var CousesByFind1 = unitOfWork.Courses.Find(a => a.Id == 6);
            //foreach (var c in CousesByFind1)
            //{
            //    Console.WriteLine(c.Name);
            //}
            //// Find Teachers 

            //var Teachers = unitOfWork.Teachers.Find(t => t.Id == 1);
            //foreach (var item in Teachers)
            //{
            //    Console.WriteLine(item.Name);
            //}
            // Find Single By Lambda Epression Tree 
            //var SingleCourse = unitOfWork.Courses.SingleOrDefault(a => a.Name == "Mosh Hamedani");
            //Console.WriteLine(SingleCourse.Name);
            // Example1
            //var course = unitOfWork.Courses.Get(1);
            //Console.WriteLine(course.Name);
            //Console.WriteLine(course.Name);
            //Console.WriteLine("Updating");

            ////Update
            //course.Name = "New Updated Course Name";
            //unitOfWork.Complete();

            //// Example2
            //var courses = unitOfWork.Courses.GetCoursesWithAuthors(1, 4);


            // Example 3

            #region Add Students
            var user = new User() { Name="1312",Age="232",Address="dddd",Email="fff",Phone="34343"};
            var Students = new Dictionary<string, Student>
                {
                    {"Muhammad", new Student (user) },
                   

                };

            #endregion
            var Teacher = new Teachers(user) { Students=Students.Values};
            unitOfWork.Teacher.Add(Teacher);
             
            //Example4
            //var teachers = unitOfWork.Teachers.GetAuthorWithCourses(1);
            //unitOfWork.Courses.RemoveRange(teachers.Courses);
            //unitOfWork.Teachers.Remove(teachers);
            //unitOfWork.Complete();
            Console.ReadKey();

        }
    }
}

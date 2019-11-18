using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace CodingTest.Basics
{
    public class GroupList
    {
        public class User
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
            public int GroupID { get; set; }
            public string GroupName { get; set; }

        }
        public class UserView
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
        }
        public class GroupView
        {
            public int GroupID { get; set; }
            public List<User> Users {get; set;}
        }
        public void GroupTest()
        {

            List<User> userList = new List<User>();
            userList.Add(new User { UserID = 1, UserName = "User-One   G-1", GroupID = 1 , GroupName = "Group 1"});
            userList.Add(new User { UserID = 2, UserName = "User-Two   G-1", GroupID = 1 , GroupName = "Group 1"});
            userList.Add(new User { UserID = 3, UserName = "User-Three G-2", GroupID = 2 , GroupName = "Group 2"});
            userList.Add(new User { UserID = 4, UserName = "User-Four  G-1", GroupID = 1 , GroupName = "Group 1"});
            userList.Add(new User { UserID = 5, UserName = "User-Five  G-3", GroupID = 3 , GroupName = "Group 3"});
            userList.Add(new User { UserID = 6, UserName = "User-Six   G-3", GroupID = 3 , GroupName = "Group 3"});

            var grouped0 = userList
                .GroupBy(u => u.GroupID)
                .Select(grp => grp.ToList())
                .ToList();

            var grouped1 = userList
                .GroupBy(u => u.GroupID)
                .Select(grp => new GroupView { GroupID = grp.Key , Users = grp.ToList()})
                .ToList();

            var grouped2 = userList
                .GroupBy(u => new { u.GroupID, u.GroupName })
                .Select(grp => new GroupView { GroupID = grp.Key.GroupID, Users = grp.ToList() })
                .ToList();

            Console.WriteLine("\n-----results 1:");
            foreach (var group in grouped1)
            {
                Console.WriteLine("Group {0}", group.GroupID);
                foreach (var user in group.Users)
                {
                    Console.WriteLine("  {0}", user.UserName);
                }
            }

            Console.WriteLine("\n------results 2:");
            foreach (var group in grouped0)
            {
                Console.WriteLine("Group {0}",-1);
                foreach (var user in group)
                {
                    Console.WriteLine("  {0}", user.UserName);
                }
            }

        }

        public void QueryNestedGroups()
        {
            var queryNestedGroups =
                from student in students
                group student by student.Year into newGroup1
                from newGroup2 in
                    (from student in newGroup1
                     group student by student.LastName)
                group newGroup2 by newGroup1.Key;

            // Three nested foreach loops are required to iterate 
            // over all elements of a grouped group. Hover the mouse 
            // cursor over the iteration variables to see their actual type.
            foreach (var outerGroup in queryNestedGroups)
            {
                Console.WriteLine($"DataClass.Student Level = {outerGroup.Key}");
                foreach (var innerGroup in outerGroup)
                {
                    Console.WriteLine($"\tNames that begin with: {innerGroup.Key}");
                    foreach (var innerGroupElement in innerGroup)
                    {
                        Console.WriteLine($"\t\t{innerGroupElement.LastName} {innerGroupElement.FirstName}");
                    }
                }
            }
        }

        public void GroupBySingleProperty()
        {
            Console.WriteLine("Group by a single property in an object:");

            // Variable queryLastNames is an IEnumerable<IGrouping<string, 
            // DataClass.Student>>. 
            var queryLastNames =
                from student in students
                group student by student.LastName into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in queryLastNames)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
        }
        public void GroupBySubstring()
        {
            Console.WriteLine("\r\nGroup by something other than a property of the object:");

            var queryFirstLetters =
                from student in students
                group student by student.LastName[0];

            foreach (var studentGroup in queryFirstLetters)
            {
                Console.WriteLine($"Key: {studentGroup.Key}");
                // Nested foreach is required to access group items.
                foreach (var student in studentGroup)
                {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
        }
        public void GroupByRange()
        {
            Console.WriteLine("\r\nGroup by numeric range and project into a new anonymous type:");

            var queryNumericRange =
                from student in students
                let percentile = GetPercentile(student)
                group new { student.FirstName, student.LastName } by percentile into percentGroup
                orderby percentGroup.Key
                select percentGroup;

            // Nested foreach required to iterate over groups and group items.
            foreach (var studentGroup in queryNumericRange)
            {
                Console.WriteLine($"Key: {studentGroup.Key * 10}");
                foreach (var item in studentGroup)
                {
                    Console.WriteLine($"\t{item.LastName}, {item.FirstName}");
                }
            }
        }
        public void GroupByBoolean()
        {
            Console.WriteLine("\r\nGroup by a Boolean into two groups with string keys");
            Console.WriteLine("\"True\" and \"False\" and project into a new anonymous type:");
            var queryGroupByAverages = from student in students
                                       group new { student.FirstName, student.LastName }
                                            by student.ExamScores.Average() > 75 into studentGroup
                                       select studentGroup;

            foreach (var studentGroup in queryGroupByAverages)
            {
                Console.WriteLine($"Key: {studentGroup.Key}");
                foreach (var student in studentGroup)
                    Console.WriteLine($"\t{student.FirstName} {student.LastName}");
            }
        }

        public void GroupByCompositeKey()
        {
            var queryHighScoreGroups =
                from student in students
                group student by new
                {
                    FirstLetter = student.LastName[0],
                    Score = student.ExamScores[0] > 85
                } into studentGroup
                orderby studentGroup.Key.FirstLetter
                select studentGroup;

            Console.WriteLine("\r\nGroup and order by a compound key:");
            foreach (var scoreGroup in queryHighScoreGroups)
            {
                string s = scoreGroup.Key.Score == true ? "more than" : "less than";
                Console.WriteLine($"Name starts with {scoreGroup.Key.FirstLetter} who scored {s} 85");
                foreach (var item in scoreGroup)
                {
                    Console.WriteLine($"\t{item.FirstName} {item.LastName}");
                }
            }
        }


        //Helper method, used in GroupByRange.
        protected static int GetPercentile(Student s)
        {
            double avg = s.ExamScores.Average();
            return avg > 0 ? (int)avg / 10 : 0;
        }



        public void QueryHighScores(int exam, int score)
        {
            var highScores = from student in students
                             where student.ExamScores[exam] > score
                             select new { Name = student.FirstName, Score = student.ExamScores[exam] };

            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.Name,-15}{item.Score}");
            }
        }

        protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };
        protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public GradeLevel Year;
            public List<int> ExamScores;
        }
        protected static List<Student> students = new List<Student>
        {
            new Student {FirstName = "Terry", LastName = "Adams", ID = 120,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 99, 82, 81, 79}},
            new Student {FirstName = "Fadi", LastName = "Fakhouri", ID = 116,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 99, 86, 90, 94}},
            new Student {FirstName = "Hanying", LastName = "Feng", ID = 117,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 93, 92, 80, 87}},
            new Student {FirstName = "Cesar", LastName = "Garcia", ID = 114,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 97, 89, 85, 82}},
            new Student {FirstName = "Debra", LastName = "Garcia", ID = 115,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 35, 72, 91, 70}},
            new Student {FirstName = "Hugo", LastName = "Garcia", ID = 118,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 92, 90, 83, 78}},
            new Student {FirstName = "Sven", LastName = "Mortensen", ID = 113,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 88, 94, 65, 91}},
            new Student {FirstName = "Claire", LastName = "O'Donnell", ID = 112,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 75, 84, 91, 39}},
            new Student {FirstName = "Svetlana", LastName = "Omelchenko", ID = 111,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 97, 92, 81, 60}},
            new Student {FirstName = "Lance", LastName = "Tucker", ID = 119,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 68, 79, 88, 92}},
            new Student {FirstName = "Michael", LastName = "Tucker", ID = 122,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 94, 92, 91, 91}},
            new Student {FirstName = "Eugene", LastName = "Zabokritski", ID = 121,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 96, 85, 91, 60}}
        };

    }
    
}


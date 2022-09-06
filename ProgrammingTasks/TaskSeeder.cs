using ProgrammingTasks.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTasks
{
    public class TaskSeeder
    {
        private readonly TaskDbContext _taskDbContext;
        public TaskSeeder(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }
        public void Seed()
        {
            if(_taskDbContext.Database.CanConnect())
            {
                if(!_taskDbContext.Tasks.Any())
                {
                    var tasks = GetTasks();
                    _taskDbContext.Tasks.AddRange(tasks);
                    _taskDbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Task> GetTasks()
        {
            var tasks = new List<Task>()
            {
                new Task()
                {
                    Name = "Add",
                    Description = "Write a function that returns the sum of two numbers.",
                    Tests = new List<Test> 
                    {
                        new Test() 
                        {
                            Input = "1,2",
                            ExpectedOutput = "3"
                        },
                        new Test()
                        {
                            Input = "2,-39",
                            ExpectedOutput = "-37"
                        }
                    } 
                },
                new Task()
                {
                    Name = "CenturyFromYear",
                    Description = "Given a year, return the century it is in." +
                    " The first century spans from the year 1 up to and including the year 100, the second - from the year 101 up to and including the year 200, etc.",
                    Tests = new List<Test>
                    {
                        new Test()
                        {
                            Input = "1905",
                            ExpectedOutput = "20"
                        },
                        new Test()
                        {
                            Input = "1700",
                            ExpectedOutput = "17"
                        }
                    }
                },
                new Task()
                {
                    Name = "CheckPalindrome",
                    Description = "Given the string, check if it is a palindrome.",
                    Tests = new List<Test>
                    {
                        new Test()
                        {
                            Input = "aabaa",
                            ExpectedOutput = "true"
                        },
                        new Test()
                        {
                            Input = "abac",
                            ExpectedOutput = "false"
                        }
                    }
                }
            };
            return tasks;
        }
    }
}

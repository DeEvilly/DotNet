using DotNet_Lab01_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Lab01_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SysInfo.PrintCurrentOSVer();
            SysInfo.PrintRAMUsage();
            Console.WriteLine();

            User user = new User("John", "Thompson", 45, new DateTime(2019, 07, 31, 15, 03, 58));

            TaskItem task1 = new TaskItem("Task 1", "Description of Task 1", DateTime.Now, DateTime.Now.AddDays(7));
            TaskItem task2 = new TaskItem("Task 2", "Description of Task 2", DateTime.Now, DateTime.Now.AddDays(14));
            TaskItem task3 = new TaskItem("Task 3", "Description of Task 3", DateTime.Now, DateTime.Now.AddDays(21));

            ToDoList toDoList = new ToDoList();
            toDoList.AddTask(task1);
            toDoList.AddTask(task2);
            toDoList.AddTask(task3);

            toDoList.MarkTaskAsCompleted(task2);

            Console.WriteLine(user + "\n");
            Console.WriteLine(toDoList);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Lab01_Core
{
    public class ToDoList
    {
        List<TaskItem> _tasks;
        int _completedTasks;
        int _uncompletedTasks;
        DateTime _modifiedAt;

        public ToDoList() 
        {
            Tasks = new List<TaskItem>();
            CompletedTasks = 0;
            UncompletedTasks = 0;
            ModifiedAt = DateTime.Now;
        }

        public ToDoList(List<TaskItem> tasks, DateTime modifiedAt)
        {
            Tasks = tasks;
            CompletedTasks = 0;
            UncompletedTasks = 0;
            ModifiedAt = modifiedAt;
        }

        public List<TaskItem> Tasks
        {
            get { return _tasks; }
            set { if (value != null) _tasks = value; }
        }

        public int CompletedTasks
        {
            get { return _completedTasks; }
            set { if (value >= 0) _completedTasks = value; }
        }

        public int UncompletedTasks
        {
            get { return _uncompletedTasks; }
            set { if (value >= 0) _uncompletedTasks = value; }
        }

        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }

        public void AddTask(TaskItem task)
        {
            if (task != null)
            {
                Tasks.Add(task);
                UncompletedTasks++;
                ModifiedAt = DateTime.Now;
            }
        }

        public void MarkTaskAsCompleted(TaskItem task)
        {
            if (task != null && Tasks.Contains(task) && !task.IsCompleted)
            {
                task.IsCompleted = true;
                CompletedTasks++;
                UncompletedTasks--;
                ModifiedAt = DateTime.Now;
            }
        }

        public void RemoveTask(TaskItem task)
        {
            if (task != null && Tasks.Contains(task))
            {
                if (task.IsCompleted)
                    CompletedTasks--;
                else
                    UncompletedTasks--;
                Tasks.Remove(task);
                ModifiedAt = DateTime.Now;
            }
        }

        public override string ToString()
        {
            string result = $"ToDoList: {Tasks.Count} tasks, {CompletedTasks} completed, {UncompletedTasks} uncompleted, " +
                $"Last Modified At: {ModifiedAt}\nTasks:\n";
            
            foreach (var task in Tasks)
            {
                result += task.ToString() + "\n\n";
            }

            return result;
        }

        public void PrintTasks()
        {
            Console.WriteLine("Tasks in ToDoList:");
            foreach (var task in Tasks)
            {
                Console.WriteLine(task + "\n");
            }
        }
    }
}

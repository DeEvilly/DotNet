using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Lab01_Core
{
    public class TaskItem
    {
        private string _title;
        private string _description;
        private DateTime _createdAt;
        private DateTime _deadline;
        private bool _isCompleted;

        public TaskItem() { }

        public TaskItem(string title, string description, DateTime createdAt, DateTime deadline)
        {
            Title = title;
            Description = description;
            CreatedAt = createdAt;
            Deadline = deadline;
            IsCompleted = false;
        }

        public string Title
        { 
            get { return _title; } 
            set { if (!string.IsNullOrWhiteSpace(value)) _title = value; }
        }

        public string Description
        { 
            get { return _description; } 
            set { if (!string.IsNullOrWhiteSpace(value)) _description = value; }
        }

        public DateTime CreatedAt
        { 
            get { return _createdAt; } 
            set { _createdAt = value; }
        }

        public DateTime Deadline
        { 
            get { return _deadline; } 
            set { _deadline = value; }
        }

        public bool IsCompleted
        { 
            get { return _isCompleted; } 
            set { _isCompleted = value; }
        }

        public override string ToString()
        {
            return $"Task: {Title}\n Description: {Description}\n " +
                $"Created At: {CreatedAt}\n Deadline: {Deadline}\n Completed: {IsCompleted}";
        }
    }
}

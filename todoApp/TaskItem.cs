using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoApp
{
    internal class TaskItem
    {
        public string Name { get; set; }
        public bool isDone { get; set; }
        public DateTime? Date { get; set; }

        public override string ToString()
        {
            return $"{(isDone ? "[X]" : "[]")} {Name}" +
                (Date.HasValue ? $" (Due: {Date.Value.ToShortDateString()})" : "");
        }

        public TaskItem(string name, bool isDone, DateTime? date)
        {
            Name = name;
            this.isDone = isDone;
            Date = date;
        }

        public TaskItem(string name) { this.Name = name; }

        public static TaskItem FromUserInput(string input)
        {
            return new TaskItem(input.Trim());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public string Category { get; set; }
        public PriorityLevel Priority { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool isDone { get; set; }
    }

    public enum PriorityLevel
    {
        Low = 0,
        Medium = 1,
        High = 2
    }
}

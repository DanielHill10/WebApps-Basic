using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApps.Areas.Todo.Models
{
    public class TaskItem
    {
        [Key]
        [Display(Name = "Id")]
        public int TaskId { get; set; }
        [Display(Name = "Task")]
        public string TaskDescription { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Completed Date")]
        public DateTime CompletedDate { get; set; }
        public bool IsComplete { get; set; }
    }
}

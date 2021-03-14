using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApps.Areas.Todo.Models;

namespace WebApps.Areas.Todo.ViewModels
{
    public class TaskItemDetailViewModel
    {
        public TaskItem TaskItem { get; set; }
        public List<TaskItem> TaskItems { get; set; }
    }
}

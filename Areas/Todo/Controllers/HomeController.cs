using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApps.Areas.Todo.Data;
using WebApps.Areas.Todo.Models;
using WebApps.Areas.Todo.ViewModels;

namespace WebApps.Areas.Todo.Controllers
{
    [Area("Todo")]
    public class HomeController : Controller
    {
        private readonly TodoDbContext _context;
        public HomeController(TodoDbContext context)
        {
            _context = context;
        }

        //Get Index
        public async Task<IActionResult> Index()
        {
            var TaskItemDetailViewModel = new TaskItemDetailViewModel();
            TaskItemDetailViewModel.TaskItems = await _context.TaskItems.Where(t => t.IsComplete != true).ToListAsync();
            return View(TaskItemDetailViewModel);
        }

        //Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Post Create
        [HttpPost]
        public async Task<IActionResult> Create(TaskItemDetailViewModel taskItemDetailViewModel)
        {
            _context.TaskItems.Add(taskItemDetailViewModel.TaskItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ToggleIsDone(int id)
        {
            var TaskItem = new TaskItem();
            TaskItem = await _context.TaskItems.FirstOrDefaultAsync(t => t.TaskId == id);
            TaskItem.IsComplete = true;
            TaskItem.CompletedDate = DateTime.Today;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}

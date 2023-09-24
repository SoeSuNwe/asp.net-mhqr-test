using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
  
//using Task = TaskManager2.Models.Task;

namespace TaskManager2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TaskManager2.AppDbContext _context;

        public IndexModel(TaskManager2.AppDbContext context)
        {
            _context = context;
        }

        public IList<TaskManager2.Models.Task> Task { get;set; } = default!;

        public async Task  OnGetAsync()
        {
            if (_context.Tasks != null)
            {
                Task = await _context.Tasks.ToListAsync();
            } 
        }
    }
}

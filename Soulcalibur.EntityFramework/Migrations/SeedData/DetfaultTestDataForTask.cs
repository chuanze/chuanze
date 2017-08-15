using System.Linq;
using Abp.Application.Editions;
using Soulcalibur.Editions;
using Soulcalibur.EntityFramework;
using System.Collections.Generic;
using Soulcalibur.Tasks;

namespace Soulcalibur.Migrations.SeedData
{
    public class DetfaultTestDataForTask
    {
        private readonly SoulcaliburDbContext _context;
        private static readonly List<Task> _tasks;
        public DetfaultTestDataForTask(SoulcaliburDbContext context)
        {
            _context = context;
        }

        static DetfaultTestDataForTask()
        {
            _tasks = new List<Task>()
            {
                new Task("Learning ABP demo","Learning how to use abp framework to bulid a MPA application."),
                new Task("Make Lunch","Cook 2 dishs")
            };
        }
        public void Create()
        {
            foreach (var task in _tasks)
            {
                if (_context.Tasks.FirstOrDefault(t => t.Title == task.Title) == null)
                {
                    _context.Tasks.Add(task);
                }
                _context.SaveChanges();
            }

        }
    }
}

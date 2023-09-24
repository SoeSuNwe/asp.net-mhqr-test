using System.Diagnostics;
using TaskManager2.Models;

namespace TaskManager2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
             
            if (context.Tasks.Any())
            {
                return;   // DB has been seeded
            }

            var tasks = new Models.Task[]
            {
                new Models.Task{Title="Carson",Description="Alexander",DueDate=DateTime.Parse("2019-09-01")},
                new Models.Task{Title="Meredith",Description="Alonso",DueDate=DateTime.Parse("2017-09-01")},
                new Models.Task{Title="Arturo",Description="Anand",DueDate=DateTime.Parse("2018-09-01")},
                new Models.Task{Title="Gytis",Description="Barzdukas",DueDate=DateTime.Parse("2017-09-01")},
                new Models.Task{Title="Yan",Description="Li",DueDate=DateTime.Parse("2017-09-01")},
                new Models.Task{Title="Peggy",Description="Justice",DueDate=DateTime.Parse("2016-09-01")},
                new Models.Task{Title="Laura",Description="Norman",DueDate=DateTime.Parse("2018-09-01")},
                new Models.Task{Title="Nino",Description="Olivetto",DueDate=DateTime.Parse("2019-09-01")}
            };

            context.Tasks.AddRange(tasks);
            context.SaveChanges(); 
              
            context.SaveChanges();
        }
    }
}

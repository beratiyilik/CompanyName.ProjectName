using CompanyName.ProjectName.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.ProjectName.Infrastructure.Data
{
    public class ProjectNameContextSeed
    {

        public static async Task SeedAsync(ProjectNameContext projectNameContext, ILoggerFactory loggerFactory, int? retry = 0)
        {
            int retryForAvailability = retry.Value;

            try
            {
                // TODO: Only run this if using a real database
                // projectNameContext.Database.Migrate();
                // projectNameContext.Database.EnsureCreated();

                if (!projectNameContext.TestParents.Any())
                {
                    projectNameContext.TestParents.AddRange(GetPreconfiguredTestParents());
                    await projectNameContext.SaveChangesAsync();
                }

                if (!projectNameContext.TestChilds.Any())
                {
                    projectNameContext.TestChilds.AddRange(GetPreconfiguredTestChilds());
                    await projectNameContext.SaveChangesAsync();
                }
            }
            catch (Exception exception)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<ProjectNameContextSeed>();
                    log.LogError(exception.Message);
                    await SeedAsync(projectNameContext, loggerFactory, retryForAvailability);
                }
                throw;
            }
        }

        private static IEnumerable<TestParent> GetPreconfiguredTestParents()
        {
            return new List<TestParent>()
            {
                new TestParent() { Name = "parent record 1", Description = "parent record 1 desc"},
                new TestParent() { Name = "parent record 2", Description = "parent record 2 desc"},
                new TestParent() { Name = "parent record 3", Description = "parent record 3 desc", State = Common.Framework.Enum.Enum.EntityState.Passive }
            };
        }

        private static IEnumerable<TestChild> GetPreconfiguredTestChilds()
        {
            return new List<TestChild>()
            {
                new TestChild() { Name = "child record 1" },
                new TestChild() { Name = "child record 2" },
                new TestChild() { Name = "child record 3" },
                new TestChild() { Name = "child record 4" },
                new TestChild() { Name = "child record 5" },
                new TestChild() { Name = "child record 6", State = Common.Framework.Enum.Enum.EntityState.Deleted },
            };
        }

    }
}

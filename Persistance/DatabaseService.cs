using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Application.Interfaces;
using Domain.Jobs;
using Persistance.Jobs;

namespace Persistance
{
    public class DatabaseService: DbContext, IDatabaseService
    {
        public IDbSet<Job> Jobs { get; set; }
        public IDbSet<JobDescription> JobDescriptions { get; set; }

        public DatabaseService() : base("name = InnerWorkingS")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new JobConfiguration());
        }
    }
}

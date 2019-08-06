using Debo.Templet.QueryService.EntityFramework.Mappings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debo.Templet.QueryService.EntityFramework
{
    public class DBContext : DbContext
    {
        private static readonly string _connetionString = ConfigurationManager.AppSettings["DBContext"];
        public DBContext() : base(_connetionString) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

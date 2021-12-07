using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSQL.Data
{
    class DataBaseInit : SqliteDropCreateDatabaseAlways<DataBaseContext>
    {
        public DataBaseInit(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(DataBaseContext context)
        {
            //base.Seed(context); 
        }
    }
}

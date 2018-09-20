using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_Operation3.Models
{
    //create context class to establish connection and query to the Db
    public class RecordContext : DbContext
    {
        public RecordContext() : base("RecordContext")
        {

        }
        public DbSet<Players> players { get; set; }
    }
}
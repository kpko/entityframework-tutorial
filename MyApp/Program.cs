using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContext ctx = new DbContext("...");
            var contacts = ctx.Database.SqlQuery<Contact>("select * from dbo.Contacts").ToList();
        }
    }

    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookClub.DAL
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {

        protected override void Seed(BookContext context)
        {
        }
    }
}

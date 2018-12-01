using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookClub.DAL
{
    public class BookClubInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookClubContext>
    {

        protected override void Seed(BookClubContext context)
        {
        }
    }
}

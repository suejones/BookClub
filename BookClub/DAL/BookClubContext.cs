using BookClub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BookClub.DAL
{

        public class BookClubContext : DbContext
        {
            public BookClubContext() : base("BookContext")
            {
            }

          
            public DbSet<BookClubContext> BookClub { get; set; }

            //to prevent EF to pluralize table names
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }

            public void MarkAsModified(Object item)
            {
                Entry(item).State = EntityState.Modified;
            }
        }
    }

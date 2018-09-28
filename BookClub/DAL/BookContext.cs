using BookClub.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BookClub.DAL
{
    public class BookContext : DbContext
    {
            public BookContext() : base("BookContext")
            {
            }

            
            public DbSet<Book> Books { get; set; }

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

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Models;

namespace ToDo.Data
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }


        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
          : base(options)//DbContext (Father class) constructor
        {
        }
    }
}

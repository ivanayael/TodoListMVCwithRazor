using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCTodoList.Models;

namespace MVCTodoList.Data
{
    public class MVCTodoListContext : DbContext
    {
        public MVCTodoListContext (DbContextOptions<MVCTodoListContext> options)
            : base(options)
        {
        }

        public DbSet<MVCTodoList.Models.TodoListItem> TodoListItem { get; set; }
    }
}

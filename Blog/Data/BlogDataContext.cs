using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=localhost,1433;
                                    Database=Blog;
                                    User ID=sa;
                                    Password=1q2w3e4r@#$;
                                    Trust Server Certificate = true;");
    }
}
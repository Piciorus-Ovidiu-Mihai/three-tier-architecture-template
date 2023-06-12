﻿using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Here you will set db context for your entities
    }
}

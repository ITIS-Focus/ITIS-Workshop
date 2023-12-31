﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Entity;

namespace Portfolio.DataAccess.Repository;

public class ApplicationContext : IdentityDbContext<User>
{
    public DbSet<Request> Requests { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
    
    public ApplicationContext(DbContextOptions options)
        :base(options) { }
}
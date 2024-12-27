using System;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public required DbSet<AppUser> Users { get; set; }

}

using Microsoft.EntityFrameworkCore;
using surfgroupfinder.Entities;
namespace surfgroupfinder.Data;

public class DataContext : DbContext {
    public DataContext(DbContextOptions options) : base(options){

    }

    public DbSet<AppUser> Users {get; set;}


}
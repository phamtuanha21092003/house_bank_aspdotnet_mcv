using Microsoft.EntityFrameworkCore;
using house_bank_aspdotnet_mcv.Models;

namespace house_bank_aspdotnet_mcv.Data;


public class ApplicationContext(DbContextOptions<ApplicationContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MessageClient.Migrations;

namespace MessageClient.Models
{
  public class MessageClientContext : IdentityDbContext<ApplicationUser>
  {
    public MessageClientContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
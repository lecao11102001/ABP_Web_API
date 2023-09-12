using Acme.IssueManagement.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.IssueManagement.EntityFrameworkCore;

[ConnectionStringName(IssueManagementDbProperties.ConnectionStringName)]
public class IssueManagementDbContext : AbpDbContext<IssueManagementDbContext>, IIssueManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public IssueManagementDbContext(DbContextOptions<IssueManagementDbContext> options)
        : base(options)
    {

    }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureIssueManagement();

        
    }
}

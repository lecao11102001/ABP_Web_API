﻿using Acme.IssueManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.IssueManagement.EntityFrameworkCore;

public static class IssueManagementDbContextModelCreatingExtensions
{
    public static void ConfigureIssueManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(IssueManagementDbProperties.DbTablePrefix + "Questions", IssueManagementDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
        builder.Entity<Book>(b =>
        {
            //Configure table & schema name
            b.ToTable("Books", IssueManagementDbProperties.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<Customer>(b =>
        {
            //Configure table & schema name
            b.ToTable("Customers", IssueManagementDbProperties.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<BookBorrow>(b =>
        {
            //Configure table & schema name
            b.ToTable("BookBorrows", IssueManagementDbProperties.DbSchema);
            b.ConfigureByConvention();
        });

        builder.Entity<BookReturn>(b =>
        {
            //Configure table & schema name
            b.ToTable("BookReturns", IssueManagementDbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}

﻿using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

/// <summary>
/// Class of project configurations. 
/// Setting relation with employees and objectives.
/// </summary>
internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasKey(p => p.Id);

        builder
            .HasMany(p => p.Employees)
            .WithMany(e => e.Projects);

        builder
            .HasOne(p => p.Leader)
            .WithMany()
            .HasForeignKey(p => p.LeaderId)
            .OnDelete(DeleteBehavior.SetNull);

        builder
            .HasMany(p => p.Objectives)
            .WithOne(o => o.Project)
            .OnDelete(DeleteBehavior.SetNull);
    }
}

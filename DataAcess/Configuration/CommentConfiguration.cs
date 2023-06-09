﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.Content).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.PostId).IsRequired(false);

            builder.HasOne(x=>x.Post).WithMany(x=>x.Comments)
                .HasForeignKey(x=>x.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.User).WithMany(x=>x.Comments)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.ParentComment).WithMany(x => x.ChildComments)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

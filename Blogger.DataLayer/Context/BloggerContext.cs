using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blogger.DataLayer.Entities.News;
using Blogger.DataLayer.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Blogger.DataLayer.Context
{
   public class BloggerContext:DbContext
    {
        public BloggerContext(DbContextOptions<BloggerContext>options):base(options)
        {
            
        }

        #region Users

        public DbSet<User> Users { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

        #endregion

        #region News

        public DbSet<News> News { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }


        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDeleted.Value);
            modelBuilder.Entity<Category>()
                .HasQueryFilter(r => !r.IsDeleted.Value);
            modelBuilder.Entity<News>()
                .HasQueryFilter(r => !r.IsDeleted);
            base.OnModelCreating(modelBuilder);
        }
    }
}

namespace Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogModel : DbContext
    {
        public BlogModel()
            : base("name=BlogEntities")
        {
        }

        public virtual DbSet<Entry> Entry { get; set; }
        public virtual DbSet<News> News { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entry>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.Author)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Text)
                .IsUnicode(false);
        }
    }
}

using Microsoft.EntityFrameworkCore;
namespace webAPIMiniReddit.Model

{
    public class DataContext : DbContext
    {
        public DbSet<Tråd> Tråde { get; set; }
        public DbSet<Kommentar> Kommentare { get; set; }

        public string DbPath { get; set; }
        public DataContext()
        {
            DbPath = "bin/miniReddit.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"DataSource={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tråd>().ToTable("Tråde");
            modelBuilder.Entity<Kommentar>().ToTable("Kommentare");
        }
    }
}

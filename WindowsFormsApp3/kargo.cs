namespace WindowsFormsApp3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class kargo : DbContext
    {
        public kargo()
            : base("name=kargo")
        {
        }

        public virtual DbSet<alici> alici { get; set; }
        public virtual DbSet<gonderen> gonderen { get; set; }
        public virtual DbSet<kargoozellik> kargoozellik { get; set; }
        public virtual DbSet<kargotakip> kargotakip { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gonderen>()
                .HasMany(e => e.kargoozellik)
                .WithRequired(e => e.gonderen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gonderen>()
                .HasMany(e => e.kargotakip)
                .WithRequired(e => e.gonderen)
                .WillCascadeOnDelete(false);
        }
    }
}

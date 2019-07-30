using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp14.Models
{
    public partial class WOOWContext : DbContext
    {
        public WOOWContext()
        {
        }

        public WOOWContext(DbContextOptions<WOOWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieGenre> MovieGenre { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=35.200.15.112,1433;Database=WOOW;user=sa;password=d8467150d!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(220);
            });

            modelBuilder.Entity<MovieGenre>(entity =>
            {
                entity.HasKey(e => new { e.GenreId, e.MovieId })
                    .HasName("PK__MovieGen__B7382C3F5011854D");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.MovieGenre)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__MovieGenr__Genre__70DDC3D8");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieGenre)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__MovieGenr__Movie__71D1E811");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.ProfileId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(320);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => new { e.ProfileId, e.MovieId })
                    .HasName("PK__Rating__9DB1A1A55EFB848C");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Rating__MovieId__75A278F5");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK__Rating__ProfileI__74AE54BC");
            });
        }
    }
}

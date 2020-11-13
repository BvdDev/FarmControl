using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FarmControl.Domain.Models
{
	public partial class FarmControlDevelopmentContext : DbContext
	{
		public FarmControlDevelopmentContext()
		{
		}

		public FarmControlDevelopmentContext(DbContextOptions<FarmControlDevelopmentContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Animal>(entity =>
			{
				entity.ToTable("Animals", "Process");

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.HasOne(d => d.AnimalType)
					.WithMany(p => p.Animals)
					.HasForeignKey(d => d.AnimalTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Animal_AnimalType");
			});

			modelBuilder.Entity<AnimalType>(entity =>
			{
				entity.ToTable("AnimalTypes", "MasterData");

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Medicine>(entity =>
			{
				entity.ToTable("Medicines", "MasterData");

				entity.Property(e => e.Id).ValueGeneratedNever();

				entity.Property(e => e.Code)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created).HasColumnType("datetime");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MenuCycle.Data.Models;

namespace MenuCycle.Data
{
    public partial class MenuServiceSodexoQAIContext : DbContext
    {
        public virtual DbSet<Covers> Covers { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<GroupLocations> GroupLocations { get; set; }
        public virtual DbSet<GroupMenus> GroupMenus { get; set; }
        public virtual DbSet<GroupRecipes> GroupRecipes { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupUsers> GroupUsers { get; set; }
        public virtual DbSet<ImportGroupLocations> ImportGroupLocations { get; set; }
        public virtual DbSet<ImportLogs> ImportLogs { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<MealPeriods> MealPeriods { get; set; }
        public virtual DbSet<MenuCycleGroups> MenuCycleGroups { get; set; }
        public virtual DbSet<MenuCycleItems> MenuCycleItems { get; set; }
        public virtual DbSet<MenuCycles> MenuCycles { get; set; }
        public virtual DbSet<MenuRecipes> MenuRecipes { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<PostProductions> PostProductions { get; set; }
        public virtual DbSet<RecipeCategories> RecipeCategories { get; set; }
        public virtual DbSet<RecipeIngredientDetails> RecipeIngredientDetails { get; set; }
        public virtual DbSet<RecipeLocationPrices> RecipeLocationPrices { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<SellPrices> SellPrices { get; set; }
        public virtual DbSet<Tariffs> Tariffs { get; set; }
        public virtual DbSet<TaxRates> TaxRates { get; set; }
        public virtual DbSet<UserLocations> UserLocations { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=ie1apiqdb02.cloudapp.net;Database=MenuServiceSodexoQAI;Trusted_Connection=True;Integrated Security = false;User ID=SQLA-VenkatSalivendra;Password=hi2o2qcDYD5ipK6DvOM7");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Covers>(entity =>
            {
                entity.HasKey(e => e.CoverId);

                entity.HasIndex(e => new { e.MenuCycleId, e.MealPeriodId, e.Day })
                    .HasName("IX_Cover")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MealPeriod)
                    .WithMany(p => p.Covers)
                    .HasForeignKey(d => d.MealPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Covers_dbo.MealPeriods_MealPeriodId");

                entity.HasOne(d => d.MenuCycle)
                    .WithMany(p => p.Covers)
                    .HasForeignKey(d => d.MenuCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Covers_dbo.MenuCycles_MenuCycleId");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Customer_UniqueExternalId")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Customer_UniqueName")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.ExternalId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GroupLocations>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.LocationId });

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_LocationId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupLocations)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupLocations_dbo.Groups_GroupId");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.GroupLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupLocations_dbo.Locations_LocationId");
            });

            modelBuilder.Entity<GroupMenus>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.MenuId });

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.MenuId)
                    .HasName("IX_MenuId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupMenus)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupMenus_dbo.Groups_GroupId");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.GroupMenus)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupMenus_dbo.Menus_MenuId");
            });

            modelBuilder.Entity<GroupRecipes>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RecipeId });

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("IX_RecipeId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupRecipes)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupRecipes_dbo.Groups_GroupId");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.GroupRecipes)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupRecipes_dbo.Recipes_RecipeId");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Groups_UniqueExternalId")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Groups_dbo.Customers_CustomerId");
            });

            modelBuilder.Entity<GroupUsers>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId });

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupUsers)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupUsers_dbo.Groups_GroupId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GroupUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.GroupUsers_dbo.Users_UserId");
            });

            modelBuilder.Entity<ImportGroupLocations>(entity =>
            {
                entity.HasIndex(e => e.ImportLogId)
                    .HasName("IX_ImportLogId");

                entity.HasOne(d => d.ImportLog)
                    .WithMany(p => p.ImportGroupLocations)
                    .HasForeignKey(d => d.ImportLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.ImportGroupLocations_dbo.ImportLogs_ImportLogId");
            });

            modelBuilder.Entity<ImportLogs>(entity =>
            {
                entity.HasKey(e => e.ImportLogId);

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.ImportStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImportType).IsRequired();
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Locations_UniqueExternalId")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.ExternalId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Locations_dbo.Customers_CustomerId");
            });

            modelBuilder.Entity<MealPeriods>(entity =>
            {
                entity.HasKey(e => e.MealPeriodId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Menus_UniqueExternalId")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MealPeriods)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MealPeriods_dbo.Customers_CustomerId");
            });

            modelBuilder.Entity<MenuCycleGroups>(entity =>
            {
                entity.HasKey(e => new { e.MenuCycleId, e.GroupId });

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.MenuCycleId)
                    .HasName("IX_MenuCycleId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MenuCycleGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MenuCycleGroups_dbo.Groups_GroupId");

                entity.HasOne(d => d.MenuCycle)
                    .WithMany(p => p.MenuCycleGroups)
                    .HasForeignKey(d => d.MenuCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MenuCycleGroups_dbo.MenuCycles_MenuCycleId");
            });

            modelBuilder.Entity<MenuCycleItems>(entity =>
            {
                entity.HasKey(e => e.MenuCycleItemId);

                entity.HasIndex(e => e.MealPeriodId)
                    .HasName("IX_MealPeriodId");

                entity.HasIndex(e => e.MenuCycleId)
                    .HasName("IX_MenuCycleId");

                entity.HasIndex(e => e.MenuId)
                    .HasName("IX_MenuId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("IX_RecipeId");

                entity.Property(e => e.Course).HasMaxLength(255);

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.MenuName).HasMaxLength(255);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MealPeriod)
                    .WithMany(p => p.MenuCycleItems)
                    .HasForeignKey(d => d.MealPeriodId)
                    .HasConstraintName("FK_dbo.MenuCycleItems_dbo.MealPeriods_MealPeriodId");

                entity.HasOne(d => d.MenuCycle)
                    .WithMany(p => p.MenuCycleItems)
                    .HasForeignKey(d => d.MenuCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MenuCycleItems_dbo.MenuCycles_MenuCycleId");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuCycleItems)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_dbo.MenuCycleItems_dbo.Menus_MenuId");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.MenuCycleItems_dbo.MenuCycleItems_ParentId");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.MenuCycleItems)
                    .HasForeignKey(d => d.RecipeId)
                    .HasConstraintName("FK_dbo.MenuCycleItems_dbo.Recipes_RecipeId");
            });

            modelBuilder.Entity<MenuCycles>(entity =>
            {
                entity.HasKey(e => e.MenuCycleId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.HasIndex(e => new { e.MenuCycleId, e.LocationId })
                    .HasName("UniqueMenuCycleLocation")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsModifiedLocally).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MenuCycles)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MenuCycles_dbo.Customers_CustomerId");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.MenuCycles)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_dbo.MenuCycles_dbo.Locations_LocationId");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.MenuCycles_dbo.MenuCycles_ParentId");
            });

            modelBuilder.Entity<MenuRecipes>(entity =>
            {
                entity.HasIndex(e => e.MenuId)
                    .HasName("IX_MenuId");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("IX_RecipeId");

                entity.Property(e => e.Course)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuRecipes)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MenuRecipes_dbo.Menus_MenuId");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.MenuRecipes)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.MenuRecipes_dbo.Recipes_RecipeId");
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Menus_UniqueExternalId")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Menus)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Menus_dbo.Customers_CustomerId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.HasIndex(e => e.MenuCycleId)
                    .HasName("IX_MenuCycleId");

                entity.Property(e => e.Content).IsRequired();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.MenuCycle)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.MenuCycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Notes_dbo.MenuCycles_MenuCycleId");
            });

            modelBuilder.Entity<PostProductions>(entity =>
            {
                entity.HasKey(e => e.PostProductionId);

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_LocationId");

                entity.HasIndex(e => e.MenuCycleItemId)
                    .HasName("IX_MenuCycleItemId");

                entity.HasIndex(e => e.TariffId)
                    .HasName("IX_TariffId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.NoChargeApplied).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequiredQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnToStock).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PostProductions)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_dbo.PostProductions_dbo.Locations_LocationId");

                entity.HasOne(d => d.MenuCycleItem)
                    .WithMany(p => p.PostProductions)
                    .HasForeignKey(d => d.MenuCycleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.PostProductions_dbo.MenuCycleItems_MenuCycleItemId");

                entity.HasOne(d => d.Tariff)
                    .WithMany(p => p.PostProductions)
                    .HasForeignKey(d => d.TariffId)
                    .HasConstraintName("FK_dbo.PostProductions_dbo.Tariffs_TariffId");
            });

            modelBuilder.Entity<RecipeCategories>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.CategoryExternalId, e.CategoryName });

                entity.HasIndex(e => e.RecipeId)
                    .HasName("IX_RecipeId");

                entity.Property(e => e.CategoryExternalId).HasMaxLength(128);

                entity.Property(e => e.CategoryName).HasMaxLength(128);

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeCategories)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RecipeCategories_dbo.Recipes_RecipeId");
            });

            modelBuilder.Entity<RecipeIngredientDetails>(entity =>
            {
                entity.HasKey(e => e.RecipeId);

                entity.HasIndex(e => e.RecipeId)
                    .HasName("IX_RecipeId");

                entity.Property(e => e.RecipeId).ValueGeneratedNever();

                entity.Property(e => e.EnergyKcalPerServing).HasColumnName("EnergyKCalPerServing");

                entity.Property(e => e.EnergyKjperServing).HasColumnName("EnergyKJperServing");

                entity.HasOne(d => d.Recipe)
                    .WithOne(p => p.RecipeIngredientDetails)
                    .HasForeignKey<RecipeIngredientDetails>(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RecipeIngredientDetails_dbo.Recipes_RecipeId");
            });

            modelBuilder.Entity<RecipeLocationPrices>(entity =>
            {
                entity.HasKey(e => new { e.RecipeId, e.LocationId });

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_LocationId");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("IX_RecipeId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RecipeLocationPrices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RecipeLocationPrices_dbo.Customers_CustomerId");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.RecipeLocationPrices)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RecipeLocationPrices_dbo.Locations_LocationId");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeLocationPrices)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.RecipeLocationPrices_dbo.Recipes_RecipeId");
            });

            modelBuilder.Entity<Recipes>(entity =>
            {
                entity.HasKey(e => e.RecipeId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Recipes_UniqueExternalId")
                    .IsUnique();

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Recipes_dbo.Customers_CustomerId");
            });

            modelBuilder.Entity<SellPrices>(entity =>
            {
                entity.HasKey(e => e.SellPriceId);

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_LocationId");

                entity.HasIndex(e => e.MenuCycleItemId)
                    .HasName("IX_MenuCycleItemId");

                entity.HasIndex(e => e.TariffId)
                    .HasName("IX_TariffId");

                entity.HasIndex(e => e.TaxRateId)
                    .HasName("IX_TaxRateId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SellPrices)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_dbo.SellPrices_dbo.Locations_LocationId");

                entity.HasOne(d => d.MenuCycleItem)
                    .WithMany(p => p.SellPrices)
                    .HasForeignKey(d => d.MenuCycleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SellPrices_dbo.MenuCycleItems_MenuCycleItemId");

                entity.HasOne(d => d.Tariff)
                    .WithMany(p => p.SellPrices)
                    .HasForeignKey(d => d.TariffId)
                    .HasConstraintName("FK_dbo.SellPrices_dbo.Tariffs_TariffId");

                entity.HasOne(d => d.TaxRate)
                    .WithMany(p => p.SellPrices)
                    .HasForeignKey(d => d.TaxRateId)
                    .HasConstraintName("FK_dbo.SellPrices_dbo.TaxRates_TaxRateId");
            });

            modelBuilder.Entity<Tariffs>(entity =>
            {
                entity.HasKey(e => e.TariffId);

                entity.HasIndex(e => e.CustomerCustomerId)
                    .HasName("IX_Customer_CustomerId");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerCustomerId).HasColumnName("Customer_CustomerId");

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CustomerCustomer)
                    .WithMany(p => p.Tariffs)
                    .HasForeignKey(d => d.CustomerCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Tariffs_dbo.Customers_Customer_CustomerId");
            });

            modelBuilder.Entity<TaxRates>(entity =>
            {
                entity.HasKey(e => e.TaxRateId);

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserLocations>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LocationId });

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_LocationId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CanCreateMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanDeleteMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanEditMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.UserLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserLocations_dbo.Locations_LocationId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLocations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserLocations_dbo.Users_UserId");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.ExternalId)
                    .HasName("IX_Users_UniqueExternalId")
                    .IsUnique();

                entity.Property(e => e.CanCreateMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanDeleteMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanEditMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanLockMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanPublishMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanViewMenu).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanViewMenuCycle).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanViewRecipe).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreatedUtc).HasColumnType("datetime");

                entity.Property(e => e.DateUpdatedUtc).HasColumnType("datetime");

                entity.Property(e => e.ExternalId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedByExternalId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Users_dbo.Customers_CustomerId");
            });
        }
    }
}

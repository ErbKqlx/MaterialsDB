using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MaterialsDB.Models;

public partial class PartnersContext : DbContext
{
    public PartnersContext()
    {
    }

    public PartnersContext(DbContextOptions<PartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

    public virtual DbSet<PriceHistory> PriceHistories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsMaterial> ProductsMaterials { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SuppliersMaterial> SuppliersMaterials { get; set; }

    public virtual DbSet<TypesOfPartner> TypesOfPartners { get; set; }

    public virtual DbSet<TypesOfProduct> TypesOfProducts { get; set; }

    public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Partners;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Materials_pkey");

            entity.ToTable("materials");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Materials_id_seq\"'::regclass)");
            entity.Property(e => e.IdUnit).HasColumnName("Id_Unit");
            entity.Property(e => e.Image).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.IdUnitNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.IdUnit)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("materials_Id_Unit_fkey");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_pkey");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, 6L, null, null, null);
            entity.Property(e => e.Inn)
                .HasMaxLength(12)
                .HasColumnName("INN");
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasOne(d => d.IdTypeOfPartnerNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdTypeOfPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_IdTypeOfPartner_fkey");
        });

        modelBuilder.Entity<PartnersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_Products_pkey");

            entity.ToTable("Partners_Products");

            entity.HasOne(d => d.IdPartnerNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_Products_IdPartner_fkey");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Partners_Products_IdProduct_fkey");
        });

        modelBuilder.Entity<PriceHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("price_history_pkey");

            entity.ToTable("price_history");

            entity.Property(e => e.IdMaterial).HasColumnName("Id_Material");
            entity.Property(e => e.Price).HasColumnType("money");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.PriceHistories)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("price_history_Id_Material_fkey");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.MinimalPrice).HasColumnType("money");

            entity.HasOne(d => d.IdTypeOfProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdTypeOfProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Products_IdTypeOfProduct_fkey");
        });

        modelBuilder.Entity<ProductsMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_materials_pkey");

            entity.ToTable("products_materials");

            entity.Property(e => e.IdMaterial).HasColumnName("Id_Material");
            entity.Property(e => e.IdProduct).HasColumnName("Id_Product");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.ProductsMaterials)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products_materials_Id_Material_fkey");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.ProductsMaterials)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("products_materials_Id_Product_fkey");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Inn).HasMaxLength(12);
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<SuppliersMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_materials_pkey");

            entity.ToTable("suppliers_materials");

            entity.Property(e => e.IdMaterial).HasColumnName("Id_Material");
            entity.Property(e => e.IdSupplier).HasColumnName("Id_Supplier");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.SuppliersMaterials)
                .HasForeignKey(d => d.IdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("suppliers_materials_Id_Material_fkey");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.SuppliersMaterials)
                .HasForeignKey(d => d.IdSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("suppliers_materials_Id_Supplier_fkey");
        });

        modelBuilder.Entity<TypesOfPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesOfPartners_pkey");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(5L, null, null, null, null, null);
        });

        modelBuilder.Entity<TypesOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TypesOfProducts_pkey");

            entity.Property(e => e.Id).HasIdentityOptions(null, null, 6L, null, null, null);
        });

        modelBuilder.Entity<UnitsOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("units_of_measurement_pkey");

            entity.ToTable("units_of_measurement");

            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

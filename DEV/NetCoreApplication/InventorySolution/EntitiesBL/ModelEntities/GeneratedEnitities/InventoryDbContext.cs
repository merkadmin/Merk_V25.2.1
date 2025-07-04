﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntitiesBL.ModelEntities.GeneratedEnitities;

public partial class InventoryDbContext : DbContext
{
    public InventoryDbContext()
    {
    }

    public InventoryDbContext(DbContextOptions<InventoryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InventoryCategoryCu> InventoryCategoryCus { get; set; }

    public virtual DbSet<InventoryItemBrandCu> InventoryItemBrandCus { get; set; }

    public virtual DbSet<InventoryItemCategoryCu> InventoryItemCategoryCus { get; set; }

    public virtual DbSet<InventoryItemCu> InventoryItemCus { get; set; }

    public virtual DbSet<InventoryStoreCategoryCu> InventoryStoreCategoryCus { get; set; }

    public virtual DbSet<InventoryStoreCu> InventoryStoreCus { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=RAYADWSCOMREC\\RAYADWSCSQLSRV;Initial Catalog=Inventory;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InventoryCategoryCu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InventoryItemCategory_cu");

            entity.ToTable("InventoryCategory_cu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChartOfAccountCuId).HasColumnName("ChartOfAccount_CU_ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.NameP)
                .HasMaxLength(150)
                .HasColumnName("Name_P");
            entity.Property(e => e.NameS)
                .HasMaxLength(150)
                .HasColumnName("Name_S");
        });

        modelBuilder.Entity<InventoryItemBrandCu>(entity =>
        {
            entity.ToTable("InventoryItemBrand_cu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChartOfAccountCuId).HasColumnName("ChartOfAccount_CU_ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.NameP)
                .HasMaxLength(150)
                .HasColumnName("Name_P");
            entity.Property(e => e.NameS)
                .HasMaxLength(150)
                .HasColumnName("Name_S");
        });

        modelBuilder.Entity<InventoryItemCategoryCu>(entity =>
        {
            entity.ToTable("InventoryItem_Category_cu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InventoryCategoryCuId).HasColumnName("InventoryCategory_CU_ID");
            entity.Property(e => e.InventoryItemCuId).HasColumnName("InventoryItem_CU_ID");

            entity.HasOne(d => d.InventoryCategoryCu).WithMany(p => p.InventoryItemCategoryCus)
                .HasForeignKey(d => d.InventoryCategoryCuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryItem_Category_cu_InventoryCategory_cu");

            entity.HasOne(d => d.InventoryItemCu).WithMany(p => p.InventoryItemCategoryCus)
                .HasForeignKey(d => d.InventoryItemCuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryItem_Category_cu_InventoryItem_cu");
        });

        modelBuilder.Entity<InventoryItemCu>(entity =>
        {
            entity.ToTable("InventoryItem_cu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AbbreviationName).HasMaxLength(10);
            entity.Property(e => e.AreaUnitMeasurePId).HasColumnName("AreaUnitMeasure_P_ID");
            entity.Property(e => e.Code).HasMaxLength(200);
            entity.Property(e => e.DefaultBarcode).HasMaxLength(200);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.InDescription).HasMaxLength(100);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(150);
            entity.Property(e => e.InventoryItemBrandCuId).HasColumnName("InventoryItemBrand_CU_ID");
            entity.Property(e => e.InventoryItemInvoicingStrategyPId).HasColumnName("InventoryItemInvoicingStrategy_P_ID");
            entity.Property(e => e.InventoryItemStatePurchasingTypePId).HasColumnName("InventoryItemStatePurchasingType_P_ID");
            entity.Property(e => e.InventoryItemStateSellingTypePId).HasColumnName("InventoryItemStateSellingType_P_ID");
            entity.Property(e => e.InventoryItemTypePId).HasColumnName("InventoryItemType_P_ID");
            entity.Property(e => e.ItemSku)
                .HasMaxLength(50)
                .HasColumnName("ItemSKU");
            entity.Property(e => e.NameP)
                .HasMaxLength(150)
                .HasColumnName("Name_P");
            entity.Property(e => e.NameS)
                .HasMaxLength(150)
                .HasColumnName("Name_S");
            entity.Property(e => e.OutDescription).HasMaxLength(100);
            entity.Property(e => e.PurchasingDescription).HasMaxLength(100);
            entity.Property(e => e.SellingEndDate).HasColumnType("datetime");
            entity.Property(e => e.SellingStartDate).HasColumnType("datetime");
            entity.Property(e => e.SizeUnitMeasurePId).HasColumnName("SizeUnitMeasure_P_ID");
            entity.Property(e => e.VolumeUnitMeasurePId).HasColumnName("VolumeUnitMeasure_P_ID");
            entity.Property(e => e.WeightUnitPId).HasColumnName("WeightUnit_P_ID");

            entity.HasOne(d => d.InventoryItemBrandCu).WithMany(p => p.InventoryItemCus)
                .HasForeignKey(d => d.InventoryItemBrandCuId)
                .HasConstraintName("FK_InventoryItem_cu_InventoryItemBrand_cu");
        });

        modelBuilder.Entity<InventoryStoreCategoryCu>(entity =>
        {
            entity.ToTable("InventoryStore_Category_cu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InventoryCategoryCuId).HasColumnName("InventoryCategory_CU_ID");
            entity.Property(e => e.InventoryStoreCuId).HasColumnName("InventoryStore_CU_ID");

            entity.HasOne(d => d.InventoryCategoryCu).WithMany(p => p.InventoryStoreCategoryCus)
                .HasForeignKey(d => d.InventoryCategoryCuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryStore_Category_cu_InventoryCategory_cu");

            entity.HasOne(d => d.InventoryStoreCu).WithMany(p => p.InventoryStoreCategoryCus)
                .HasForeignKey(d => d.InventoryStoreCuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventoryStore_Category_cu_InventoryStore_cu");
        });

        modelBuilder.Entity<InventoryStoreCu>(entity =>
        {
            entity.ToTable("InventoryStore_cu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChartOfAccountCuId).HasColumnName("ChartOfAccount_CU_ID");
            entity.Property(e => e.DepartmentCuId).HasColumnName("Department_CU_ID");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.FloorCuId).HasColumnName("Floor_CU_ID");
            entity.Property(e => e.InChargeId).HasColumnName("InChargeID");
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.InventoryCategoryCuId).HasColumnName("InventoryCategory_CU_ID");
            entity.Property(e => e.LocationCuId).HasColumnName("Location_CU_ID");
            entity.Property(e => e.NameP)
                .HasMaxLength(150)
                .HasColumnName("Name_P");
            entity.Property(e => e.NameS)
                .HasMaxLength(150)
                .HasColumnName("Name_S");
            entity.Property(e => e.ParentInventoryStoreCuId).HasColumnName("ParentInventoryStore_CU_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

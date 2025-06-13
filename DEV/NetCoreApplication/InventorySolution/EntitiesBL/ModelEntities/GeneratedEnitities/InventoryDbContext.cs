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

    public virtual DbSet<InventoryItemBrandCu> InventoryItemBrandCus { get; set; }

    public virtual DbSet<InventoryItemCategoryCu> InventoryItemCategoryCus { get; set; }

    public virtual DbSet<InventoryItemCu> InventoryItemCus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=RAYADWSCOMREC\\RAYADWSCSQLSRV;Initial Catalog=Inventory;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InventoryItemBrandCu>(entity =>
        {
            entity.ToTable("InventoryItemBrand_cu");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
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
            entity.ToTable("InventoryItemCategory_cu");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
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

        modelBuilder.Entity<InventoryItemCu>(entity =>
        {
            entity.ToTable("InventoryItem_cu");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
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
            entity.Property(e => e.InventoryItemCategoryCuId).HasColumnName("InventoryItemCategory_CU_ID");
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

            entity.HasOne(d => d.InventoryItemCategoryCu).WithMany(p => p.InventoryItemCus)
                .HasForeignKey(d => d.InventoryItemCategoryCuId)
                .HasConstraintName("FK_InventoryItem_cu_InventoryItemCategory_cu");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

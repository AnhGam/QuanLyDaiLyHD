using Microsoft.EntityFrameworkCore;
using QuanLyDaiLyHD.Models;

namespace QuanLyDaiLyHD.Data;

public partial class DataContext : DbContext 
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<QuanLyDaiLyHD.Models.DaiLy> DaiLies { get; set; } = null!;
    public DbSet<QuanLyDaiLyHD.Models.LoaiDaiLy> LoaiDaiLies { get; set; } = null!;
    public DbSet<QuanLyDaiLyHD.Models.Quan> Quans { get; set; } = null!;

    public DbSet<QuanLyDaiLyHD.Models.ThamSo> ThamSos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LoaiDaiLy>()
            .HasMany(ldl => ldl.DaiLies)
            .WithOne(dl =>  dl.LoaiDaiLy)
            .HasForeignKey(dl => dl.MaLoaiDaiLy)
            .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<Quan>()
            .HasMany(q => q.DaiLies)
            .WithOne(dl => dl.Quan)
            .HasForeignKey(dl => dl.MaQuan)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
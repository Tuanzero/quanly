using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLNH_APIs.Models;
using System.Globalization;

namespace QLNH_APIs.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<LoaiMonan> LoaiMonan { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<Ban> Ban { get; set; }
        public DbSet<Donvi> Donvi { get; set; }
        public DbSet<HinhMonan> HinhMonan { get; set; }
        public DbSet<Loaidonvi> Loaidonvi { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<TrangThai> TrangThai { get; set; }
        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<NhaHang> NhaHang { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = new[] { "NgayTao", "NgayCapNhat" };

                foreach (var propertyName in properties)
                {
                    var property = entity.FindProperty(propertyName);
                    if (property != null && property.ClrType == typeof(DateTime))
                    {
                        property.SetValueConverter(new ValueConverter<DateTime, string>(
                            v => v.ToString("dd-MM-yyyy"),
                            v => DateTime.ParseExact(v, "dd-MM-yyyy", CultureInfo.InvariantCulture)
                        ));
                    }
                }
            }
        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Modelo
{
    public class Context : DbContext
    {
        public string conexion = "Data Source=LAPTOP-RHFQ1TRV\\SQLEXPRESS;Initial Catalog=\"BD Final DAS\";Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";


        // CADENA DE FRANCIS: Data Source=LAPTOP-RHFQ1TRV\\SQLEXPRESS;Initial Catalog=\"BD Final DAS\";Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;
        // CADENA DE MAXI: Data Source=MAXI\\SQLEXPRESS;Initial Catalog=TrabajoFinalADS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleVenta>()
                .HasOne(d => d.Venta)
                .WithMany() // o .WithMany(v => v.Detalles) si agregas la colección en Venta
                .HasForeignKey(d => d.IDVenta);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(d => d.Producto)
                .WithMany() // o .WithMany(p => p.DetalleVentas) si agregas la colección en Producto
                .HasForeignKey(d => d.IDProducto);
        }
    }
}

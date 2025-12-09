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
        // Conexion a la base de datos
        public string conexion = "Data Source=MAXI\\SQLEXPRESS;Initial Catalog=TrabajoFinalADS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";

        // Cadenas de conexion de los chads que hicieron esto posible <3

        // CADENA DE FRANCIS: Data Source=LAPTOP-RHFQ1TRV\\SQLEXPRESS;Initial Catalog=\"BD Final DAS\";Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;
        // CADENA DE MAXI: Data Source=MAXI\\SQLEXPRESS;Initial Catalog=TrabajoFinalADS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;
        // CADENA DE MONTAÑA: Data Source=JUANMONTANER\\SQLEXPRESS;Initial Catalog=FinalDAS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;

        // DbSets de cada entidad para crear las tablas 
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(conexion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleVenta>()
                .HasOne(d => d.Venta)
                .WithMany() 
                .HasForeignKey(d => d.IDVenta);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(d => d.Producto)
                .WithMany() 
                .HasForeignKey(d => d.IDProducto);
        }
    }
}

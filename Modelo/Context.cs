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
        public string conexion = "Data Source=MAXI\\SQLEXPRESS;Initial Catalog=TrabajoFinalADS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False;";

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(conexion);
    }
}

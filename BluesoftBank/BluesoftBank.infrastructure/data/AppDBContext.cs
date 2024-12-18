using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluesoftBank.core.entidades;
using Microsoft.EntityFrameworkCore;

namespace BluesoftBank.infrastructure.data
{
    public class AppDBContext : DbContext
    {
        public virtual DbSet<TipoCuenta> TipoCuentas { get; set; }
        public virtual DbSet<TipoCliente> TipoClientes { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public AppDBContext() { }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=12345678;database=bluesoftbank");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<TipoCuenta>(entity =>
            {
                entity.ToTable("tipo_cuenta");
                entity.Property(tc => tc.Id).HasColumnName("id");
                entity.Property(tc => tc.Descripcion).HasColumnName("descripcion");
                

            });

            modelBuilder.Entity<TipoCliente>(entity =>
            {
                entity.ToTable("tipo_cliente");
                entity.Property(tc => tc.Id).HasColumnName("id");
                entity.Property(tc => tc.Descripcion).HasColumnName("descripcion");
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.ToTable("tipo_movimiento");
                entity.Property(tc => tc.Id).HasColumnName("id");
                entity.Property(tc => tc.Descripcion).HasColumnName("descripcion");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
                entity.Property(e => e.NumeroIdentificacion).HasColumnName("tipo_identificacion");
                entity.Property(e => e.IdTipoCliente).HasColumnName("id_tipo_cliente");

                entity.HasOne(e => e.TipoCliente).WithMany(tc => tc.Clientes)
                .HasForeignKey(e => e.IdTipoCliente).OnDelete(DeleteBehavior.Restrict);

            });

            base.OnModelCreating(modelBuilder);
        }

    }
}

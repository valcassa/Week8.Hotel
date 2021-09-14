using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Week6.EF;

namespace ConsoleApp3
{
    internal class KnightsContext : DbContext
    {
        //Proprietà di tipo DbSet (una per ogni entità che voglio mappare sul db)
        public DbSet<Knights> Knights { get; set; } //La tabella sul db si chiamerà Knights
                                                    //(se non faccio mapping tramite convenzioni)
        public DbSet<Weapon> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
		Database=KnightsDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Knights>()
                            .HasMany(k => k.Battles)
                            .WithMany(b => b.KnightId)
                            .UsingEntity<BattleKnight>(bk => bk.HasOne<Battle>().WithMany(),
                            bk => bk.HasOne<Knights>().WithMany())
                            .Property(bk => bk.DateJoined);
                          //  .HasDefaultValue(DateTime.Now)
                }
    }
}
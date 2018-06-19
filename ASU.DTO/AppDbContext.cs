using ASU.DTO.Actors;
using ASU.DTO.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASU.DTO
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Declarant> Declarants { get; set; }
        public DbSet<Verificator> Verificators { get; set; }
        public DbSet<TestEquipment> TestEquipments { get; set; }
        public DbSet<MeasurementType> MeasurementTypes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CARBY_KURSACH_.Models
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Audi> AudiS { get; set; }
        public DbSet<BMW> BMWS { get; set; }
        public DbSet<Chevrolet> ChevroletS { get; set; }
        public DbSet<Dacia> DaciaS { get; set; }
        public DbSet<Ford> FordS { get; set; }
        public DbSet<Honda> HondaS { get; set; }
        public DbSet<Infiniti> InfinitiS { get; set; }
        public DbSet<Jaguar> JaguarS { get; set; }
        public DbSet<Kia> KiaS { get; set; }
        public DbSet<Lada> LadaS { get; set; }
        public DbSet<Mazda> MazdaS { get; set; }
        public DbSet<Nissan> NissanS { get; set; }
        public DbSet<Porsche> PorscheS { get; set; }
        public DbSet<Tesla> TeslaS { get; set; }

    }
}
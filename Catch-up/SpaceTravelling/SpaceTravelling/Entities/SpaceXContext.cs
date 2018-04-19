using Microsoft.EntityFrameworkCore;
using SpaceTravelling.Models;

namespace SpaceTravelling.Entities
{
    public class SpaceXContext : DbContext
    {
        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<Spaceship> Spaceships { get; set; }

        public SpaceXContext(DbContextOptions<SpaceXContext> options) : base(options)
        {
        }

    }
}

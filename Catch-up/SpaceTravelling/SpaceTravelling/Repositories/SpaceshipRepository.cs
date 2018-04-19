using SpaceTravelling.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpaceTravelling.Repositories
{
    public class SpaceshipRepository : ITravelInSpace
    {
        SpaceXContext Context;

        public SpaceshipRepository(SpaceXContext spaceXContext)
        {
            this.Context = spaceXContext;
        }

        public List<Planet> GetAllPlanets()
        {
            return Context.Planet.ToList();
        }

        public Planet GetPlanet(int planetID)
        {
            return Context.Planet.FirstOrDefault(p => p.Id == planetID);
        }

        public Spaceship GetSpaceship()
        {
            return Context.Spaceship.FirstOrDefault();
        }

        public void MoveToPlanet(int planetID)
        {
            int passengers = GetSpaceship().Utilization;
            GetSpaceship().Utilization -= passengers;
            Planet destination = GetPlanet(planetID);
            destination.Population += passengers;
            Context.SaveChanges();
        }

        public void MoveToShip(int planetID)
        {
            int passengers = GetSpaceship().MaxCapacity - GetSpaceship().Utilization;
            Planet source = GetPlanet(planetID);
            source.Population -= passengers;
            GetSpaceship().Utilization += passengers;
        }

        public void TravelToPlanet(int planetID)
        {
            string planetname = Context.Planet.FirstOrDefault(p => p.Id == planetID).Name;
            GetSpaceship().Planet = planetname;
            Context.SaveChanges();
        }


    }
}

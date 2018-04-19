using Microsoft.EntityFrameworkCore;
using SpaceTravelling.Entities;
using SpaceTravelling.Models;
using System.Collections.Generic;
using System.Linq;

namespace SpaceTravelling.Repositories
{

    public class SpaceXRepository : ICrudSpaceX
    {
        SpaceXContext context;

        public SpaceXRepository(SpaceXContext context)
        {
            this.context = context;
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            context.Spaceships.Load();
            return context.Planets.ToList();
        }
        public void MovePplToPlanet()
        {

        }

        public void MovePplToShip()
        {
            throw new System.NotImplementedException();
        }

        public void MoveShipToPlanet()
        {
            throw new System.NotImplementedException();
        }

        public Spaceship GetShip(int shipID)
        {
            return context.Spaceships.FirstOrDefault(s => s.Id == shipID);
        }
    }
}

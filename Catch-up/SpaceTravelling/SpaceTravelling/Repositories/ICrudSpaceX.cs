using SpaceTravelling.Models;
using System.Collections.Generic;

namespace SpaceTravelling.Repositories
{
    public interface ICrudSpaceX
    {
        void MovePplToShip();
        void MovePplToPlanet();
        void MoveShipToPlanet();
        IEnumerable<Planet> GetAllPlanets();
    }
}

using SpaceTravelling.Models;
using System.Collections.Generic;

namespace SpaceTravelling.Repositories
{
    interface ITravelInSpace
    {
        void MoveToPlanet(int planetID);
        void MoveToShip(int planetID);
        void TravelToPlanet(int planetID);

        Spaceship GetSpaceship();
        List<Planet> GetAllPlanets();
        Planet GetPlanet(int planetID);

    }
}

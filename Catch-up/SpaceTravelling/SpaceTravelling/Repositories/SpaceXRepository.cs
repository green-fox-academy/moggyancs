using SpaceTravelling.Entities;

namespace SpaceTravelling.Repositories
{

    public class SpaceXRepository : ICrudSpaceX
    {
        SpaceXContext context;

        public SpaceXRepository(SpaceXContext context)
        {
            this.context = context;
        }
    }
}

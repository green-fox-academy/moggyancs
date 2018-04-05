using Counter.Services;

namespace Counter.Controllers
{
    public class VisitorCounter : IVisitorIncrement
    {
        public int Visitors { get; set; } = 1;

        public int GetVisitors()
        {
            return Visitors;
        }

        public void IncrementVisitors()
        {
            Visitors++;
        }
    }
}

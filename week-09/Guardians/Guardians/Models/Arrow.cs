namespace Guardians.Controllers
{
    internal class Arrow
    {
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Speed { get; set; }

        public Arrow(double distance, double time)
        {
            Distance = distance;
            Time = time;
            Speed = distance / time;
        }
    }
}
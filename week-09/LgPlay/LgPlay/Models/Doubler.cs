namespace LgPlay.Models
{
    public class Doubler
    {
        public double? Received { get; set; }
        public double? Result { get; set; }

        public Doubler(double? received)
        {
            Received = received;
            Result = 2 * received;
        }
    }
}

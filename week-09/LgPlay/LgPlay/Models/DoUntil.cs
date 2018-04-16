namespace LgPlay.Controllers
{
    internal class DoUntil
    {
        public int Result { get; set; }

        public int Sum(int result)
        {
            if (result == 0)
            {
                return result;
            }
            else
            {
                return result + Sum(result - 1);
            }
        }

        public int Fact(int result)
        {
            if (result == 1)
            {
                return result;
            }
            else
            {
                return result * Fact(result - 1);
            }
        }
    }

}
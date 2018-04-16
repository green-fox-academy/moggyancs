namespace LgPlay.Models
{
    public class ArrayMath
    {
        public int Result { get; set; }

        internal int ArraySum(Numbers numbers)
        {
            for (int i = 0; i < numbers.NumberArray.Length; i++)
            {
                Result += (int)numbers.NumberArray[i];
            }

            return Result;
        }
    }
}

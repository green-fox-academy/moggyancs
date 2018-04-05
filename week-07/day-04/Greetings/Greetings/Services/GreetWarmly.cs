namespace Greetings.Services
{
    public class GreetWarmly : IGreetYou
    {
        public string CurrentVisitor { get; set; }

        public string GreetThee(string currentVisitor)
        {
            this.CurrentVisitor = currentVisitor;
            return $"Warm welcome, dear {currentVisitor}. How are you doing today?";
        }
    }
}

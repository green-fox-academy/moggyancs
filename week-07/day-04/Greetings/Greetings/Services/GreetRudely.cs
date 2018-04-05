namespace Greetings.Services
{
    public class GreetRudely : IGreetYou
    {
        private string CurrentVisitor;

        public string GreetThee(string currentVisitor)
        {
            this.CurrentVisitor = currentVisitor;
            return $"Hey, {currentVisitor}, mind your own business, and get outta here!";
        }
    }
}

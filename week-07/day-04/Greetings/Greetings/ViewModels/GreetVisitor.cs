using Greetings.Services;

namespace Greetings.ViewModels
{
    public class GreetVisitor
    {
        string visitor;
        IGreetYou greeter;

        public GreetVisitor(IGreetYou Greeter, string visitor)
        {
            this.visitor = visitor;
            Greeter.GreetThee(visitor);
        }

        public string GetGreet()
        {
            return greeter.GreetThee(visitor);

        }
    }
}

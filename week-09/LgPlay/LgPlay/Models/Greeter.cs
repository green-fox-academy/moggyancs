namespace LgPlay.Controllers
{
    internal class Greeter
    {
        private string name;
        private string title;
        public string Welcome_message { get; set; }

        public Greeter(string name, string title)
        {
            this.name = name;
            this.title = title;
            Welcome_message = $"Oh, hi there {name}, my dear {title}!";
        }
    }
}
namespace Guardians.Controllers
{
    internal class Translator
    {
        public string Received { get; set; }
        public string Translated { get; set; }

        public Translator(string message)
        {

            Translated = "I am Groot!";
            Received = message;

        }
    }
}
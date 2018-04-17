namespace Guardians.Controllers
{
    internal class Errors
    {
        public string Error { get; set; }

        public Errors(string error)
        {
            Error = error;
        }
    }
}
namespace LgPlay.Controllers
{
    internal class AppendA
    {
        private string appendable;
        public string Appended { get; set; }

        public AppendA(string appendable)
        {
            this.appendable = appendable;
            Appended = $"{appendable}a";
        }
    }
}
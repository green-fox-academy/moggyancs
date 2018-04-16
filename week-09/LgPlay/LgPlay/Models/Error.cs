namespace LgPlay.Models
{
    public class ErrorMsg
    {
        public string Error { get; set; }
        private string missing;

        public ErrorMsg(string missing)
        {
            this.missing = missing;
            Error = $"Please provide {missing}!";
        }
    }
}

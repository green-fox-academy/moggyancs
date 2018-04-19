using Newtonsoft.Json;

namespace MyReddit.Models
{
    public class PostDTO
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
    }
}

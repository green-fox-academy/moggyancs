using System.Linq;

namespace Anagram.Services
{
    public class AnagramWithLINQ : IsAnagram
    {
        public string Source { get; set; }
        public string Anagram { get; set; }

        public bool CheckIfAnagram(string source, string anagram)
        {
            Source = source;
            Anagram = anagram;

            var charsS = Source.ToLower().ToArray();
            var charsA = Anagram.ToLower().ToArray();
            return charsS.OrderBy(c => c).SequenceEqual(charsA.OrderBy(c => c));
        }
    }
}

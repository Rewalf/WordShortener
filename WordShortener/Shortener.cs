using System.Linq;
using System.Text.RegularExpressions;

namespace WordShortener
{
    public static class Shortener
    {
        private static readonly Regex regex;
        static Shortener()
        {
            regex = new Regex("([A-Za-z]{2,})");
        }
        public static string ShortenParagraph(this string paragraph)
        {
            var replaced = regex.Replace(paragraph, new MatchEvaluator(m => m.Value.ShortenWord()));
            return replaced;
        }
        public static string ShortenWord(this string word)
        {
            if (regex.IsMatch(word))
            {
                var grouped = word[1..^1].GroupBy(x => x);
                return $"{word[0]}{grouped.Count()}{word[^1]}";
            }
            return word;
        }

    }
}

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
            return regex.IsMatch(word) ? $"{word[0]}{word.Length-2}{word[^1]}" : word;
        }

    }
}

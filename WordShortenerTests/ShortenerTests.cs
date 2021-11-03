using NUnit.Framework;
using WordShortener;

namespace WordShortenerTests
{
    public class ShortenerTests
    {
        [Test]
        [TestCase("Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "L3m i3m d3r s1t a2t, c9r a8g e2t.")]
        [TestCase("Sed in nulla quis est ullamcorper aliquet.\n\t\r", "S1d i0n n3a q2s e1t u9r a5t.\n\t\r")]
        [TestCase("Praesent non fringilla lacus, tempus sodales erat.", "P6t n1n f7a l3s, t4s s5s e2t.")]
        [TestCase("Words0With0Numbers", "W3s0W2h0N5s")]
        public void TestParagraphShortener(string input, string expectedOutput)
        {
            Assert.AreEqual(input.ShortenParagraph(), expectedOutput);
        }
    }
}
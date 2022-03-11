using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Netizen.NGram.Test
{
    [TestClass]
    public class NGramSpliterTest
    {
        private NGramSpliter spliter;
        public NGramSpliterTest()
        {
            spliter = new NGramSpliter(3, 5);
        }

        [TestMethod]
        [DataRow("Hello World!")]
        [DataRow("aa")]
        [DataRow("≤‚ ‘ ˝æ›")]
        public void TestSplit(string text)
        {
            var r = spliter.Split(text);
            if (text.Length < spliter.MinSize)
            {
                Assert.AreEqual(r[0], text);
            }
            else if(text.Length < spliter.MaxSize)
            {
                Assert.IsTrue(r.Contains(text));
            }
            else
            {
                Assert.IsFalse(r.Contains(text));
            }
        }
    }
}
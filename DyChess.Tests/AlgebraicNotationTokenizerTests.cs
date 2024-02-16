namespace DyChess.Tests
{
    [TestClass]
    public class AlgebraicNotationTokenizerTests
    {
        private AlgebraicNotationTokenizer _tokenizer;
        public AlgebraicNotationTokenizerTests()
        {
            _tokenizer = new AlgebraicNotationTokenizer();
        }

        [TestMethod]
        public void Tokenizer_TokenPeonDestinationSet()
        {
            var token = _tokenizer.Tokenize("e5");
            Assert.AreEqual(4, token.Destination.x);
            Assert.AreEqual(4, token.Destination.y);
        }

        [TestMethod]
        public void Tokenizer_TokenPieceAndDestinationSet()
        {
            var token = _tokenizer.Tokenize("Be5");
            Assert.AreEqual(4, token.Destination.x);
            Assert.AreEqual(4, token.Destination.y);
            Assert.IsInstanceOfType(token.type, typeof(Bishop));
        }
    }
}
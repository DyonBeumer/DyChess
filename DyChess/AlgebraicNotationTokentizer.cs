using System.Text.RegularExpressions;

namespace DyChess
{
    public class AlgebraicNotationTokentizer
    {
        public AlgebraicDyChessToken Tokenize(string input)
        {
            if (input is null) 
            {
                throw new ArgumentNullException("input cannot be empty");
            }

            var output = new AlgebraicDyChessToken();
            var singleLetterSingleNumberMatcher = "([a-h][0-8])";

            var results = Regex.Matches(input, singleLetterSingleNumberMatcher);

            if(results.Count == 1) 
            {
                output.Destination = new Position(results[0].Value.Substring(0, 1), int.Parse(results[0].Value.Substring(1, 1)));
            }

            return output;
        }
    }
    public class AlgebraicDyChessToken
    {
        // ordering variables based on input order
        public IMoveable? type { get; set; }
        public Position? Origin { get; set; }
        public Position Destination { get; set; }


    }
}

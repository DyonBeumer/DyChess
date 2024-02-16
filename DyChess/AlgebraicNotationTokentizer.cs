using System.Text.RegularExpressions;

namespace DyChess
{
    public class AlgebraicNotationTokenizer
    {
        public AlgebraicDyChessToken Tokenize(string input)
        {
            if (input is null)
            {
                throw new ArgumentNullException("input cannot be empty");
            }

            var output = new AlgebraicDyChessToken();

            //Todo: convert to something not dumb unlike this
            if(input.Length <= 2)
            {
                matchPeonDestination(input, output);
            }

            if(input.Length == 3) 
            { 
                matchPieceDestination(input, output);
            }

            if(input.Length == 4)
            {
                matchPieceDestinationWhenAmbiguous(input, output);
            }

            return output;
        }

        private void matchPeonDestination(string input, AlgebraicDyChessToken output)
        {
            var singleLetterSingleNumberMatcher = "([a-h][0-8])";
            var matches = Regex.Matches(input, singleLetterSingleNumberMatcher);

            if (matches.Count == 1)
            {
                string letter = matches[0].Value.Substring(0, 1);
                int numbertoYInt = int.Parse(matches[0].Value.Substring(1, 1));
                output.Destination = new Position(letter, numbertoYInt);
            }
        }

        private void matchPieceDestination(string input, AlgebraicDyChessToken output)
        {
            var pieceSingleLetterSingleNumberMatcher = "([RNBQK][a-h][0-8])";
            var matches = Regex.Matches(input, pieceSingleLetterSingleNumberMatcher);

            if (matches.Count == 1)
            {
                output.type = convertStringToPieceInstance(matches[0].Value.Substring(0,1));
                string letter = matches[0].Value.Substring(1, 1);
                int numbertoYInt = int.Parse(matches[0].Value.Substring(2, 1));
                output.Destination = new Position(letter, numbertoYInt);
            }
        }

        private void matchPieceDestinationWhenAmbiguous(string input, AlgebraicDyChessToken output)
        {
            var ambiguousMatcher = "([RNBQK][a-h][a-h][0-8])|([RNBQK][0-8][a-h][0-8])";
            var matches = Regex.Matches(input, ambiguousMatcher);

            if (matches.Count == 1)
            {
                //output.type = convertStringToPieceInstance(matches[0].Value.Substring(0, 1));
                //string letter = matches[0].Value.Substring(1, 1);
                //int numbertoYInt = int.Parse(matches[0].Value.Substring(2, 1));
                //output.Destination = new Position(letter, numbertoYInt);
            }
        }

        private IMoveable? convertStringToPieceInstance(string piece)
        {
            switch (piece)
            {
                case "R": return new Rook();
                case "N": return new Knight();
                case "B": return new Bishop();
                case "Q": return new Queen();
                case "K": return new King();
                default: return null;
            }
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

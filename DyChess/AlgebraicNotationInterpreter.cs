// Code assumes english localisation
// Todo: to readme.md
using DyChess;

//letters K for king, Q for queen, R for rook, B for bishop, and N for knight None for pawn 
public class AlgebraicNotationInterpreter
{
    private AlgebraicNotationTokentizer _tokenizer;
    public AlgebraicNotationInterpreter()
    {
        _tokenizer = new AlgebraicNotationTokentizer();
    }
    public (Position, Position) Interprete(context context)
    {
        var tokens = _tokenizer.Tokenize(context.Input);
        return (null,null);
        // if ("k", "q", "r", "b", "n")
    }
}
public class context
{
    public Player Player { get; set; }
    public string Input { get; set; }
    public Board CurrentBoard { get; set; }
}
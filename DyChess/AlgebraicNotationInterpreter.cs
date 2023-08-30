// Code assumes english localisation
// Todo: to readme.md
using DyChess;

//letters K for king, Q for queen, R for rook, B for bishop, and N for knight None for pawn 
public static class AlgebraicNotationInterpreter
{
    public static (Position, Position) Interprete(context context)
    {

        return new (null, null);
    }
}

public class context
{
    public Player Player { get; set; }
    public string Input { get; set; }
    public Board currentBoard { get; set; }
}
// Code assumes english localisation
// Todo: to readme.md
using DyChess;

public class Game
{
    public Board Board { get; set; }
    public string WhitePlayerName { get; set; } = null!;
    public string BlackPlayerName { get; set; } = null!;
    public string Result { get; set; } = null!;

    public Player ActivePlayer = Player.White;

    public List<GameAction> actions = new List<GameAction>();
    public Game()
    {
        Board = new Board();
    }

    public void Action(Position From, Position To)
    {
        var unit = Board.Positions[From.x, From.y].Item2;
        if (unit is null)
        {
            throw new ArgumentException($"No unit found in position {From.x}, {From.y}");
        }

        // Todo: Notation - When a piece makes a capture, an "x" is inserted immediately before the destination square.
        // For example, Bxe5 (bishop captures the piece on e5).
        // When a pawn makes a capture, the file from which the pawn departed is used to identify the pawn.
        // For example, exd5 (pawn on the e-file captures the piece on d5).
        //var capturesPiece = Board.Positions[To.x, To.y].Item2 is not null;
    }

    public void Resign(Player initiator)
    {
        if (initiator == Player.White)
        {
            Result = "Black wins!";
        }
        else
        {
            Result = "White wins!";
        }
    }
}

public class GameAction
{
}
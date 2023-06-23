// Code assumes english localisation
// Todo: to readme.md
using DyChess;

var Game = new Game 
{ 
    WhitePlayerName = "Dyon",
    BlackPlayerName = "Emma"
};

Game.Board.Print();
public class Game
{
    public Board Board { get; set; }
    public string WhitePlayerName { get; set; } = null!;
    public string BlackPlayerName { get; set; } = null!;
    public string Result { get; set; } = null!;

    public Player ActivePlayer = Player.White;

    public Game()
    {
        Board = new Board();
    }

    public void Action(Position From, Position To)
    {
        
    }
}
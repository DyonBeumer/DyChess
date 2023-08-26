// Code assumes english localisation
// Todo: to readme.md

var Game = new Game 
{ 
    WhitePlayerName = "Dyon",
    BlackPlayerName = "Emma"
};

Game.Board.Print();

while(Game.Result == null)
{
    Console.WriteLine($"starting game: first turn {Game.ActivePlayer.ToString()}");
    var input = Console.ReadLine();
    //AlgebraicNotationInterpreter.Interprete(input, )
}
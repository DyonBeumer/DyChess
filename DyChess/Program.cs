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
    Console.WriteLine($"starting game: white pieces played by {Game.WhitePlayerName}, Black pieces by {Game.BlackPlayerName}");
    string? input = Console.ReadLine();
    Console.WriteLine(input);
    if(input is not null)
    {
        var action = AlgebraicNotationInterpreter.Interprete(new context
        {
            Player = Game.ActivePlayer,
            Input = input,
            currentBoard = Game.Board
        });

        Game.Action(action.Item1, action.Item2);
    }
}
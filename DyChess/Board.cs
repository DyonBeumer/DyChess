namespace DyChess
{
    public class Board
    {
        public int[,] Positions { get; set; } = null!;
        public record Unit(UnitType Type, Player Player, Position Position);
        public Unit[] units { get; set; } = null!;
        public Board()
        {
            Setup();
        }

        private void Setup()
        {


            var units = new List<Unit>();
            for (int i = 0; i<7; i++)
            {
                units.Add(new Unit(UnitType.Peon, Player.Black, new Position(i, 1)));
                units.Add(new Unit(UnitType.Peon, Player.White, new Position(i, 6)));
            }

            units.Add(new Unit(UnitType.Rook, Player.Black, new Position(0, 0)));
            units.Add(new Unit(UnitType.Rook, Player.Black, new Position(7, 0)));
            units.Add(new Unit(UnitType.Rook, Player.White, new Position(0, 7)));
            units.Add(new Unit(UnitType.Rook, Player.White, new Position(7, 7)));
            units.Add(new Unit(UnitType.Knight, Player.Black, new Position(1, 0)));
            units.Add(new Unit(UnitType.Knight, Player.Black, new Position(6, 0)));            
            units.Add(new Unit(UnitType.Knight, Player.White, new Position(1, 7)));
            units.Add(new Unit(UnitType.Knight, Player.White, new Position(6, 7)));            
            units.Add(new Unit(UnitType.Bishop, Player.Black, new Position(2, 0)));
            units.Add(new Unit(UnitType.Bishop, Player.Black, new Position(5, 0)));            
            units.Add(new Unit(UnitType.Bishop, Player.White, new Position(2, 7)));
            units.Add(new Unit(UnitType.Bishop, Player.White, new Position(5, 7)));
            units.Add(new Unit(UnitType.Queen, Player.White, new Position(3, 7)));
            units.Add(new Unit(UnitType.Queen, Player.Black, new Position(3, 0)));
            units.Add(new Unit(UnitType.King, Player.White, new Position(4, 7)));
            units.Add(new Unit(UnitType.King, Player.Black, new Position(4, 0)));

            this.units = units.ToArray();
        }

        public void Print()
        {
            //foreach (var unit in this.units)
            //{
            //    Console.WriteLine($"Unit: {unit.Type} Position: x={unit.Position.x}y={unit.Position.y} Player: {unit.Player}");
            //}


            if (units is null)
            {
                Console.WriteLine("no units - initial setup did not run or failed");
            }
            else
            {
                Console.WriteLine("Format:");
                Console.WriteLine("<Unique Position Identifier>");
                Console.WriteLine("<Color>:<Piece>"); // TODO: Add DestinationEvent Data
                Console.WriteLine("Pawn = P, Rook = R, Knight = N, Bishop = B, Queen = Q, King = K, * = empty");


            }
        }

    }

}

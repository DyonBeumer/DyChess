namespace DyChess
{
    public class Board
    {
        public record Unit(IMoveable Type, Player Player);
        public Unit[] units { get; set; } = null!;
        public Board()
        {
            InitPositions();
            Setup();
        }
        public (string, Unit?)[,] Positions { get; set; } = new (string, Unit?)[8,8];

        private void InitPositions()
        {
            //todo
            var horizontals = new Dictionary<int, string> {
                    { 0, "a"},
                    { 1, "b"},
                    { 2, "c"},
                    { 3, "d"},
                    { 4, "e"},
                    { 5, "f"},
                    { 6, "g"},
                    { 7, "h"}
                };

            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j <= 8; j++) // verticals
                {
                    var id = $"{horizontals[i] + "" + j}";
                    Console.WriteLine($"Initializing {id}", id);
                    Positions[i, j-1] = new (id, null);
                }
            }
        }

        private Unit? GetUnitFromPosition(string posid)
        {
            return null;
        }

        private void Setup()
        {

            var units = new List<Unit>();
            for (int i = 0; i<7; i++)
            {

                Positions[i, 1].Item2 = new Unit(new Pawn(), Player.Black); //a7 t/m h7
                Positions[i, 6].Item2 = new Unit(new Pawn(), Player.White);  //a2 t/m h2
            }

            Positions[0, 7].Item2 = new Unit(new Rook(), Player.Black); //a8

            units.Add(new Unit(new Rook(), Player.Black));      //h8
            units.Add(new Unit(new Rook(), Player.White));      //a1 
            units.Add(new Unit(new Rook(), Player.White));      //h1
            units.Add(new Unit(new Knight(), Player.Black));    //b8
            units.Add(new Unit(new Knight(), Player.Black));    //g8       
            units.Add(new Unit(new Knight(), Player.White));    //b1
            units.Add(new Unit(new Knight(), Player.White));    //g1           
            units.Add(new Unit(new Bishop(), Player.Black));    //c8
            units.Add(new Unit(new Bishop(), Player.Black));    //f8       
            units.Add(new Unit(new Bishop(), Player.White));    //c1
            units.Add(new Unit(new Bishop(), Player.White));    //f1
            units.Add(new Unit(new Queen(), Player.White));     //d1
            units.Add(new Unit(new Queen(), Player.Black));     //d8
            units.Add(new Unit(new King(), Player.White));      //e1
            units.Add(new Unit(new King(), Player.Black));      //e8

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

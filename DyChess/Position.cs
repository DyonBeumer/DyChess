namespace DyChess
{
    public class Position
    {
        public int x, y;

        //public Position(int x, int y)
        //{
        //    this.x = x;
        //    this.y = y-1;
        //}

        /// <summary>
        /// Constructor for a position on the board.
        /// Input is a unique chess position i.e. a1
        /// Converted it should be an 2d array position (starting at 0) i.e. 0,0
        /// </summary>
        /// <param name="file"></param>
        /// <param name="rank"></param>
        public Position(string file, int rank)
        {
            stringFileToInt(file);
            this.y = rank-1;
        }

        public void stringFileToInt(string intfile)
        {
            var files = new Dictionary<string, int> {
                    {"a", 0},
                    {"b", 1},
                    {"c", 2},
                    {"d", 3},
                    {"e", 4},
                    {"f", 5},
                    {"g", 6},
                    {"h", 7}
                };
            files.TryGetValue(intfile, out x);
        }
    }
}

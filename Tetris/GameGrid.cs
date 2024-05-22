
namespace Tetris
{
    public class GameGrid
    {
        private readonly int[,] grid;

        public int Rows { get; }
        public int Columns { get; }

        // With this we can use indexing directly on a GameGrid object
        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }
        /// <summary>
        /// The constructor can take any number of rows and columns. This allows
        /// for different game modes with unconventional grid size.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public GameGrid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            grid = new int[rows, columns];
        }
        /// <summary>
        /// Checks if the cell with the index given is inside the grid
        /// </summary>
        /// <param name="r">Row</param>
        /// <param name="c">Column</param>
        /// <returns></returns>
        public bool IsInside(int r, int c)
        {
            return r >= 0 && r < Rows && c >= 0 && c < Columns;
        }

        /// <summary>
        /// Checks if the cell with the index given is inside the grid and is empty
        /// </summary>
        /// <param name="r">Row</param>
        /// <param name="c">Column</param>
        /// <returns></returns>
        public bool IsEmpty(int r, int c)
        {
            return IsInside(r, c) && grid[r, c] == 0;
        }
        
        /// <summary>
        /// Checks if all cells in a row are full
        /// </summary>
        /// <param name="r">Row</param>
        /// <returns></returns>
        public bool IsRowFull(int r)
        {
            return Enumerable.Range(0, grid.GetLength(1))
                .All(c => grid[r, c] != 0);
        }
        
        /// <summary>
        /// Checks if all cells in a row are empty
        /// </summary>
        /// <param name="r">Row</param>
        /// <returns></returns>
        public bool IsRowEmpty(int r)
        {
            return Enumerable.Range(0, grid.GetLength(1))
                .All(c => grid[r, c] == 0);
        }
    }
}

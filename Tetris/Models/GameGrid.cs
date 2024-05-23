
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

        /// <summary>
        /// Changes all cells in a row to 0
        /// </summary>
        /// <param name="r">Row</param>
        private void ClearRow(int r)
        {
            for (int c = 0; c < Columns; c++)
            {
                grid[r, c] = 0;
            }
        }

        /// <summary>
        /// Moves all element of a given row down
        /// </summary>
        /// <param name="r">Row</param>
        /// <param name="numRows">Number of rows to be moved down</param>
        private void MoveRowDown(int r, int numRows)
        {
            for(int c = 0; c < Columns; c++)
            {
                grid[r + numRows, c] = grid[r, c];
                grid[r, c] = 0;
            }
        }

        /// <summary>
        /// Checks all rows from bottom to top, clears full rows and drops down the next ones
        /// </summary>
        /// <returns>Number of rows cleared</returns>
        public int ClearFullRows() 
        {
            int cleared = 0;

            for(int r = Rows - 1; r >= 0; r--) // Check all rows from bottom to top
            {
                if (IsRowFull(r)) // Check if the row is full. If it is, clear it and increase token
                {
                    ClearRow(r);
                    cleared++;
                } else if( cleared > 0 ) // Move rows down as many rows as token says
                {
                    MoveRowDown(r, cleared);
                }
            }

            return cleared;
        }
    }
}

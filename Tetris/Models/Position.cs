namespace Tetris.Models
{
    /// <summary>
    /// Simple class to hold the position of a cell
    /// </summary>
    public class Position
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}

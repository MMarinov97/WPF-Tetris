using System.Collections.Generic;

namespace Tetris.Models
{
    public abstract class Block
    {
        // Contains all the cells of the block in the different rotation states
        protected abstract Position[][] Tiles { get; }
        // Offset where the block spawns in the grid
        protected abstract Position StartOffset { get; }
        // ID to distinguish the blocks
        public abstract int Id { get; }

        private int rotationState;
        // Holds the current offset of the block. In constructor it is set to StartOffset
        private Position offset;

        public Block()
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        /// <summary>
        /// Iterates through the Positions in the current rotationState and returns them with the current offset
        /// </summary>
        /// <returns>Iterable set of the positions of the block cells</returns>
        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState]) 
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }
        /// <summary>
        /// Rotates the block Clock-Wise
        /// </summary>
        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }
        /// <summary>
        /// Rotates the block Counter Clock-Wise
        /// </summary>
        public void RotateCCW()
        {
            if(rotationState == 0)
                rotationState = Tiles.Length - 1;
            else
                rotationState--;
        }
        /// <summary>
        /// Moves a block
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }
        /// <summary>
        /// Resets the block to it's inital rotation and position
        /// </summary>
        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }
    }
}

namespace Tetris.Models
{
    /// <summary>
    /// Class that represents the O-Block with all posible rotations
    /// </summary>
    public class OBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            /* 44 Always stays the same when rotated
             * 44 so we only need one position
             */
            new Position[] { new(0, 0), new(0,1), new(1,0), new(0,0) }
        };

        public override int Id => 4;
        protected override Position StartOffset => new Position(0, 4);
        protected override Position[][] Tiles => tiles;
    }
}

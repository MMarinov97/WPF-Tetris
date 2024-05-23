namespace Tetris.Models
{
    /// <summary>
    /// Class that represents the T-Block with all posible rotations
    /// </summary>
    public class TBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            /*
             * X6X    X6X    XXX    X6X
             * 666 -> X66 -> 666 -> 66X
             * XXX    X6X    X6X    X6X
             */
            new Position[] { new(0,1), new(1,0), new(1,1), new(1,2) },
            new Position[] { new(0,1), new(1,1), new(1,2), new(2,1) },
            new Position[] { new(1,0), new(1,1), new(1,2), new(2,1) },
            new Position[] { new(0,1), new(1,0), new(1,1), new(2,1) }
        };
        public override int Id => 6;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}

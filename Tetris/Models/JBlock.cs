namespace Tetris.Models
{
    /// <summary>
    /// Class that represents the J-Block with all posible rotations
    /// </summary>
    public class JBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            /*
             * 2XX    X22    XXX    X2X
             * 222 -> X2X -> 222 -> X2X
             * XXX    X2X    XX2    22X
             */
            new Position[] { new(0,0), new(1,0), new(1,1), new(1,2)},
            new Position[] { new(0,1), new(0,2), new(1,1), new(2,1)},
            new Position[] { new(1,1), new(1,1), new(2,1), new(2,1)}
        };
        public override int Id => 2;
        protected override Position StartOffset => new Position(0,3);
        protected override Position[][] Tiles => tiles; 
    }
}

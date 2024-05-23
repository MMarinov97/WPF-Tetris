using System.Windows.Navigation;

namespace Tetris.Models
{
    /// <summary>
    /// Class that represents the I-Block with all posible rotations
    /// </summary>
    public class IBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            /* 
             * XXXX   XX1X    XXXX    X1XX
             * 1111-> XX1X -> XXXX -> X1XX
             * XXXX   XX1X    1111    X1XX
             * XXXX   XX1X    XXXX    X1XX
             */
            new Position[] { new (1,0), new (1,1), new (1,2), new(1,3)},
            new Position[] { new (0,2), new (1,2), new (2,2), new(3,2)},
            new Position[] { new (2,0), new (2,1), new (2,2), new(2,3)},
            new Position[] { new (0,1), new (1,1), new (2,1), new(3,1)}
        };

        public override int Id => 1;
        protected override Position StartOffset => new Position(-1, 3);
        protected override Position[][] Tiles => tiles;
    }
}

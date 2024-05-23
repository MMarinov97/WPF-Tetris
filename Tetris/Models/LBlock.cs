namespace Tetris.Models
{
    /// <summary>
    /// Class that represents the L-Block with all posibles rotations
    /// </summary>
    public class LBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            /*
             * XX3    X3X    XXX    33X
             * 333 -> X3X -> 333 -> X3X
             * XXX    333    3XX    X3X
             */
            new Position[] {new(0,2), new(1,0), new(1,1), new(1,2)},
            new Position[] {new(0,1), new(1,1), new(2,1), new(2,2)},
            new Position[] {new(1,0), new(1,1), new(1,2), new(2,0)},
            new Position[] {new(0,0), new(0,1), new(1,1), new(2,1)}
        };
        public override int Id => 3;
        protected override Position StartOffset =>new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}

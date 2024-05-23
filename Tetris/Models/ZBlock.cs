namespace Tetris.Models
{
    public class ZBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            /*
             * 77X    XX7    XXX    X7X
             * X77 -> X77 -> 77X -> 77X
             * XXX    X7X    X77    7XX
             */
            new Position[] { new(0, 0), new(0, 1), new(1, 1), new(1, 2) },
            new Position[] { new(0, 2), new(1, 1), new(1, 2), new(2, 1) },
            new Position[] { new(1, 0), new(1, 1), new(2, 1), new(2, 2) },
            new Position[] { new(0, 1), new(1, 0), new(1, 1), new(2, 0) }
        };
        public override int Id => 7;
        protected override Position StartOffset => new Position(0, 3);
        protected override Position[][] Tiles => tiles;
    }
}

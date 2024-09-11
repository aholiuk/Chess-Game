
namespace Model
{
    public class Knight : Figure
    {
        public Knight(Position pos, Color color) : base(pos, color) { }

        public override string GetIcon()
        {
            if (color == Color.White)
            {
                return "♘";
            }
            else
            {
                return "♞";
            }

        }

        public override List<Position> GetPossibleMoves(List<Figure> figures)
        {
            var possibleMoves = new List<Position>
            {
                new Position(pos.x - 1, pos.y + 2),
                new Position(pos.x + 1, pos.y + 2),
                new Position(pos.x - 2, pos.y + 1),
                new Position(pos.x + 2, pos.y + 1),
                new Position(pos.x - 2, pos.y - 1),
                new Position(pos.x + 2, pos.y - 1),
                new Position(pos.x - 1, pos.y - 2),
                new Position(pos.x + 1, pos.y - 2)
            };

            FigureHelper.RemoveMovesOutOfBoard(possibleMoves);
            FigureHelper.RemoveMovesTakenByOwnFigure(possibleMoves, figures, color);

            return possibleMoves;
        }
    }
}

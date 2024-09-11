
namespace Model
{
    public class Rook : Figure
    {
        public Rook(Position pos, Color color) : base(pos, color) {}

        public override string GetIcon()
        {
            if (color == Color.White)
            {
                return "♖";
            }
            else
            {
                return "♜";
            }

        }

        public override List<Position> GetPossibleMoves(List<Figure> figures)
        {
            var possibleMoves = new List<Position> {};

            for (int i = -7; i <= 7; i++)
            {
                if (i == 0)
                    continue;

                possibleMoves.Add(new Position(pos.x, pos.y + i));
            }
            for (int i = -7; i <= 7; i++)
            {
                if (i == 0)
                    continue;

                possibleMoves.Add(new Position(pos.x + i, pos.y));
            }
            FigureHelper.RemoveMovesOutOfBoard(possibleMoves);
            FigureHelper.RemoveMovesTakenByOwnFigure(possibleMoves, figures, color);

            return possibleMoves;
        }
    }
}


namespace Model
{
    public class Bishop : Figure
    {
        public Bishop(Position pos, Color color) : base(pos, color){}

        public override string GetIcon()
        {
            return "♝";

        }

        public override List<Position> GetPossibleMoves(List<Figure> figures)
        {
            var possibleMoves = new List<Position> {};
            for (int i = -7; i <= 7; i++)
            {
                if (i == 0)
                    continue;

                possibleMoves.Add(new Position(pos.x - i, pos.y - i));
                possibleMoves.Add(new Position(pos.x + i, pos.y + i));
                possibleMoves.Add(new Position(pos.x - i, pos.y + i));
                possibleMoves.Add(new Position(pos.x + i, pos.y - i));
            }

            FigureHelper.RemoveMovesOutOfBoard(possibleMoves);
            FigureHelper.RemoveMovesTakenByOwnFigure(possibleMoves, figures, color);

            return possibleMoves;
        }
    }
}

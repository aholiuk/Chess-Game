
namespace Model
{
    public class Pawn : Figure
    {
        public Pawn(Position pos, Color color) : base(pos, color){}

        public override string GetIcon()
        {
            if (color == Color.White)
            {
                return "♙";
            }
            else
            {
                return "♟";
            }

        }

        public override List<Position> GetPossibleMoves(List<Figure> figures)
        {
            var possibleMoves = new List<Position>();

            if (color == Color.White)
            {
                possibleMoves.Add(new Position(this.pos.x, this.pos.y + 1));
                if (pos.y == 2)
                {
                    possibleMoves.Add(new Position(this.pos.x, this.pos.y + 2));
                }
            } 
            else
            {
                possibleMoves.Add(new Position(this.pos.x, this.pos.y - 1));
                if (pos.y == 7)
                {
                    possibleMoves.Add(new Position(this.pos.x, this.pos.y - 2));
                }
            }

            FigureHelper.RemoveMovesOutOfBoard(possibleMoves);
            FigureHelper.RemoveMovesTakenByOwnFigure(possibleMoves, figures, color);

            return possibleMoves;
        }
    }
}

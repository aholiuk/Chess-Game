namespace Model
{
    public abstract class Figure
    {
        public Position pos;
        public Color color;

        public Figure(Position pos, Color color)
        {
            this.pos = pos;
            this.color = color;
        }

        public void MoveTo(Position newPos)
        {
            this.pos = newPos;
        }

        public abstract string GetIcon();

        public abstract List<Position> GetPossibleMoves(List<Figure> figures);
    }
}

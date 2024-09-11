namespace Model
{
    public static class FigureHelper
    {
        public static Figure GetFigureAt(List<Figure> figures, int x, int y)
        {
            foreach (Figure f in figures)
            {
                if (f.pos.x == x && f.pos.y == y)
                {
                    return f;
                }
            }

            return null;
        }

        public static int LetterToPos(char letter)
        {
            switch (letter)
            {
                case 'a':
                    return 1;

                case 'b':
                    return 2;

                case 'c':
                    return 3;

                case 'd':
                    return 4;

                case 'e':
                    return 5;

                case 'f':
                    return 6;

                case 'g':
                    return 7;

                case 'h':
                    return 8;

                default:
                    throw new ArgumentOutOfRangeException(nameof(letter));
            }
        }

        internal static void RemoveMovesOutOfBoard(List<Position> possibleMoves)
        {
            for (int i = possibleMoves.Count - 1; i >= 0; i--)
            {
                Position move = possibleMoves[i];
                if (move.x > 8 || move.x < 1 || move.y > 8 || move.y < 1)
                {
                    possibleMoves.Remove(move);
                }
            }
        }

        internal static void RemoveMovesTakenByOwnFigure(List<Position> possibleMoves, List<Figure> figures, Color currentFigureColor)
        {
            for (int i = possibleMoves.Count - 1; i >= 0; i--)
            {
                Position move = possibleMoves[i];

                var figure = GetFigureAt(figures, move.x, move.y);
                if (figure != null && figure.color == currentFigureColor)
                {
                    possibleMoves.Remove(move);
                }
            }
        }
    }
}

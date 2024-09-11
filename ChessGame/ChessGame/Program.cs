using Model;

namespace ChessGame
{
    internal class Program
    {
        

        public static void Main(string[] args)
        {
            var figures = BoardBuilder.Build();
            Painter.Draw(figures, new List<Position>());


            while (true)
            {
                Console.SetCursorPosition(1, 12);

                Console.WriteLine("Enter the position of a figure: ");

                string pos = Console.ReadLine();
                var x = FigureHelper.LetterToPos(pos[0]);
                var y = Convert.ToInt32(pos[1].ToString());
                var figure = FigureHelper.GetFigureAt(figures, x, y);

                var possibleMoves = figure.GetPossibleMoves(figures);
                Painter.Draw(figures, possibleMoves);
                Console.SetCursorPosition(1, 13);

                Console.WriteLine("\nEnter wherever is your move should be: ");

                string move = Console.ReadLine();
                x = FigureHelper.LetterToPos(move[0]);
                y = Convert.ToInt32(move[1].ToString());
                figure.MoveTo(new Position(x, y));

                Console.Clear();
                Painter.Draw(figures, possibleMoves);
            }
        }
    }
}

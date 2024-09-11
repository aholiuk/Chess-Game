using Model;
using System.Drawing;
using System.Text;

namespace ChessGame
{
    internal static class Painter
    {
        internal static void Draw(List<Figure> figures,  List<Position> possibleMoves)
         {
            Console.OutputEncoding = Encoding.Unicode;
            bool isChangedColor = true;

            for (int y = 1; y <= 8; y++)
            {

                for (int x = 1; x <= 8; x++)
                {
                    Console.SetCursorPosition(x * 2, 10 - y);

                    if(possibleMoves.Any(l => l.x == x && l.y == y))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("  ");
                        isChangedColor = !isChangedColor;
                    }
                    else if (!isChangedColor)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("  ");
                        isChangedColor = true;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("  ");
                        isChangedColor = false;
                    }
                    DrawFigure(figures, x, y);
                }
                isChangedColor = !isChangedColor;
            }

            Console.ResetColor();
        }

        private static void DrawFigure(List<Figure> figures, int x, int y)
        {
            var figure = FigureHelper.GetFigureAt(figures, x, y);

            if (figure != null) 
            {
                Console.SetCursorPosition(x * 2, 10 - y);
                Console.Write(figure.GetIcon());
            }
        }
    }
}

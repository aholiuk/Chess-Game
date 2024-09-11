using Model;

namespace ChessGame
{
    internal class BoardBuilder
    {
        internal static List<Figure> Build()
        {
            var figures = new List<Figure>
            {
                new Pawn(Constants.A2, Color.White),
                new Pawn(Constants.B2, Color.White),
                new Pawn(Constants.C2, Color.White),
                new Pawn(Constants.D2, Color.White),
                new Pawn(Constants.E2, Color.White),
                new Pawn(Constants.F2, Color.White),
                new Pawn(Constants.G2, Color.White),
                new Pawn(Constants.H2, Color.White),
                new Rook(Constants.A1, Color.White),
                new Knight(Constants.B1, Color.White),
                new Bishop(Constants.C1, Color.White),
                new Queen(Constants.D1, Color.White),
                new King(Constants.E1, Color.White),
                new Bishop(Constants.F1, Color.White),
                new Knight(Constants.G1, Color.White),
                new Rook(Constants.H1, Color.White),
             
                new Pawn(Constants.H7, Color.Black),
                new Pawn(Constants.G7, Color.Black),
                new Pawn(Constants.F7, Color.Black),
                new Pawn(Constants.E7, Color.Black),
                new Pawn(Constants.D7, Color.Black),
                new Pawn(Constants.C7, Color.Black),
                new Pawn(Constants.B7, Color.Black),
                new Pawn(Constants.A7, Color.Black),
                new Rook(Constants.H8, Color.Black),
                new Knight(Constants.G8, Color.Black),
                new Bishop(Constants.F8, Color.Black),
                new Queen(Constants.D8, Color.Black),
                new King(Constants.E8, Color.Black),
                new Bishop(Constants.C8, Color.Black),
                new Knight(Constants.B8, Color.Black),
                new Rook(Constants.A8, Color.Black)
            };

            return figures;
        }
    }
}
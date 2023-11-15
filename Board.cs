public class Board {
    public Space[,] Spaces;
    public const int boardSize = 8;
    private static string FilePath = Path.Combine(Directory.GetCurrentDirectory(),
                                                             "currentBoard.txt");

    public Board() {
        bool isBlack = true;
        Space[,] spaces = new Space[boardSize, boardSize];
        for(int i = 0; i < boardSize; i++) {
            isBlack = !isBlack;
            for(int j = 0; j < boardSize; j++) {
                spaces[i,j] = new Space(isBlack, new int[2] {i, j});
                isBlack = !isBlack;
            }
        }
        this.Spaces = spaces;
    }
    public Space getSpaceAt(int[] coordinate) {
         return this.Spaces[coordinate[0],coordinate[1]];
    }
    public void FillBoard() {
        FillPawns();
        FillRooks();
        FillKnights();
        FillBishops();
        FillQueens();
        FillKingss();
        DrawBoard();
    }

    private void FillPawns() {
        for(int i = 0; i < boardSize; i++) {
            Space currTopSpace = this.Spaces[i,1];
            currTopSpace.OcupiedBy = new Pawn(true);
            if(currTopSpace.IsBlack) {
                currTopSpace.Art = AsciiArt.GeneratePawnBlackOnBlack();
            }
            else {
                currTopSpace.Art = AsciiArt.GeneratePawnBlackOnWhite();
            }

            Space currBotSpace = this.Spaces[i,6];
            currBotSpace.OcupiedBy = new Pawn(false);
            if(currBotSpace.IsBlack) {
                currBotSpace.Art = AsciiArt.GeneratePawnWhiteOnBlack();
            }
            else {
                currBotSpace.Art = AsciiArt.GeneratePawnWhiteOnWhite();
            }
        }
    }

    private void FillRooks() {
        this.Spaces[0,0].OcupiedBy = new Rook(true);
        this.Spaces[7,0].OcupiedBy = new Rook(true);

        this.Spaces[0,7].OcupiedBy = new Rook(false);
        this.Spaces[7,7].OcupiedBy = new Rook(false);
    }

    private void FillKnights() {
        this.Spaces[1,0].OcupiedBy = new Knight(true);
        this.Spaces[6,0].OcupiedBy = new Knight(true);

        this.Spaces[1,7].OcupiedBy = new Knight(false);
        this.Spaces[6,7].OcupiedBy = new Knight(false);
    }

    private void FillBishops() {
        this.Spaces[2,0].OcupiedBy = new Bishop(true);
        this.Spaces[5,0].OcupiedBy = new Bishop(true);

        this.Spaces[2,7].OcupiedBy = new Bishop(false);
        this.Spaces[5,7].OcupiedBy = new Bishop(false);
    }

    private void FillQueens() {
        this.Spaces[3,0].OcupiedBy = new Queen(true);
        this.Spaces[3,7].OcupiedBy = new Queen(false);
    }

    private void FillKingss() {
        this.Spaces[4,0].OcupiedBy = new King(true);
        this.Spaces[4,7].OcupiedBy = new King(false);
    }


    public void DrawBoard() {
        UpdateArts();

        using StreamWriter currentBoard = new StreamWriter(FilePath);
        for(int j = 0; j < 8; j++) {
            for(int y = 0; y < 6; y++) {
                for(int i = 0; i < 8; i++) {
                    for(int x = 0; x < 14; x++) {
                        currentBoard.Write(this.Spaces[i,j].Art[x,y]);
                    }
                }
            currentBoard.Write("\n");
            }
        }
    }

    private void UpdateArts() {
        foreach(Space currSpace in this.Spaces) {
           currSpace.Art = AsciiArt.GenerateArt(currSpace.OcupiedBy, currSpace);
        }
    }
    public bool ExecuteMove(int[] origin, int[] destination) {

        Space originSpace = getSpaceAt(origin);
        Space destinationSpace = getSpaceAt(destination);
        if(Piece.ValidMove(this, originSpace, destinationSpace)) {
            destinationSpace.OcupiedBy = originSpace.OcupiedBy;
            originSpace.OcupiedBy = null;
            return true;
        }
        Console.WriteLine("Move is invalid");
        return false;
    }
}

public class Space {
    public Piece? OcupiedBy {get;set;}
    public bool IsBlack {get;set;}
    public char[,] Art;
    public int[] Location;

    public Space(bool isBlack, int[] location) {
        this.Location = location;
        this.IsBlack = isBlack;
        if(isBlack) {
            Art = AsciiArt.GenerateEmptyBlack();
        }
        else {
            Art = AsciiArt.GenerateEmptyWhite();
        }
    }
}

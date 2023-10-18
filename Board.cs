public class Board {
    public Space[,] Spaces;
    private static string FilePath = Path.Combine(Directory.GetCurrentDirectory(),
                                                             "currentBoard.txt");

    public Board() {
        bool isBlack = true;
        Space[,] spaces = new Space[8, 8];
        for(int i = 0; i < 8; i++) {
            isBlack = !isBlack;
            for(int j = 0; j < 8; j++) {
                spaces[i,j] = new Space(isBlack);
                isBlack = !isBlack;
            }
        }
        this.Spaces = spaces;
    }

    public void DrawBoard() {
        using StreamWriter currentBoard = new StreamWriter(FilePath);
        for(int j = 0; j < 8; j++) {
            for(int y = 0; y < 5; y++) {
                for(int i = 0; i < 8; i++) {
                    for(int x = 0; x < 10; x++) {
                        currentBoard.Write(this.Spaces[i,j].Art[x,y]);
                    }
                }
            currentBoard.Write("\n");
            }
        }
    }
}

public class Space {
    public Piece? OcupiedBy {get;set;}
    public bool IsBlack {get;set;}
    public char[,] Art;
    public int[,] Location;

    public Space(bool IsBlack) {
        this.IsBlack = IsBlack;
        if(IsBlack) {
            Art = AsciiArt.GenerateEmptyBlack();
        }
        else {
            Art = AsciiArt.GenerateEmptyWhite();
        }
    }
}

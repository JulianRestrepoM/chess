public static class AsciiArt {

    public static char[,] GenerateEmptyBlack() {
         char[,] emptyBlack =   {
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return emptyBlack;
    }
    

    public static char[,] GenerateEmptyWhite() {
        char[,] emptyWhite =    {
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return emptyWhite;

    }

    public static char[,] GeneratePawnBlackOnBlack() {
        char[,] pawnBlackOnBlack =   {
                                    {'|','|','|','|','#','#'},
                                    {'\\','/','\\','/','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#',' ',' ','/'},
                                    {'#','#','#','(',')','_'},
                                    {'#','#','#',')','(','_'},
                                    {'#','#','#',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return pawnBlackOnBlack;
    }

    public static char[,] GeneratePawnWhiteOnBlack() {
        char[,] pawnWhiteOnBlack =   {
                                    {'|','|','#','#','#','#'},
                                    {' ','/','#','#','#','#'},
                                    {'/',' ','#','#','#','#'},
                                    {'\\',' ','#','#','#','#'},
                                    {' ','\\','#','#','#',' '},
                                    {'|','|','#',' ',' ','/'},
                                    {'#','#','#','(',')','_'},
                                    {'#','#','#',')','(','_'},
                                    {'#','#','#',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return pawnWhiteOnBlack;
    }

    public static char[,] GeneratePawnBlackOnWhite() {
        char[,] pawnBlackOnWhite =    {
                                    {'|','|','|','|',' ',' '},
                                    {'\\','/','\\','/',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ','/'},
                                    {' ',' ',' ','(',')','_'},
                                    {' ',' ',' ',')','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return pawnBlackOnWhite;
    }

    public static char[,] GeneratePawnWhiteOnWhite() {
        char[,] pawnWhiteOnWhite =    {
                                    {'|','|',' ',' ',' ',' '},
                                    {' ','/',' ',' ',' ',' '},
                                    {'/',' ',' ',' ',' ',' '},
                                    {'\\',' ',' ',' ',' ',' '},
                                    {' ','\\',' ',' ',' ',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {' ',' ',' ','(',')','_'},
                                    {' ',' ',' ',')','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return pawnWhiteOnWhite;
    }

    public static char[,] GenerateRookBlackOnBlack() {
        char[,] rookBlackOnBlack =   {
                                    {'|','|','|','|','#','#'},
                                    {'\\','/','\\','/','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#',' ',' ',' ','/'},
                                    {'#','#','I',')',')','_'},
                                    {'#','#','I','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return rookBlackOnBlack;
    }

    public static char[,] GenerateRookWhiteOnBlack() {
        char[,] rookBlackOnBlack =   {
                                    {'|','|','#','#','#','#'},
                                    {' ','/','#','#','#','#'},
                                    {'/',' ','#','#','#','#'},
                                    {'\\',' ','#','#','#','#'},
                                    {' ','\\','#','#','#',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {'#','#','I',')',')','_'},
                                    {'#','#','I','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return rookBlackOnBlack;
    }

    public static char[,] GenerateRookBlackOnWhite() {
        char[,] pawnBlackOnWhite =    {
                                    {'|','|','|','|',' ',' '},
                                    {'\\','/','\\','/',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ','/'},
                                    {' ',' ','I',')',')','_'},
                                    {' ',' ','I','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return pawnBlackOnWhite;
    }

    public static char[,] GenerateRookWhiteOnWhite() {
        char[,] pawnBlackOnWhite =    {
                                    {'|','|',' ',' ',' ',' '},
                                    {' ','/',' ',' ',' ',' '},
                                    {'/',' ',' ',' ',' ',' '},
                                    {'\\',' ',' ',' ',' ',' '},
                                    {' ','\\',' ',' ',' ',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {' ',' ','I',')',')','_'},
                                    {' ',' ','I','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return pawnBlackOnWhite;
    }

    public static char[,] GenerateKnightBlackOnBlack() {
        char[,] knightBlackOnBlack =   {
                                    {'|','|','|','|','#','#'},
                                    {'\\','/','\\','/','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#',' ','#','#'},
                                    {'#','#',' ','"','#',' '},
                                    {'#','#','_','-',' ','/'},
                                    {'#','#','\'','=',')','_'},
                                    {'#','#','\'','\\','(','_'},
                                    {'#','#',' ','~',' ','\\'},
                                    {'#','#','#',' ','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return knightBlackOnBlack;
    }

    public static char[,] GenerateKnightWhiteOnBlack() {
        char[,] knightBlackOnBlack =   {
                                    {'|','|','#','#','#','#'},
                                    {' ','/','#','#','#','#'},
                                    {'/',' ','#','#','#','#'},
                                    {'\\',' ','#',' ','#','#'},
                                    {' ','\\',' ','"','#',' '},
                                    {'|','|','_','-',' ','/'},
                                    {'#','#','\'','=',')','_'},
                                    {'#','#','\'','\\','(','_'},
                                    {'#','#',' ','~',' ','\\'},
                                    {'#','#','#',' ','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return knightBlackOnBlack;
    }

    public static char[,] GenerateKnightBlackOnWhite() {
        char[,] knightBlackOnWhite =    {
                                    {'|','|','|','|',' ',' '},
                                    {'\\','/','\\','/',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ','"',' ',' '},
                                    {' ',' ',' ','-',' ','/'},
                                    {' ',' ','_','=',')','_'},
                                    {' ',' ','\'','\\','(','_'},
                                    {' ',' ','\'','~',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return knightBlackOnWhite;
    }

    public static char[,] GenerateKnightWhiteOnWhite() {
        char[,] knightWhiteOnWhite =    {
                                    {'|','|',' ',' ',' ',' '},
                                    {' ','/',' ',' ',' ',' '},
                                    {'/',' ',' ',' ',' ',' '},
                                    {'\\',' ',' ',' ',' ',' '},
                                    {' ','\\',' ','"',' ',' '},
                                    {'|','|',' ','-',' ','/'},
                                    {' ',' ','_','=',')','_'},
                                    {' ',' ','\'','\\','(','_'},
                                    {' ',' ','\'','~',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return knightWhiteOnWhite;
    }

    public static char[,] GenerateBishopBlackOnBlack() {
        char[,] bishopBlackOnBlack =   {
                                    {'|','|','|','|','#','#'},
                                    {'\\','/','\\','/','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#',' ',' ',' ','/'},
                                    {'#','#','(',')',')','_'},
                                    {'#','#',')','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return bishopBlackOnBlack;
    }

    public static char[,] GenerateBishopWhiteOnBlack() {
        char[,] bishopWhiteOnBlack =   {
                                    {'|','|','#','#','#','#'},
                                    {' ','/','#','#','#','#'},
                                    {'/',' ','#','#','#','#'},
                                    {'\\',' ','#','#','#','#'},
                                    {' ','\\','#','#','#',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {'#','#','(',')',')','_'},
                                    {'#','#',')','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return bishopWhiteOnBlack;
    }

    public static char[,] GenerateBishopBlackOnWhite() {
        char[,] bishopBlackOnWhite =    {
                                    {'|','|','|','|',' ',' '},
                                    {'\\','/','\\','/',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ','/'},
                                    {' ',' ','(',')',')','_'},
                                    {' ',' ',')','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return bishopBlackOnWhite;
    }

    public static char[,] GenerateBishopWhiteOnWhite() {
        char[,] bishopWhiteOnWhite =    {
                                    {'|','|',' ',' ',' ',' '},
                                    {' ','/',' ',' ',' ',' '},
                                    {'/',' ',' ',' ',' ',' '},
                                    {'\\',' ',' ',' ',' ',' '},
                                    {' ','\\',' ',' ',' ',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {' ',' ','(',')',')','_'},
                                    {' ',' ',')','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return bishopWhiteOnWhite;
    }

    public static char[,] GenerateQueenBlackOnBlack() {
        char[,] queenBlackOnBlack =   {
                                    {'|','|','|','|','#','#'},
                                    {'\\','/','\\','/','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#',' '},
                                    {'#',' ',' ',' ',' ','/'},
                                    {'#','.','(',')',')','_'},
                                    {'#',' ',')','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return queenBlackOnBlack;
    }

    public static char[,] GenerateQueenWhiteOnBlack() {
        char[,] queenWhiteOnBlack =   {
                                    {'|','|','#','#','#','#'},
                                    {' ','/','#','#','#','#'},
                                    {'/',' ','#','#','#','#'},
                                    {'\\',' ','#','#','#','#'},
                                    {' ','\\','#','#','#',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {'#','.','(',')',')','_'},
                                    {'#',' ',')','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return queenWhiteOnBlack;
    }

    public static char[,] GenerateQueenBlackOnWhite() {
        char[,] queenBlackOnWhite =    {
                                    {'|','|','|','|',' ',' '},
                                    {'\\','/','\\','/',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ','/'},
                                    {' ','.','(',')',')','_'},
                                    {' ',' ',')','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return queenBlackOnWhite;
    }

    public static char[,] GenerateQueenWhiteOnWhite() {
        char[,] queenWhiteOnWhite =    {
                                    {'|','|',' ',' ',' ',' '},
                                    {' ','/',' ',' ',' ',' '},
                                    {'/',' ',' ',' ',' ',' '},
                                    {'\\',' ',' ',' ',' ',' '},
                                    {' ','\\',' ',' ',' ',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {' ','.','(',')',')','_'},
                                    {' ',' ',')','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return queenWhiteOnWhite;
    }

    public static char[,] GenerateKingBlackOnBlack() {
        char[,] kingBlackOnBlack =   {
                                    {'|','|','|','|','#','#'},
                                    {'\\','/','\\','/','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#',' '},
                                    {'#',' ',' ',' ',' ','/'},
                                    {'#','+','(',')',')','_'},
                                    {'#',' ',')','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return kingBlackOnBlack;
    }

    public static char[,] GenerateKingWhiteOnBlack() {
        char[,] kingWhiteOnBlack =   {
                                    {'|','|','#','#','#','#'},
                                    {' ','/','#','#','#','#'},
                                    {'/',' ','#','#','#','#'},
                                    {'\\',' ','#','#','#','#'},
                                    {' ','\\','#','#','#',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {'#','+','(',')',')','_'},
                                    {'#',' ',')','(','(','_'},
                                    {'#','#',' ',' ',' ','\\'},
                                    {'#','#','#','#','#',' '},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'},
                                    {'#','#','#','#','#','#'}
                                };
        return kingWhiteOnBlack;
    }

    public static char[,] GenerateKingBlackOnWhite() {
        char[,] kingBlackOnWhite =    {
                                    {'|','|','|','|',' ',' '},
                                    {'\\','/','\\','/',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ','/'},
                                    {' ','+','(',')',')','_'},
                                    {' ',' ',')','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return kingBlackOnWhite;
    }

    public static char[,] GenerateKingWhiteOnWhite() {
        char[,] kingWhiteOnWhite =    {
                                    {'|','|',' ',' ',' ',' '},
                                    {' ','/',' ',' ',' ',' '},
                                    {'/',' ',' ',' ',' ',' '},
                                    {'\\',' ',' ',' ',' ',' '},
                                    {' ','\\',' ',' ',' ',' '},
                                    {'|','|',' ',' ',' ','/'},
                                    {' ','+','(',')',')','_'},
                                    {' ',' ',')','(','(','_'},
                                    {' ',' ',' ',' ',' ','\\'},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '},
                                    {' ',' ',' ',' ',' ',' '}
                                };
        return kingWhiteOnWhite;
    }

    public static char[,] GenerateArt(Piece? piece, Space space) {
        if(space.IsBlack) {
                    switch(piece) {
                        case null:
                            return AsciiArt.GenerateEmptyBlack();
                        case Pawn:
                            if(piece.isBlack) {
                                return AsciiArt.GeneratePawnBlackOnBlack();
                            }
                            return AsciiArt.GeneratePawnWhiteOnBlack();
                        case Rook:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateRookBlackOnBlack();
                            }
                            return AsciiArt.GenerateRookWhiteOnBlack();
                        case Knight:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateKnightBlackOnBlack();
                            }
                            return AsciiArt.GenerateKnightWhiteOnBlack();
                        case Bishop:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateBishopBlackOnBlack();
                            }
                            return AsciiArt.GenerateBishopWhiteOnBlack();
                        case Queen:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateQueenBlackOnBlack();
                            }
                            return AsciiArt.GenerateQueenWhiteOnBlack();
                        case King:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateKingBlackOnBlack();
                            }
                            return AsciiArt.GenerateKingWhiteOnBlack();
                        default:
                        return null;

                    }   
        }
        else {
            switch(piece) {
                        case null:
                            return AsciiArt.GenerateEmptyWhite();
                        case Pawn:
                            if(piece.isBlack) {
                                return AsciiArt.GeneratePawnBlackOnWhite();
                            }
                            return AsciiArt.GeneratePawnWhiteOnWhite();
                        case Rook:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateRookBlackOnWhite();
                            }
                            return AsciiArt.GenerateRookWhiteOnWhite();
                        case Knight:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateKnightBlackOnWhite();
                            }
                            return AsciiArt.GenerateKnightWhiteOnWhite();
                        case Bishop:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateBishopBlackOnWhite();
                            }
                            return AsciiArt.GenerateBishopWhiteOnWhite();
                        case Queen:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateQueenBlackOnWhite();
                            }
                            return AsciiArt.GenerateQueenWhiteOnWhite();
                        case King:
                            if(piece.isBlack) {
                                return AsciiArt.GenerateKingBlackOnWhite();
                            }
                            return AsciiArt.GenerateKingWhiteOnWhite();
                        default:
                        return null;

                    }
        }

    }

}
public class Piece {
    public bool isBlack;

    public Piece(bool isBlack) {
        this.isBlack = isBlack;
    }
}

public class Pawn : Piece{
    public Pawn(bool isBlack) : base(isBlack) {}
}
public class Rook : Piece{
    public Rook(bool isBlack) : base(isBlack) {}
}
public class Knight : Piece{
    public Knight(bool isBlack) : base(isBlack) {}
}
public class Bishop : Piece{
    public Bishop(bool isBlack) : base(isBlack) {}
}
public class Queen : Piece{
    public Queen(bool isBlack) : base(isBlack) {}
}
public class King : Piece{
    public King(bool isBlack) : base(isBlack) {}
}
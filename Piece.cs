using System.Reflection.Metadata;

public class Piece {
    public bool isBlack;

    public Piece(bool isBlack) {
        this.isBlack = isBlack;
    }
    public static bool ValidMove(Board currBoard, Space origin, Space destination) {
        Piece? originPiece = origin.OcupiedBy;
        Piece? destinationPiece = destination.OcupiedBy;

        if(origin == destination) { // moving to the exact same space
            return false;
        }
        if(originPiece == null) { //moving empty space
            return false;
        }
        if(destinationPiece != null && originPiece.isBlack == destinationPiece.isBlack) { //lands on own piece
            return false;
        }
        
        foreach(Space currSpace in Utils.CalcTrajectory(currBoard, origin.Location, destination.Location)) {
            if(currSpace.OcupiedBy != null) {
                return false;
            }
        }
        return true;
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
Console.WriteLine("Welcome to Julians Epic Chess Game");

Board theBoard = new Board();
theBoard.FillBoard();

while(true) {
    Console.WriteLine("Give me something: int,int int,int");
    string? moveInput = Console.ReadLine();

    Console.WriteLine($"You said: {moveInput}");

    if(moveInput is null || !Inputs.InputValid(moveInput)) {
        Console.WriteLine("Please try again with the propper format");
        continue;
    }

    // var move = Inputs.ParseInput(moveInput);
    (int[] origin, int[] destination) = Inputs.ParseInput(moveInput);

    Console.WriteLine($"Move {origin[0]},{origin[1]} {destination[0]},{destination[1]}");
    
}
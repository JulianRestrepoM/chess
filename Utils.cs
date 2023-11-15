using System.Text.RegularExpressions;

public static class Utils {
    
    public static (int[], int[]) ParseInput(string input) {
        int[] origin = new int[2];
        int[] destination = new int[2];

        string regexPatter = @"\d";
        
        MatchCollection m = Regex.Matches(input, regexPatter, RegexOptions.Compiled);

        int i = 0;
        foreach(Match match in m) {
            if(i < 2) {
                origin[i%2] = Convert.ToInt32(match.Value) -1; //-1 to convert from 0-7 to 1-8  becuase human vs array count
            }
            else {
                destination[i%2] = Convert.ToInt32(match.Value) -1;
            }
            i++;
        }

        return (origin, destination);
    }

    public static bool InputValid(string? input) { //check if input is valid for the board size
        if(input is null) {
            return false;
        }
        string regexPattern = @"^[1-8],[1-8] [1-8],[1-8]$";

        Match m = Regex.Match(input, regexPattern, RegexOptions.Compiled);
        
        if(!m.Success) {
            Console.WriteLine("Invalid Input");
        }

        return m.Success;
    }

    public static List<int> GetInbetween(int start, int end) { //returns the numbers inbetween 2 numbers
        int step = (start > end) ? 1 : -1;

        List<int> result = new List<int>();
        for(int i = start + step; i != end; i+= step) {
            result.Add(i);
        }
        return result;
    }

    public  static List<Space> CalcTrajectory(Board currBoard, int[] origin, int[] destination) { //gets all the spaces in between a moves start and end
        List<Space> spaceList = new List<Space>();
        if(origin[0] == destination[0]) { //on the same row
           foreach(int i in Utils.GetInbetween(origin[1], destination[1])) {
                spaceList.Add(currBoard.Spaces[origin[0],i]);
                
           }
        }
        else if(origin[1] == destination[1]) { // on the same column
            foreach(int i in Utils.GetInbetween(origin[0], destination[0])) {
                spaceList.Add(currBoard.Spaces[i, origin[1]]);
                
           }
        }
        else { //diagonal
            List<int> xAxis = Utils.GetInbetween(origin[0], destination[0]);
            List<int> yAxis = Utils.GetInbetween(origin[1], destination[1]);

            for(int i = 0; i < xAxis.Count; i++) {
                spaceList.Add(currBoard.Spaces[xAxis[i], yAxis[i]]);
            }
        }
        return spaceList;
    }
}
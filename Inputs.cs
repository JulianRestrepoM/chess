using System.Text.RegularExpressions;

public class Inputs {
    
    public static (int[], int[]) ParseInput(string input) {

        // if(input is null || !InputValid(input)) {
        //     return null;
        // }

        int[] origin = new int[2];
        int[] destination = new int[2];

        string regexPatter = @"\d";
        
        MatchCollection m = Regex.Matches(input, regexPatter, RegexOptions.Compiled);

        int i = 0;
        foreach(Match match in m) {
            if(i < 2) {
                origin[i%2] = Convert.ToInt32(match.Value);
            }
            else {
                destination[i%2] = Convert.ToInt32(match.Value);
            }
            i++;
        }

        return (origin, destination);
    }

    public static bool InputValid(string? input) {
        if(input is null) {
            return false;
        }
        string regexPattern = @"^[0-7],[0-7] [0-7],[0-7]$";

        Match m = Regex.Match(input, regexPattern, RegexOptions.Compiled);
        
        if(!m.Success) {
            Console.WriteLine("Invalid Input");
        }

        return m.Success;
    }
}
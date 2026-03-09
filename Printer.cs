using System.Text;

namespace knightmoves;

public class Printer{
    
    public string Print(string message){
        return message ?? "no message";
    }

    public string Print(StringBuilder message){
        return message?.ToString();
    }
}
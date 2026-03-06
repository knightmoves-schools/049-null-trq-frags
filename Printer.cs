using System.Text;

namespace knightmoves;

public class Printer{
    
    public string Print(string message){
        return message;
    }

    public string Print(StringBuilder message){
        return message.ToString();
    }
}
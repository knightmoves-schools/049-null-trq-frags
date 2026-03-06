namespace Tests;

using System.Text;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Use_The_Null_Coalescing_Operator_In_The_Print_Method_That_Takes_A_String_To_Return_The_Message_If_It_Is_Not_Null_Or_The_String_No_Message_If_It_Is_Null(){
      Printer printer = new Printer();
      Assert.Equal("test", printer.Print("test"));
      Assert.Equal("no message", printer.Print((string) null));
    }

    [Fact]
    public void Should_Use_The_Null_Conditional_Operator_In_The_Print_Method_That_Takes_A_StringBuilder_To_Prevent_A_NullReferenceException_From_Being_Thrown_When_The_Message_Is_Null(){
      Printer printer = new Printer();
      var value = new StringBuilder("test");
      Assert.Equal("test", printer.Print(value));
      string expected = null;
      Assert.Equal(expected, printer.Print((StringBuilder) null));
    }
}
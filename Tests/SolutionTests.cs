using Xunit;

namespace test;

public class SolutionTests
{
    [Fact]
    public void CombineAndClass()
    {
        var input = "C;C;coffee machine";
        var expected = "CoffeeMachine";
        
        var actual = Solution.CamelCase(input);

        Assert.Equal(expected, actual);        
    }
 
   [Fact]
    public void SplitAndClass()
    {
        var input = "S;C;LargeSoftwareBook";
        var expected = "large software book";
        
        var actual = Solution.CamelCase(input);

        Assert.Equal(expected, actual);
        
    }
 
    [Fact]
    public void SplitAndVariable()
    {
        var input = "S;V;pictureFrame";
        var expected = "picture frame";
        
        var actual = Solution.CamelCase(input);

        Assert.Equal(expected, actual);
        
    }  

    [Fact]
    public void SplitAndMethod()
    {
        var input = "S;M;plasticCup()";
        var expected = "plastic cup";
        
        var actual = Solution.CamelCase(input);

        Assert.Equal(expected, actual);
        
    }

    [Fact]
     public void CombineAndMethod()
    {
        var input = "C;M;white sheet of paper";
        var expected = "whiteSheetOfPaper()";
        
        var actual = Solution.CamelCase(input);

        Assert.Equal(expected, actual);        
    }

    [Fact]
     public void CombineAndVariable()
    {
        var input = "C;V;mobile phone";
        var expected = "mobilePhone";
        
        var actual = Solution.CamelCase(input);

        Assert.Equal(expected, actual);        
    } 

   
}
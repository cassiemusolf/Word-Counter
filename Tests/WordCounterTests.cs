using Xunit;
using WordCounterApp.Objects;

namespace WordCounterApp.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void CountRepeats_ReturnSingleChar_Char()
    {
      //Arrange
      string oneChar = "a";
      RepeatCounter testRepeatCounter = new RepeatCounter(oneChar);
      //Act
      string result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal("a", result);
    }
    [Fact]
    public void CountRepeats_ReturnUserWord_Word()
    {
      //Arrange
      string userWord = "dog";
      RepeatCounter testRepeatCounter = new RepeatCounter(userWord);
      //Act
      string result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal("dog", result);
    }
  }
}

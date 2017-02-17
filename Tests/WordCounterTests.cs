using Xunit;
using WordCounterApp.Objects;

namespace WordCounterApp.Objects
{
  public class RepeatCounterTest
  {
//     // [Fact]
//     // public void CountRepeats_ReturnSingleChar_Char()
//     // {
//     //   //Arrange
//     //   string oneChar = "a";
//     //   RepeatCounter testRepeatCounter = new RepeatCounter(oneChar);
//     //   //Act
//     //   string result = testRepeatCounter.CountRepeats();
//     //   //Assert
//     //   Assert.Equal("a", result);
//     // }
    // [Fact]
    // public void CountRepeats_ReturnUserWord_Word()
    // {
    //   //Arrange
    //   string userString = "dog";
    //   string findWord = "dog";
    //   RepeatCounter testRepeatCounter = new RepeatCounter(userString, findWord);
    //   //Act
    //   string result = testRepeatCounter.CountRepeats();
    //   //Assert
    //   Assert.Equal("dog", result);
    // }
    [Fact]
    public void CountRepeats_ReturnCountForWord_Number()
    {
      //Arrange
      string userString = "dog";
      string userWord = "dog";
      RepeatCounter testRepeatCounter = new RepeatCounter(userString, userWord);
      //Act
      int result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal(1, result);
    }
    [Fact]
    public void CountRepeats_ReturnCountForMultipleWords_Number()
    {
      //Arrange
      string userString = "dog dog dog dog";
      string findWord = "dog";
      RepeatCounter testRepeatCounter = new RepeatCounter(userString, findWord);
      //Act
      int result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal(4, result);
    }
    [Fact]
    public void CountRepeats_ReturnCountForMatchingWord_Number()
    {
      //Arrange
      string userString = "I have a dog named Bozo. My dog loves to go on hikes";
      string findWord = "dog";
      RepeatCounter testRepeatCounter = new RepeatCounter(userString, findWord);
      //Act
      int result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal(2, result);
    }
    [Fact]
    public void CountRepeats_ReturnCountForToLowercase_Number()
    {
      //Arrange
      string userString = "I have a DOG named Bozo. My dog loves to go on hikes! My dog is awesome.";
      string findWord = "dog";
      RepeatCounter testRepeatCounter = new RepeatCounter(userString, findWord);
      //Act
      int result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal(3, result);
    }
    [Fact]
    public void CountRepeats_ReturnCountForSpecialCharacters_Number()
    {
      //Arrange
      string userString = "I have a DOG named Bozo. My dog loves to go on hikes! I love my Dog! Dog, Dog, DOg!";
      string findWord = "dog";
      RepeatCounter testRepeatCounter = new RepeatCounter(userString, findWord);
      //Act
      int result = testRepeatCounter.CountRepeats();
      //Assert
      Assert.Equal(6, result);
    }
  }
}

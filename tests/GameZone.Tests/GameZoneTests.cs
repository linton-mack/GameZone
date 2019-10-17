using System;
using Xunit;
using GameZone;

namespace GameZone.Tests
{
    public class GameZoneTests
    {
        [Fact]
        public void InstanceOfHangManIsCreated()
        {
            HangMan testHangMan = new HangMan();
            Assert.IsType<HangMan>(testHangMan);
        }

        [Fact]
        public void WordToFindIsCreatedWhenGenerateWordToUseIsCalled()
        {
            HangMan testHangMan = new HangMan();
            testHangMan.GenerateWordToUse();
            string wordToFind = testHangMan.GetWordToFind;
            Assert.NotNull(wordToFind);
        }

        [Fact]
        public void HangManStartsWith5Lives()
        {
            HangMan testHangMan = new HangMan();
            Assert.Equal(5, testHangMan.GetHangManLives);
        }

        [Fact]
        public void CheckGameHasBeenWonIsTrue()
        {
            HangMan testHangMan = new HangMan();
            char[] testArray = { 'a', 'b', 'c', 'd', 'e' };
            Boolean gameWon = testHangMan.IsGameWon(testArray);
            Assert.True(gameWon);
        }

        [Fact]
        public void CheckGameHasNotFinishedYet()
        {
            HangMan testHangMan = new HangMan();
            char[] testArray = { 'a', '-', 'c', 'd', 'e' };
            Boolean gameNotWon = testHangMan.IsGameWon(testArray);
            Assert.False(gameNotWon);
        }

        [Fact]
        public void CheckUserInputIsCorrect()
        {
            HangMan testHangMan = new HangMan();
            testHangMan.SetWordToFind("mystery");
            char[] testArray = { '-', '-', '-', '-', '-', '-', '-' };
            Boolean isMatch = testHangMan.CheckUserInput("m", testArray);
            Assert.True(isMatch);

        }

        [Fact]
        public void CheckUserInputIsFalse()
        {
            HangMan testHangMan = new HangMan();
            testHangMan.SetWordToFind("mystery");
            char[] testArray = { '-', '-', '-', '-', '-', '-', '-' };
            Boolean isMatch = testHangMan.CheckUserInput("a", testArray);
            Assert.False(isMatch);

        }
    }
}

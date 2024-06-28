using DiaryManager;

namespace DiaryManagerTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReadDiaryFileTest()
        {
            // Arrange 
            string filepath = Path.Combine(Environment.CurrentDirectory, "mydiary.txt");

            // Act
            string ExpectedContent = DiaryManager.DailyDiary.ReadAllTextMethod(filepath);

            // Assert
            string actualContent = File.ReadAllText(filepath);
            Assert.Equal(ExpectedContent, actualContent);
        }

        [Fact]
        public void AddToDiaryFileTest()
        {

            // Arrange 
            string filepath = Path.Combine(Environment.CurrentDirectory, "mydiary.txt");
            int actualContent = File.ReadAllLines(filepath).Length;
            Entry data = new Entry { Date = "2000-07-08", Content = "jafar" };

            // Act
            string[] ExpectedContent = DiaryManager.DailyDiary.AddMethod(filepath, data, data);

            // Assert
            int ExpectedContentResult = ExpectedContent.Length;
            int finalLineCount = File.ReadAllLines(filepath).Length;

            Assert.True(finalLineCount > actualContent);
        }
    }
}
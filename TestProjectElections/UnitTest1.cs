using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void TestError1()
        {
            string[] str = { };
            Assert.AreEqual("error 1", ClassLibraryVotes.Elections(str));
        }
        [Test]
        public void TestError2()
        {
            string[] str = { "10", "10", "7", "5", "8", "5", "3" };
            Assert.AreEqual("error 2", ClassLibraryVotes.Elections(str));
        }
        [Test]
        public void TestError3()
        {
            string[] str = { "5", "10", "7", "5", "8", "5", "3", "6"};
            Assert.AreEqual("error 3", ClassLibraryVotes.Elections(str));
        }
        [Test]
        public void TestAnswer()
        {
            string[] str = { "5", "10", "7", "5", "8", "5", "3"};
            Assert.AreEqual("170", ClassLibraryVotes.Elections(str));
        }
    }
}
using ClassLibrary1;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCheckError1()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2", "9" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }

        [TestMethod]
        public void TestMethodCheckError2()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2", "девять" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }
        //
        [TestMethod]
        public void TestMethodCheck1()
        {
            string[] str = { "w", "1", "4", "4", "0", "3", "5", "2"};
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }

        [TestMethod]
        public void TestMethodCheck2()
        {
            string[] str = { "1", "w", "4", "4", "0", "3", "5", "2"};
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }
        [TestMethod]
        public void TestMethodCheck3()
        {
            string[] str = { "1", "1", "w", "4", "0", "3", "5", "2" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }
        [TestMethod]
        public void TestMethodCheck4()
        {
            string[] str = { "1", "1", "4", "w", "0", "3", "5", "2" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }

        [TestMethod]
        public void TestMethodCheck5()
        {
            string[] str = { "1", "1", "4", "4", "w", "3", "5", "2" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }
        [TestMethod]
        public void TestMethodCheck6()
        {
            string[] str = { "1", "1", "4", "4", "0", "w", "5", "2" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }

        [TestMethod]
        public void TestMethodCheck7()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "w", "2" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }
        [TestMethod]
        public void TestMethodCheck8()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "w" };
            Assert.AreEqual(false, ClassLibraryFlowerbad.Check(str));
        }
        //

        [TestMethod]
        public void TestMethodCheck()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2" };
            Assert.AreEqual(true, ClassLibraryFlowerbad.Check(str));
        }
        [TestMethod]
        public void TestMethodRectangleAreaError()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2" };
            ClassLibraryFlowerbad.Check(str);

            Assert.AreEqual(0, ClassLibraryFlowerbad.RectangleArea("кто-то"));
        }

        [TestMethod]
        public void TestMethodRectangleAreaBoys()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2" };
            ClassLibraryFlowerbad.Check(str);

            Assert.AreEqual(9, ClassLibraryFlowerbad.RectangleArea("boys"));
        }
        [TestMethod]
        public void TestMethodRectangleAreaGirls()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2" };
            ClassLibraryFlowerbad.Check(str);

            Assert.AreEqual(5, ClassLibraryFlowerbad.RectangleArea("girls"));
        }

        [TestMethod]
        public void TestMethodIntersectionAreaError1()
        {
            string[] str = { "3", "1", "3", "2", "0", "3", "5", "2" };
            ClassLibraryFlowerbad.Check(str);

            Assert.AreEqual(0, ClassLibraryFlowerbad.IntersectionArea());
        }
        [TestMethod]
        public void TestMethodIntersectionAreaError2()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "2", "2" };
            ClassLibraryFlowerbad.Check(str);

            Assert.AreEqual(0, ClassLibraryFlowerbad.IntersectionArea());
        }
        [TestMethod]
        public void TestMethodIntersectionArea()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "2", "5" };
            ClassLibraryFlowerbad.Check(str);

            Assert.AreEqual(1, ClassLibraryFlowerbad.IntersectionArea());
        }

        [TestMethod]
        public void TestMethodAreaTotal()
        {
            string[] str = { "1", "1", "4", "4", "0", "3", "5", "2" };
            ClassLibraryFlowerbad.Check(str);

            int areaBoys = ClassLibraryFlowerbad.RectangleArea("boys");
            int areaGirls = ClassLibraryFlowerbad.RectangleArea("girls");

            int totalArea = areaBoys + areaGirls - ClassLibraryFlowerbad.IntersectionArea();
            Assert.AreEqual(14, totalArea);
        }
    }
}
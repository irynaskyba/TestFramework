using E2ETests.Pages;
using E2ETests.Suites;
using NUnit.Framework;

namespace E2ETests.Tests
{
    [TestFixture]
    public class AddTagTest : NbaSuite
    {
        NbaPage nbaPage;
        AddTagDialog addTagDialog;

        [SetUp]
        public void SetUp()
        {
            nbaPage = new NbaPage();
            addTagDialog = new AddTagDialog();
        }

        [TearDown]
        public void TearDown()
        {
            nbaPage.ClickAddTag();
            addTagDialog.ClickRemove();
            addTagDialog.Close();
        }

        [Test]
        public void VerifyAddingTag()
        {
            nbaPage.ClickAddTag();
            addTagDialog.SelectTag("высшая лига Бельгия");
            addTagDialog.Close();

            Assert.IsTrue(nbaPage.IsTagPresent("высшая лига Бельгия"));
        }
    }
}

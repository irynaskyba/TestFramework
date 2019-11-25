﻿using E2ETests.Pages;
using NUnit.Framework;

namespace E2ETests.Tests
{
    [TestFixture]
    public class AddTagTest
    {
        MainPage mainPage;
        AddTagDialog addTagDialog;

        [SetUp]
        public void SetUp()
        {
            mainPage = new MainPage();
            addTagDialog = new AddTagDialog();
        }

        [TearDown]
        public void TearDown()
        {
            mainPage.ClickAddTag();
            addTagDialog.ClickRemove();
            addTagDialog.Close();
            mainPage.CloseBrowser();
        }

        [Test]
        public void VerifyAddingTag()
        {
            mainPage.ClickAddTag();
            addTagDialog.SelectTag("высшая лига Бельгия");
            addTagDialog.Close();

            Assert.IsTrue(mainPage.IsTagPresent("высшая лига Бельгия"));
        }
    }
}

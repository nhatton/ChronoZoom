﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    [Ignore]
    public class WelcomeScreenTests : TestBase
    {
        #region Initialize and Cleanup
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {
            BrowserStateManager.RefreshState();
            WelcomeScreenHelper.ResetPopupState();
            HomePageHelper.OpenPage();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
            CreateScreenshotsIfTestFail(TestContext);
        }

        #endregion

        [TestMethod]
        public void When_user_clicks_start_exploring_welcome_popup_is_closed()
        {
            WelcomeScreenHelper.StartExploring();
            Assert.IsFalse(WelcomeScreenHelper.IsWelcomeScreenDispalyed(), "WelcomeScreen is not closed");
        }
    }
}
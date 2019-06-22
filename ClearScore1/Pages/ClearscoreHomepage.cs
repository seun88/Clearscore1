using NUnit.Framework;
using OpenQA.Selenium;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearScore1.Pages
{
    public class ClearscoreHomepage :BaseClass 
    {
        private IWebElement logo;

        public void AndIAmOnHomepage()
        {
            logo = GetElementByCssSelector(".navbar-logos .logo.navbar-logo");
            Assert.True(logo.Displayed, "is not displayed");
        }
    }
}

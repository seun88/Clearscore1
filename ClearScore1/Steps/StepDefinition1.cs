using ClearScore1.Pages;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClearScore1.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        private ClearscoreHomepage homepage;  


        [Given(@"I navigate to Homepage")]
        public void GivenINavigateToHomepage()
        {
            homepage = BaseClass.GivenINavigateToHomePage();
            homepage.AndIAmOnHomepage();
        }

    }
}

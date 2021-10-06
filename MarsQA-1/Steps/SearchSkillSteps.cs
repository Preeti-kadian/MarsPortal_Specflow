using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SearchSkillSteps
    {
        SearchSkill searchObj = new SearchSkill();
        [Given(@"I click on Search skills on home page")]
        public void GivenIClickOnSearchSkillsOnHomePage()
        {
            searchObj.SearchSkillIcon();
        }
        
        [When(@"I type in seller name in search user box")]
        public void WhenITypeInSellerNameInSearchUserBox()
        {
          
            searchObj.SearchUser();
                
        }
       
        
        [When(@"I type in skills category in search box")]
        public void WhenITypeInSkillsCategoryInSearchBox()
        {
            searchObj.SearchSkillsByCategory();
        }
        
        [When(@"I click on search category icon")]
        public void WhenIClickOnSearchCategoryIcon()
        {
            searchObj.ClickSearchUser();
        }
        
        [Then(@"refined search of seller name as result should be displayed\.")]
        public void ThenRefinedSearchOfSellerNameAsResultShouldBeDisplayed_()
        {
            Start.test = Start.extent.StartTest("Search skill by user feature");
            searchObj.ValidateSearchFilter();

        }

        [Then(@"refined category list should be displayed\.")]
        public void ThenRefinedCategoryListShouldBeDisplayed_()
        {
            Start.test = Start.extent.StartTest("Search skill by category feature");
            searchObj.SearchSkillsByCategory();
        }
    }
}

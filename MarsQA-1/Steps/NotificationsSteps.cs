using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerIsAbleToSeeNotificationsSteps
    {
        [Given(@"I Clicks on the Notification button")]
        public void GivenIClicksOnTheNotificationButton()
        {
            
        }
        
        [Given(@"I Clicks on the See all button")]
        public void GivenIClicksOnTheSeeAllButton()
        {
            Start.test = Start.extent.StartTest("Notification feature");
            Notifications notifiObj = new Notifications();
            notifiObj.Notification();

        }
        
        [Given(@"I Clicks on the Load More button")]
        public void GivenIClicksOnTheLoadMoreButton()
        {
           
        }
        
        [Given(@"I Ticks a notification Item")]
        public void GivenITicksANotificationItem()
        {
            
        }
        
        [Given(@"Clicks on the See all button")]
        public void GivenClicksOnTheSeeAllButton()
        {
           
        }
        
        [Given(@"Clicks on Select All icon")]
        public void GivenClicksOnSelectAllIcon()
        {
            
        }

        [Given(@"Clicks on Select all")]
        public void GivenClicksOnSelectAll()
        {
        }
        
        [When(@"I Clicks on the Mark all as read button")]
        public void WhenIClicksOnTheMarkAllAsReadButton()
        {
           
        }
        
        [When(@"I Clicks on the See all button")]
        public void WhenIClicksOnTheSeeAllButton()
        {
           
        }
        
        [When(@"I Clicks on the Load More button")]
        public void WhenIClicksOnTheLoadMoreButton()
        {
            
        }
        
        [When(@"I Clicks on the Show Less button")]
        public void WhenIClicksOnTheShowLessButton()
        {
           
        }
        
        [When(@"I Clicks on the Delete Selection icon")]
        public void WhenIClicksOnTheDeleteSelectionIcon()
        {
            
        }
        
        [When(@"Clicks on Select all")]
        public void WhenClicksOnSelectAll()
        {
            
        }
        
        [When(@"Clicks on Unselect all")]
        public void WhenClicksOnUnselectAll()
        {
           
        }
        
        [Then(@"The numbers of notification should be Cleared")]
        public void ThenTheNumbersOfNotificationShouldBeCleared()
        {
            
        }
        
        [Then(@"The I should be able to navigate to the dashboard Page")]
        public void ThenTheIShouldBeAbleToNavigateToTheDashboardPage()
        {
            
        }
        
        [Then(@"The Show Less button should be displayed")]
        public void ThenTheShowLessButtonShouldBeDisplayed()
        {
            
        }
        
        [Then(@"The Show Less button should be not displayed")]
        public void ThenTheShowLessButtonShouldBeNotDisplayed()
        {
            
        }
        
        [Then(@"The notification Item should be deleted")]
        public void ThenTheNotificationItemShouldBeDeleted()
        {
            
        }
        
        [Then(@"All of the notification items should be deleted")]
        public void ThenAllOfTheNotificationItemsShouldBeDeleted()
        {
            
        }
        
        [Then(@"All notifications should be selected")]
        public void ThenAllNotificationsShouldBeSelected()
        {
            
        }
        
        [Then(@"All notifications should be unselected")]
        public void ThenAllNotificationsShouldBeUnselected()
        {
           
        }
    }
}

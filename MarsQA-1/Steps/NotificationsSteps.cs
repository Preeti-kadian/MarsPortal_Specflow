using MarsQA_1.SpecflowPages.Pages;
using MArsQASpecflow.SpecflowPages.Utils;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps
{
    [Binding]
    public class SellerIsAbleToSeeNotificationsSteps
    {
        Notifications notifiObj = new Notifications();
        

        [Given(@"I Clicks on the Notification button")]
        public void GivenIClicksOnTheNotificationButton()
        {
            notifiObj.NotificationLink();
        }
        
        [Given(@"I Clicks on the See all button")]
        public void GivenIClicksOnTheSeeAllButton()
        {
            Start.test = Start.extent.StartTest("Notification feature");
           
            notifiObj.ValidateSeeAllNotification();

        }
        
        [Given(@"I Clicks on the Load More button")]
        public void GivenIClicksOnTheLoadMoreButton()
        {
            
            notifiObj.LoadMoreLink();
        }
        
        [Given(@"I Ticks a notification Item")]
        public void GivenITicksANotificationItem()
        {
            notifiObj.CheckAll();
        }
        
        [Given(@"Clicks on the See all button")]
        public void GivenClicksOnTheSeeAllButton()
        {
            Start.test = Start.extent.StartTest("Notification See all feature");
           
            notifiObj.SeeAllLink();
        }
        
        [Given(@"Clicks on Select All icon")]
        public void GivenClicksOnSelectAllIcon()
        {
            
            notifiObj.SelectAllLink();
        }

        [Given(@"Clicks on Select all")]
        public void GivenClicksOnSelectAll()
        {
            notifiObj.SelectAllLink();
        }
        
        [When(@"I Clicks on the Mark all as read button")]
        public void WhenIClicksOnTheMarkAllAsReadButton()
        {
            Start.test = Start.extent.StartTest("Notification See all feature");
            notifiObj.MarkAll();
        }
        
        [When(@"I Clicks on the See all button")]
        public void WhenIClicksOnTheSeeAllButton()
        {
            Start.test = Start.extent.StartTest("Notification See all feature");
           
            notifiObj.SeeAllLink();
        }
        
        [When(@"I Clicks on the Load More button")]
        public void WhenIClicksOnTheLoadMoreButton()
        {
            
            notifiObj.LoadMoreLink();
        }
        
        [When(@"I Clicks on the Show Less button")]
        public void WhenIClicksOnTheShowLessButton()
        {
            
            notifiObj.ShowLessLink();
        }
        
        [When(@"I Clicks on the Delete Selection icon")]
        public void WhenIClicksOnTheDeleteSelectionIcon()
        {
           
            notifiObj.DeleteNotification();

        }
        
        [When(@"Clicks on Select all")]
        public void WhenClicksOnSelectAll()
        {
           
            notifiObj.SelectAllLink();
            
        }
        
        [When(@"Clicks on Unselect all")]
        public void WhenClicksOnUnselectAll()
        {
            notifiObj.UnselectAllLink();
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
            notifiObj.ShowLessLink();
        }
        
        [Then(@"The Show Less button should be not displayed")]
        public void ThenTheShowLessButtonShouldBeNotDisplayed()
        {
            notifiObj.ValidateShowLessNotDisplayed();
        }
        
        [Then(@"The notification Item should be deleted")]
        public void ThenTheNotificationItemShouldBeDeleted()
        {
            notifiObj.DeleteNotification();
        }
        
        [Then(@"All of the notification items should be deleted")]
        public void ThenAllOfTheNotificationItemsShouldBeDeleted()
        {
            Start.test = Start.extent.StartTest("Notification Delete feature");
            notifiObj.ValidateDeleteNotification();
        }
        
        [Then(@"All notifications should be selected")]
        public void ThenAllNotificationsShouldBeSelected()
        {
            notifiObj.SelectAllLink();
        }
        
        [Then(@"All notifications should be unselected")]
        public void ThenAllNotificationsShouldBeUnselected()
        {
            notifiObj.UnselectAllLink();

        }
    }
}

Feature: Practice Test Login


    Scenario: Login with valid credentials
        Given I open the browser
        When I navigate to "https://practicetestautomation.com/practice-test-login/"
        And I wait for the element with id "dynamicElement" to be visible
        And I enter the username "student"
        And I enter the password "Password123"
        And I click the login button
     #   Then I should be logged in successfully

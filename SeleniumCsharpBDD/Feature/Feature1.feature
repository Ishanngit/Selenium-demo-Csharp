Feature: Selenium  Feature
    As a user,
    I want to open a web page,
    So that I can perform basic interactions with the page.

    Scenario: Open a web page
        Given I open the browser
        When I navigate to "https://www.google.com"
        Then the page should contain the text "Google"
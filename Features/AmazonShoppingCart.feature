Feature: Amazon Shopping Cart

A simple test feature to verify the item selected by an unregistered user in amazon is displayed in cart 

@tag1
Scenario: Add Item to cart as an unregistered user
	Given I am on Amazon home page as an unregistered user
	When I search for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
	And I add the item to my cart
	Then item should be displayed in cart with the correct amount



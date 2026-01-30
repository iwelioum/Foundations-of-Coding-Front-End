Control Structures

Objective:

By the end of this activity, you will be able to apply if-else statements and switch cases to simulate decisions in a program related to booking tickets for different travel modes.
Step 1: If-Else Statement for Ticket Pricing

You are developing a program for a travel company to determine the ticket price based on the passenger's age. The company offers discounted prices for children and seniors. The rules are:

    Children (under 12) pay half price.

    Adults (12 to 65) pay full price.

    Seniors (over 65) get a 20% discount.

Write a program using an if-else statement to determine which price a passenger will pay.

Steps:

    Declare a variable int age to store the passenger’s age.

    Prompt the user to enter their age using Console.WriteLine and capture the input using Console.ReadLine().

    Use int.Parse() to convert the input string into an integer and store it in the age variable.

    Write an if-else statement to determine the ticket price:

        If age < 12, print "Half price ticket."

        If age is between 12 and 65, print "Full price ticket."

        Otherwise, print "Senior discount ticket."

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly!

To check your answer, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side, and select run. If you receive an error when you run the code, go to the reading on the next page to compare your code to the correct answer.
Step 2: Switch Statement for Travel Mode Selection 

The travel company offers multiple travel modes: "Bus," "Train," and "Flight." Each mode has a different booking message. Create a program using a switch statement to determine which mode of transportation the user selects.

Steps:

    Declare a string variable string mode to store the user's travel mode.

    Prompt the user to select a mode using Console.WriteLine and capture the input using Console.ReadLine().

    Use a switch statement to determine which message to print:

        If the user selects "Bus," print "Booking a bus ticket."

        If the user selects "Train," print "Booking a train ticket."

        If the user selects "Flight," print "Booking a flight ticket."

        Include a default case for invalid inputs with the message "Invalid selection. Please choose Bus, Train, or Flight."

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly!

To check your answer, visit Dot Net Fiddle
, delete the code on the page, paste your code into the left-hand side, and select run. If you receive an error when you run the code, go to the reading on the next page to compare your code to the correct answer.
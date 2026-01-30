Creating a Task Manager with Boolean Logic and Conditionals

Objective:

You will create a basic task manager program that stores and displays up to three tasks using individual string variables. The tasks can be marked as completed using Boolean flags, and the program will display which tasks are completed or still pending.

Problem Statement

Imagine you're an engineer managing a small to-do list with three tasks. You want a simple program that allows you to:

    Add a task

    Mark tasks as completed

    Display the status of each task (either completed or pending)

The catch? You can only manage up to three tasks, and you haven't learned how to work with arrays yet. But you can still accomplish this with what you know: variables, if-else statements, and loops.
Steps

    Create Variables for Tasks and Their Status

        Set up three string variables to store the tasks.

        Create three Boolean variables to track whether each task is completed.

    Prompt User to Add a Task

        Ask the user to input a task.

        Check which task variable is empty and store the new task in that variable.

        If all task slots are full, inform the user that no more tasks can be added.

    Mark a Task as Completed

        Ask the user to choose which task (1, 2, or 3) to mark as completed.

        Use if-else conditions to update the corresponding Boolean variable, marking the task as completed. Use if-else conditions to update the task status and Send/Display a confirmation message to the user.

        If the user selects an invalid task number, display an error message.

    Display the Tasks and Their Status

        Print out each task along with its status (either "Completed" or "Pending").

        Use if-else conditions to check whether each task is completed or not and display the appropriate status.

You can draft and run your code directly in Dot Net Fiddle
, a simple online editor for .NET projects. If you prefer, you can also use a text editor like Notepad or Visual Studio Code, but DotNetFiddle is great for testing and running your code quickly!  If you would like to run your code, visit Dot Net Fiddle
, delete the code on the page, paste your code below into the left hand side,  and select run.
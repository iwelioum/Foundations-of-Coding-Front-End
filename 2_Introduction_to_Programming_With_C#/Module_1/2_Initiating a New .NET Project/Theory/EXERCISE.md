# Activity: Initiating a New .NET Project

## Objective

Create a new .NET project using Visual Studio Code and the .NET Command Line Interface (CLI), build the project, and run the application to verify it works.

## Description

This activity will guide you through creating a new .NET console application, building it, and running it to ensure your development environment is properly configured.

## Step 1: Open Visual Studio Code

Open Visual Studio Code on your machine.

## Step 2: Create a New .NET Project

Choose one of the following methods:

### Using the CLI

1. Right-click on a folder in the File Explorer and click **Open in Integrated Terminal**.
2. Alternatively, navigate to the desired directory using **Terminal > New Terminal** and the `cd` command.
3. Type `dotnet new console -o MyFirstConsoleApp` in the terminal.
4. Press Enter to create the project.

### Using the UI

1. Open the Command Palette (`Ctrl + Shift + P`) and type `.NET: New Project...` and select it.
2. Alternatively, open the File Explorer pane and click **Create .NET Project**.
3. From the menu, select **Console App**.
4. Choose an output folder where your project will be stored.
5. Provide a name for your project, e.g., `MyFirstConsoleApp`.
6. Click **Create Project**.

## Step 3: Run the Project

### Using the CLI

1. In the terminal, navigate to your project folder (if you're not already there), and type `dotnet run`.
2. Press Enter to execute the project.

### Using the UI

1. Click **Run and Debug** in the left-hand menu to open the Run and Debug Panel.
2. Click the **Run and Debug** button.
3. Select **C#** as the environment.
4. Choose the appropriate launch configuration for your application.
5. Alternatively, click **Run > Start Debugging** in the top menu or use `F5`.

## Step 4: Verification

Look for the text `"Hello, World!"` (or any other output from your application) in the terminal to verify that the project ran successfully.

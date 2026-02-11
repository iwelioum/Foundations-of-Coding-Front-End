# Activity: Setting Up Your .NET Development Environment

## Objective

Set up a fully functional .NET development environment on your local machine and verify its installation.

## Description

This activity will guide you through the steps to install the .NET SDK, configure your development environment, and verify that everything is working correctly. You have already seen how to set up the .NET SDK and configure your development environment in the videos. Now, it's your turn to follow these steps to complete the setup on your own.

## Step 1: Install the .NET SDK

### Instructions

1. Visit the official .NET website.
2. Download the latest .NET SDK installer for your operating system (Windows, macOS, or Linux).
3. Run the installer and follow the on-screen instructions.

## Step 2: Verify the Installation

### Instructions

1. Open the Command Prompt (Windows) or Terminal (macOS/Linux).
2. Type `dotnet --version` and press Enter.
3. Ensure that you don't get an error message.

## Step 3: Set Up Your Integrated Development Environment (IDE)

### Instructions

1. Download and install Visual Studio Code.
2. For Visual Studio Code, install the **C# Dev Kit** extension from the Extensions Marketplace.

## Step 4: Create a New .NET Project

Choose one of these options:

### Option 1 - Console

1. Open the VS Code Terminal at the desired output location.
2. Run the command `dotnet new console`.

### Option 2 - Command Palette

1. Open the command palette.
2. Run the command `.NET: New Project`.
3. Select "Console App".
4. Choose an output location.
5. Give your project a name.
6. Select "Create Project".

### Option 3 - VS Code Menu

1. Navigate to the File Explorer.
2. Click the "Create .NET Project".
3. Select "Console App".
4. Choose an output location.
5. Give your project a name.
6. Select "Create Project".

## Step 5: Configure Your IDE Settings (Optional)

### Instructions

1. Adjust editor settings like font size, theme, or keyboard shortcuts to your preference.
2. Install additional tools such as Git if needed.

## Step 6: Test Your Development Environment

Choose one of these options:

### Option 1 - Console

1. Open the VS Code Terminal at the desired output location.
2. Run the command `dotnet run`.

### Option 2 - VS Code Menu

1. Click "Run and Debug" in the left navigation menu.
2. Click the "Run and Debug Button".
3. Choose C#.

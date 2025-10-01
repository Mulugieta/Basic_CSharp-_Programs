🚀 C# Projects

This repository contains a collection of coding exercises and projects I developed while learning C# and the .NET Framework during The Tech Academy’s curriculum. Each project highlights a key programming concept or framework feature.

📂 Projects

Console App Array Assignment

This is a simple C# console application that demonstrates the use of arrays, lists, index selection, and error handling. The program walks the user through selecting indices from arrays and a list, and then displays the content at those indices. It also handles invalid input gracefully by showing an error message when the user selects an index that doesn’t exist.

Features

String Array

A one-dimensional array of strings is created.

The user selects an index, and the program displays the string at that index.

If the user selects an invalid index, an error message is displayed.

Integer Array

A one-dimensional array of integers is created.

The user selects an index, and the program displays the integer at that index.

If the user selects an invalid index, an error message is displayed.

String List

A list of strings is created.

The user selects an index, and the program displays the content at that index.

If the user selects an invalid index, an error message is displayed.

Code Comments

Every line or block of the code is documented with comments, so another developer can easily follow and understand the logic.

How It Works

When you run the app, it will:

Show you the available number of items in the string array.

Ask you to enter an index.

Display the value at that index or an error if the index is invalid.

Repeat the same process for the integer array.

Repeat again for the list of strings.



Six Part Assignment – C# Console App

This repository contains a C# Console Application developed as a six-part assignment. The goal of this project is to practice arrays, lists, loops, string manipulation, searching, duplicates, and error handling in C#.

Each part builds on the previous one, demonstrating fundamental programming concepts with detailed comments in the code for clarity.

📚 Features by Part
Part 1: Arrays & String Appending

Create a one-dimensional array of strings.

Ask the user to input some text.

Append the user’s text to every string in the array.

Print the updated array contents.

Part 2: Infinite Loop & Fix

Demonstrate an infinite loop (while(true)).

Fix it by adding a counter and a break condition.

Add comments explaining the fix.

Part 3: Loop Comparison Operators

Create a loop using the < operator for iteration.

Create another loop using the <= operator.

Demonstrates different comparison operators in loop conditions.

Part 4: Unique List Search

Create a list of unique strings.

Ask the user to input text to search for.

Loop through the list and print the index of the match.

If the text is not found, notify the user.

Stop the loop immediately once a match is found.

Part 5: Multiple Matches in List

Create a list of strings with duplicate values.

Ask the user to search for a string.

Print all indices where matches are found (no break statements).

If the input does not exist in the list, notify the user.

Part 6: Detecting Duplicates with Foreach

Create a list of strings with duplicates.

Use a foreach loop to evaluate each item.

Display whether each item is unique or a duplicate.

Example:

A - this item is unique  
B - this item is unique  
C - this item is unique  
D - this item is unique  
C - this item is a duplicate  

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or higher)

Visual Studio / VS Code

🚀 How to Run

Clone this repository:



Console App – Strings and Integers Assignment

This C# console application demonstrates how to work with lists, loops, user input, division operations, and error handling using try/catch.

The assignment is designed to show how programs respond to different types of input (valid numbers, zero, invalid strings) and how proper exception handling ensures the program continues running smoothly after errors.

📚 Features

List of Integers

The program creates a list of integers.

User Input

The user is prompted to enter a number to divide each integer in the list by.

Loop & Division

A loop divides each number in the list by the user’s input and displays the results.

Error Demonstration

When dividing by zero, the program initially produces a runtime error (DivideByZeroException).

When entering a string, the program produces a runtime error (FormatException).

Exception Handling (try/catch)

The division loop is placed inside a try/catch block.

If an error occurs (invalid input, divide by zero), the program catches the exception and displays an appropriate error message.

Code after the try/catch still executes, proving that the program continues running instead of crashing.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository:




Console App – Calling Methods Assignment

This C# console application demonstrates how to create a class with methods, perform math operations, and call methods from Main().

The program takes user input, calls three separate math methods, and displays the results to the console. Each method is located in a separate .cs file for clean structure.

📚 Features

Custom Class with Methods

A class is created in a separate .cs file.

The class contains three methods, each taking one integer parameter and returning an integer.

Each method performs a different math operation (e.g., addition, multiplication, subtraction, etc.).

User Input

The program prompts the user to enter an integer.

Calling Methods

The input is passed to each method in the custom class.

Each method returns the result of its operation.

Results are printed to the screen.

Code Documentation

Each method and block of code is fully commented so another developer can understand what the code does.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or higher)

Visual Studio / VS Code

🚀 How to Run

Clone this repository:




Console App – Method Class Assignment

This C# console application demonstrates how to create and use a class with a void method that accepts parameters, perform a math operation, and use both positional and named arguments when calling methods.

📚 Features

Custom Class with Void Method

A class is created with a void method that accepts two integers as parameters.

The method performs a math operation on the first integer (e.g., multiply or add).

The method also displays the second integer directly to the screen.

Instantiation & Method Calls

The class is instantiated in Main().

The method is called twice:

Once using positional arguments (normal method call).

Once using named arguments (specifying parameter names explicitly).

Code Documentation

Each part of the code is fully commented so another developer can easily understand what is happening.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository


Console App – Class Method Assignment

This C# console application demonstrates how to work with methods, method overloading, output parameters, and static classes. The assignment builds on core OOP concepts by requiring the use of methods that take input, perform math, and return results in multiple ways.

📚 Features

Custom Class with a Void Method

A class is created with a void method that outputs an integer.

The method takes one parameter, divides it by 2, and outputs the result.

User Input

The program prompts the user to enter a number.

The entered number is passed into the method.

The method displays the result (the number divided by 2).

Output Parameters

A method is created that uses an output parameter to return data.

This demonstrates an alternative way of returning values from methods.

Method Overloading

The class contains two methods with the same name but different parameter signatures.

This shows how methods can be reused with different inputs.

Static Class

A separate class is declared as static.

Static methods are demonstrated, which can be called without instantiating the class.

Code Documentation

Each method and block of code includes detailed comments for readability and developer understanding.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository



Console App – Methods and Objects Assignment

This C# console application demonstrates the use of classes, inheritance, and methods in object-oriented programming. The assignment focuses on creating a base class (Person), inheriting from it with a derived class (Employee), and calling a method from the base class on the derived object.

📚 Features

Person Class

Contains two string properties:

FirstName

LastName

Includes a method SayName() that prints the full name to the console in the format:

Name: [FirstName] [LastName]


Employee Class

Inherits from the Person class.

Adds an integer property Id.

Main Method

Instantiates an Employee object with:

FirstName = "Sample"

LastName = "Student"

Calls the inherited SayName() method to display the employee’s full name.

Code Documentation

All methods and classes include detailed comments so another developer can easily understand what the code is doing.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository




Console App – Abstract Class Assignment

This C# console application demonstrates the use of abstract classes, inheritance, and method implementation in object-oriented programming. The project highlights how to define an abstract class, implement its abstract method in a derived class, and use it in a console program.

📚 Features

Abstract Class: Person

Contains two properties:

string firstName

string lastName

Defines an abstract method SayName().

This means it does not provide an implementation in Person, but requires derived classes to implement it.

Derived Class: Employee

Inherits from Person.

Implements the SayName() method to display the full name in the format:

Name: [firstName] [lastName]


Main Program

Instantiates an Employee object with:

firstName = "Sample"

lastName = "Student"

Calls the SayName() method on the Employee object to display the full name.

Code Documentation

Each line/block of code is fully commented for clarity and to help other developers understand the logic.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository



Console App – Polymorphism Assignment

This C# console application demonstrates the use of interfaces, polymorphism, and inheritance in object-oriented programming. The project shows how a class can implement an interface, how polymorphism allows objects to be treated as interface types, and how methods can be executed via those interface references.

📚 Features

Interface: IQuittable

Defines a void Quit() method.

Represents a contract that any implementing class must fulfill.

Employee Class

Inherits from the Person class (created in the previous drill).

Implements the IQuittable interface.

Provides its own definition of the Quit() method (e.g., printing a message to the console).

Polymorphism in Action

An Employee object is created.

A variable of type IQuittable references that object.

The Quit() method is called using the IQuittable reference, demonstrating polymorphism.

Code Documentation

Every line/block of code is commented to ensure readability and easy understanding for other developers.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository



Console App – Operators Assignment

This C# console application demonstrates operator overloading by creating a custom equality check (== and !=) for an Employee class. It shows how to compare objects based on their property values instead of default reference comparison.

📚 Features

Employee Class

Contains three properties:

Id (int)

FirstName (string)

LastName (string)

Operator Overloading

The equality operator == is overloaded to compare two Employee objects based on their Id property.

The inequality operator != is also overloaded (operators must be defined in pairs).

Program Demonstration

Two Employee objects are instantiated and given property values.

The program compares the objects using the overloaded operators and prints the results to the console.

Code Documentation

Every line/block of code is commented for clarity so another developer can easily follow the logic.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository




Console App – Parameters Assignment

This C# console application demonstrates the use of generics in classes, properties, and object instantiation. The project creates a generic Employee<T> class, assigns lists of different data types to it, and iterates through them for display.

📚 Features

Generic Employee Class

Uses a generic type parameter <T>.

Includes a property Things of type List<T>.

String-based Employee

An instance of Employee<string> is created.

The Things property is assigned a list of strings (e.g., names, words).

Integer-based Employee

An instance of Employee<int> is created.

The Things property is assigned a list of integers (e.g., IDs, numbers).

Loop for Display

A foreach loop prints all items in the Things lists for both objects.

Code Documentation

Each line/block of code is commented to ensure clarity for other developers.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository




Console App – Parsing Enums Assignment

This C# console application demonstrates how to parse enums from user input with error handling using a try/catch block. It challenges the developer to work with enums, string parsing, and exception handling in a console environment.

📚 Features

Enum for Days of the Week

An enum DaysOfWeek is defined with values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday.

User Input

Prompts the user to enter the current day of the week.

Enum Parsing

Uses Enum.Parse() (or Enum.TryParse()) to convert the user’s string input into an enum value.

Stores the parsed value in a variable of type DaysOfWeek.

Error Handling

Wraps parsing in a try/catch block.

If the user enters something that is not a valid day, the program displays:

Please enter an actual day of the week.


Code Documentation

Each line/block is commented to ensure clarity for other developers.

🛠️ Technologies Used

C# (Console Application)

.NET 6.0 SDK (or later)

Visual Studio / VS Code

🚀 How to Run

Clone this repository









🔹 CarInsurance

This project demonstrates building a full ASP.NET MVC web application using Entity Framework for database interaction. The assignment covers multiple parts: setting up the project, scaffolding CRUD functionality, refining models/controllers/views, and adding business logic for insurance quotes.

ASP.NET MVC Entity Framework Assignment Part 1

Complete these actions:

Open Visual Studio and click File > New > Project.

Select Visual C# > ASP.NET Web Application (.NET Framework).

Name the project CarInsurance, then click Create.

Select the MVC template, then click Create.

In the Solution Explorer, right-click the App_Data folder and select Add > New Item.

Select SQL Server Database and name your database Insurance.mdf, then click Add.

In the Solution Explorer, double-click Insurance.mdf.

In the Server Explorer, under Insurance.mdf, right-click the Tables folder and select Add New Table.

In the T-SQL screen type the following SQL query:
(SQL query omitted in original instructions)

Click Update, then click Update Database.

In the Solution Explorer, right-click the Models folder and select Add > New Item.

Select ADO.NET Entity Data Model, name your data model InsuranceEntities, then click Add.

Select EF Designer from the database, then click Next.

Ensure your data connection is to Insurance.mdf and that you're saving connection settings in Web.Config as InsuranceEntities, then click Next.

If prompted, select Entity Framework 6.x, then click Next.

Click Tables, then click Finish.

Build the project (CTRL + SHIFT + B).

In the Solution Explorer, right-click the Controllers folder and select Add > Controller.

Select MVC 5 Controller with views, using Entity Framework, then click Add.

From the Model class dropdown, select Insuree (CarInsurance.Models).

From the Data context class dropdown, select InsuranceEntities (CarInsurance.Models).

Change the controller name from InsureesController to InsureeController, then click Add.

You now have a multi-page website with full CRUD functionality and the five standard MVC Views:

Index – Lists all objects of the Model.

Create – Allows the user to add a new object.

Edit – Allows the user to edit an object’s properties.

Details – Allows the user to view object details.

Delete – Allows the user to delete an object.

ASP.NET MVC Entity Framework Assignment Part 2

Complete these actions:

Build the project and press F5 to run in the browser.

In the browser bar, change the URL to:

http://localhost:12345/Insuree/Index


(your number will differ)

If the browser is closed, rebuild the project.

Click Create New (navigates to the Create View).

Enter these values (all are required, non-nullable):

FirstName: Joe

LastName: Black

EmailAddress: joeblack@gmail.com

DateOfBirth: 09/28/1991

CarYear: 2013

CarMake: Ford

CarModel: C-Max SE

DUI: (leave unchecked)

Speeding Tickets: 0

Coverage Type: (leave unchecked)

Quote: 131.98

Click Create.

You’ll return to Index View.

Verify in Server Explorer > Insurees table > Show Table Data that Joe Black is persisted.

Edit the entry:

Change DateOfBirth from 9/28/1991 12:00:00 AM → 9/28/1991 11:00:00 PM.

Save, return to Index, and confirm database update.

View Details → Explore the Details View.

Delete Joe Black → Confirm deletion.

Verify in database that record is removed.

Index View is now empty again.

ASP.NET MVC Entity Framework Assignment Part 3

Concepts explained:

Models – Classes mapped to the database (via EF Designer or hardcoded).

Controllers – Classes handling the application logic.

Example: InsureeController will calculate quotes automatically instead of letting users type them.

Views – Web pages tied to controllers.

Default 5 MVC Views (Index, Create, Edit, Details, Delete).

Custom Views, Models, Controllers can be added for extended functionality.

From here, you will refine your project by:

Editing code in InsureeController.

Customizing Insuree Views.

Optionally adding:

InsureeMetadata class in Models.

CSS file for styling.

ASP.NET MVC Entity Framework Assignment Part 4

Add Quote Calculation Logic

In InsureeController, add logic to calculate insurance quotes:

Base rate: $50 / month.

Age adjustments:

18 or under → +$100

19–25 → +$50

26+ → +$25

Car year adjustments:

Before 2000 → +$25

After 2015 → +$25

Car make/model:

Porsche → +$25

Porsche 911 Carrera → +$50 total

Other adjustments:

+$10 per speeding ticket

DUI → +25% of total

Full coverage → +50% of total

Additional Requirements:

Modify Create View → Hide the “Quote” input field (system calculates automatically).

Add an Admin View → Displays:

First Name

Last Name

Email Address

Quote
🔹 Constructor Assignment

Demonstrates:

Constants and the var keyword.

Constructor chaining for cleaner initialization.

🔹 Daily Report Program

A console application that collects daily reports from students.

Gathers details like name, course, study hours, and feedback.

Stores the data in variables and displays a confirmation message.

🔹 DateTimeSubmission

A program that:

Shows the current date and time.

Accepts a user-input number.

Calculates and prints the future time after the given hours.

🔹 EFCodeFirstConsoleApp

A simple Entity Framework Code-First console app.

Defines a data model in code.

Auto-generates a database.

Performs CRUD operations on a sample student database.

🔹 Input Assignment

A file handling console app.

Asks the user for a number.

Saves the input to a text file.

Reads the file back and displays its contents.

🔹 Lambda Expression Assignment

Demonstrates LINQ and lambda queries:

Creates an Employee class and list.

Filters employees named “Joe” and those with IDs > 5.

🔹 Parsing Enums Assignment

Works with Enums:

Creates a DaysOfWeek enum.

Takes user input and validates it.

Handles invalid input with try/catch and displays custom messages.

🔹 Struct Assignment

Shows the use of structs in C#:

Defines a Number struct with a decimal property.

Creates and prints an instance in Main().

🔹 Try Catch Assignment

A robust input validation console app:

Asks for the user’s age.

Calculates the birth year.

Uses try/catch to handle invalid inputs (negative, zero, or non-numeric).

🔹 TwentyOne

A console-based Blackjack game 🎮

Simulates a casino-style Blackjack experience.

Provides interactive dealer vs. player gameplay.

Developed in collaboration with a Tech Academy instructor.

✨ This repo showcases my progression in C# and .NET, from simple assignments to a full MVC web application.

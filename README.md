# Student Grading System

## Overview
This is a simple C# console application that calculates a student's average marks, finds the minimum and maximum marks, and determines the grade based on given scores.

## Features
- Accepts a student's name and five marks as input.
- Calculates the **average marks** of the student.
- Finds the **minimum and maximum marks**.
- Determines the **grade** based on average marks.
- Uses **switch pattern matching** for grade evaluation.
- Implements **enum-based menu options** for user selection.

## C# Concepts Used
This project demonstrates several important **C# programming concepts**, including:

- **Classes & Objects**: The `Student` class represents a student with properties for name and marks.
- **Static Variables**: `AverageMarks` is a static variable shared across all instances.
- **Arrays**: The student's marks are stored in an array of `decimal` values.
- **Loops (for & foreach)**: Used to iterate through the array and calculate the total marks.
- **Methods**: `CalculateAverageMarks()` and `CalculateGrade(decimal marks)` are used for calculations.
- **Enums**: The `Options` enum defines menu choices.
- **Switch Pattern Matching**: Used in `CalculateGrade(decimal marks)` to assign grades.
- **User Input Handling**: Uses `Console.ReadLine()` and `Convert.ToDecimal()` for user input.
- **Enum Parsing**: `Enum.TryParse()` is used to validate and parse user menu choices.
- **Math Operations**: `Math.Min()` and `Math.Max()` are used to find min/max marks.

## Enum Options
The application provides the following menu options:
```csharp
enum Options
{
    Aggregate = 1,   // Displays the name & average marks
    MinMark = 2,     // Displays the minimum marks
    MaximumMark = 3, // Displays the maximum marks
    Grade = 4        // Displays the student's grade
}
```
## Below attached is the SS of the final output:
![image](https://github.com/user-attachments/assets/6de1645f-2419-4916-aaac-a91514f73dda)

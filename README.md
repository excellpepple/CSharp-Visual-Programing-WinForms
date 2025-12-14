# GPA Calculator

## Overview
A comprehensive C# Windows Forms GPA calculator that lets students manage semester data, including courses, credits, and letter grades. Users can add, edit, or remove courses for each semester and calculate GPA dynamically. Data is stored in files for persistence and can be reloaded across sessions.

## Motivation
This project combines multiple programming concepts: object-oriented design, file I/O, arrays and dictionaries, enums, multiple forms, and dynamic calculations. It demonstrates practical use of data structures to model real-world scenarios while maintaining a clean and modular design.

## Key Concepts
- **Multi-form architecture:** Separate forms for managing semesters, courses, and About information.
- **Classes and Objects:** `Semester` and `Course` classes with properties, constructors, and methods.
- **Enums:** `Grade` enum for representing letter grades.
- **Dictionaries:** `Courses` dictionary in `Semester` class to uniquely identify and manage courses.
- **Methods:** Void and value-returning methods for GPA calculation, credit totals, and string representations.
- **Loops and conditionals:** Iterating courses, calculating GPA, nested conditionals for grade handling.
- **File I/O:** Saving and loading semester data using text files.
- **Input validation & exception handling:** Ensuring safe user data entry.
- **UI controls:** TextBoxes, ListBoxes, MenuStrip, RadioButtons, CheckBoxes, ComboBox.
- **Constants and arithmetic operations:** Calculations for GPA and credit totals.
- **Unique identifiers:** `Guid` used to uniquely identify semesters and courses.

## Implementation Notes
- Each `Semester` stores courses in a dictionary with unique IDs.
- `Course` class maps letter grades to GPA points via `GetGradePoint()`.
- `Semester.CalculateGPA()` computes GPA weighted by course credits.
- Parallel form interaction allows adding, editing, and removing courses with real-time GPA updates.
- Data can be serialized to and read from text files using `ToString()` representations of semesters and courses.
- Copy constructors allow duplicating semesters and courses without altering the original objects.
- All UI interactions update underlying data and reflect changes immediately.

## Running the Project
- Open the solution in Visual Studio.
- Build and run the application.
- Use the main form to add, edit, or remove courses for each semester.
- Navigate between semesters and view GPA calculations dynamically.
- Save or load semester data from files as needed.

## Future Work
- Support cumulative GPA across multiple semesters.
- Add course weighting (honors/AP classes) and grade scaling.
- Introduce charts and visual representations of GPA trends.
- Refactor data storage to JSON or database for larger datasets.
- Implement undo/redo functionality for course edits.

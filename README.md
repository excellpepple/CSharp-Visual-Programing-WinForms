# Password Checker

## Overview
A desktop password validation tool built with Windows Forms that checks user entered passwords against configurable strength rules. The application validates length requirements, character composition, and disallowed characters while providing step by step visibility into how each character is evaluated.

It also includes a password generator that produces valid passwords based on the same constraints.

## Motivation
I wanted a low level look at how password rules are actually enforced under the hood rather than relying on built in validators. This project was an opportunity to work directly with characters, ASCII values, flags, and control flow.

## Key Concepts
- Decision and repetition control structures
- Character level string parsing
- ASCII based validation
- Flag driven rule evaluation
- Input validation and defensive loops
- Randomized password generation

## Implementation Notes
- Minimum password length is user defined and validated before any checks run
- Passwords that do not meet the minimum length trigger a re prompt loop
- Each character is evaluated individually using its ASCII value
- Flags track whether each rule has been satisfied
- A listbox logs character position, value, and ASCII code during validation
- Spaces are explicitly rejected as invalid special characters
- The generator assembles a valid password by guaranteeing required character types before filling remaining length

## Running the Project
- Open the solution in Visual Studio
- Build and run the application
- Enter a minimum password length and a password to validate
- Optionally generate a valid password automatically

## Future Work
- Replace ASCII checks with Unicode aware validation
- Add configurable rule toggles
- Improve UX around repeated prompts
- Expose the validator as a reusable library

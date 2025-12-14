# Store Checkout

## Overview
A simple point of sale style kiosk built with Windows Forms. The application lets users add items by clicking on them and see the subtotal, tax, and total update in real time. An optional tip can be entered and applied separately from taxed items.

The focus is on keeping calculations accurate while maintaining clear UI feedback.

## Motivation
I built this to solidify fundamentals around state management, numeric calculations, and user input handling in a desktop UI. It was a practical way to combine arithmetic logic with event driven updates and validation.

## Key Concepts
- Running totals and incremental state updates
- Constants vs mutable variables
- Currency formatting and string conversion
- User input validation and exception handling
- Separation of taxed items and untaxed additions

## Implementation Notes
- Item prices and tax rate are defined as constants to prevent accidental mutation
- Clicking an item increments its count and updates the subtotal
- Tax and total are recalculated on every state change
- Currency values are rendered using standard format strings
- Tip input is validated and applied directly to the total without tax
- Tip controls disable themselves once a valid value is applied

## Running the Project
- Open the solution in Visual Studio
- Build and run the project
- Click items to add them to the checkout
- Optionally enter a whole dollar tip and apply it

## Future Work
- Persist checkout state between sessions
- Support item removal or quantity adjustment
- Generalize pricing into a data driven model
- Improve input feedback without modal dialogs

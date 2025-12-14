# Movie Collection

## Overview
A multi form Windows Forms application that implements a small shopping cart system. Users browse items across separate category windows and add selections to a centralized cart where totals, tax, and optional shipping are calculated in real time.

The project emphasizes modular logic and shared state across forms.

## Motivation
I wanted to explore how to structure a WinForms application with multiple windows while keeping the business logic centralized. This was an exercise in separating concerns, reusing methods, and coordinating UI state across independent forms.

## Key Concepts
- Multi form application architecture
- Modal vs modeless windows
- Method based code modularization
- Shared state management through public interfaces
- Menu driven navigation
- Dynamic cart and pricing logic

## Implementation Notes
- The startup form acts as the application hub and owns all cart state
- Category forms are lightweight and delegate cart updates to the startup form
- Item prices are resolved through a single value returning method
- Totals, tax, and shipping are recalculated on every add or remove
- Shipping cost is derived from item count and applied separately from tax
- Menus and context menus replace traditional navigation buttons

## Running the Project
- Open the solution in Visual Studio
- Build and run the application
- Navigate categories through the menu
- Add items from different category forms
- Manage the cart and observe real time updates

## Future Work
- Persist cart state between sessions
- Replace hardcoded pricing with external data
- Add quantity controls per item
- Refactor forms into reusable components

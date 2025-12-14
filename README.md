# Movie Collection

## Overview
A Windows Forms application for managing a personal movie collection. The app supports adding movie metadata to a file and browsing an existing collection through a dedicated viewer with navigation controls.

Data is loaded into memory on startup and navigated without further file access, keeping the UI responsive and predictable.

## Motivation
I wanted to bring together file I O, multi form workflows, and in memory data structures into a single cohesive application. This project focuses on moving data cleanly between disk, memory, and UI while keeping the logic straightforward.

## Key Concepts
- Multi form WinForms architecture
- Reading and writing structured data to files
- Parallel arrays for in memory storage
- Array based navigation and indexing
- Dialog driven file selection
- UI updates via shared methods

## Implementation Notes
- Movie data is stored in a plain text file and loaded into parallel arrays on form load
- Once loaded, navigation operates entirely on in memory data
- Next and Previous buttons are enabled or disabled based on current index
- A shared method updates all display labels from the active array index
- Save and Open dialogs are used to avoid hardcoded paths
- Optional artwork loading resolves image paths relative to the data file

## Running the Project
- Open the solution in Visual Studio
- Build and run the application
- Choose to add movies or view an existing collection
- Navigate movies using Next and Previous controls

## Future Work
- Replace parallel arrays with a typed data model
- Add search and filtering
- Validate user input
- Migrate storage to a structured format like JSON

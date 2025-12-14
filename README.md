# Favorite Multi Page Application

## Overview
A Windows Forms application that presents a paginated image gallery built on a single form. The UI displays a fixed number of images per page and updates the content dynamically as the user navigates forward and backward.

Rather than swapping UI layouts, the same image controls are reused while their content is driven by a page index.

## Motivation
I wanted to explore basic pagination and state driven rendering in a desktop UI context. This was a way to practice keeping the UI simple while changing the underlying data being displayed.

## Key Concepts
- Pagination using a page index
- Reusing UI controls with dynamic data
- Event driven user interaction
- UI state synchronization
- Clear, self documenting control naming

## Implementation Notes
- Images are stored in a list and loaded into a fixed set of picture controls
- Each page displays a subset of the list based on the current page index
- Next and Back buttons update the index and trigger a re render
- Navigation buttons are enabled or disabled based on page bounds
- Selection state resets on page change to avoid stale UI feedback

## Running the Project
- Open the solution in Visual Studio
- Build and run the project
- Click images to select them and use Next or Back to navigate pages

## Future Work
- Make page size configurable
- Replace static assets with a data driven source
- Add lightweight transition effects
- Extract pagination logic into a reusable helper

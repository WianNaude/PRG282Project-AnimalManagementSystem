# Project PRG282: Baobab Ridge Wildlife Rehabilitation Records System

## Group Members
* 603282 Wian Naude
* 603811 Don Nwaezeigwe
* 603902 Jude Bridger
* 605035 Gomolemo Marrk Tshireletso Mabina

## How to build and run the project
1. Open Solution file ( A file with .sln extension )
2. Build the solution with **Ctrl + Shift + B** or by clicking on **Build** in the menu bar and selecting **Build Solution**.
3. Run the project with **Ctrl + F5** or by clicking on **Debug** in the menu bar and selecting **Start Without Debugging**.

## File Formats
* **animals.txt:** Stores animal records separated by pipes ("|") in the format: **ID | Name | Species | Age | Score | Status | Housing Unit**.
* **summary.txt:** Overwritten each time a summary is generated, containing total counts, average age, average recovery score, and breakdown per status category.

## *Features*

## Feature_1 Add a new animal

## Feature_2 View all animals

The View All Animals feature displays valid animal records from animals.txt in a read-only DataGridView.
The grid displays the following columns:
* Animal ID
* Name
* Species
* Age
* Recovery Score
* Status
* Housing Unit
The application creates an empty animals.txt file if one does not exist. Malformed records are skipped without crashing the application, and the user is notified once about the number of skipped records.
Users cannot add, edit, or delete records directly in the grid. Clicking a cell selects the entire animal row.
Animal records use the following pipe-separated format:
AnimalID|Name|Species|Age|RecoveryScore|Status|HousingUnit
The shared RefreshAnimalGrid() method reloads the file and updates the grid without creating duplicate rows.

## Feature_3 Update an animal
* Update Button overwrites the existing text with new text that contains the changes
* Search button that checks for an exact match of the animal ID and displays the record in the text boxes for editing
* A label on the form that tells the user if they are in Edit Mode or Add Mode
  - The label will turn red if it is in Add Mode
  - The label will turn green if it is in Edit Mode

## Feature_4 Delete an animal	

## Feature_5 Generate a summary report
* Generate summary button that creates a text file with the following information:
  - Total number of animals in the system
  - Average age of animals in the system
  - Average recovery score of animals in the system
  - Number of animals by status (e.g. Critical, Serious, Stable)
* The Generate summary button will overwrite the exsisting text in the text file (summary.txt) with the new summary information
  - The new summary will be Displayed in a label on the form
  - The Label will have a defult text as a placeholder

using AnimalManagementSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AnimalManagementSystem.DataLayer
{
    public class AnimalFileHandler
    {
        private readonly string filename;

        public AnimalFileHandler()
        {
            filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt"); // Changes the location of animals.txt to the application's running folder
        }

        // Ensure the file exists and return an error message if it doesn't or cannot be created.
        public bool EnsureFileExists(out string errorMessage) // allows a method to pass back a text description of a failure or null if the operation succeeds
        {
            errorMessage = string.Empty;

            try
            {
                if (!File.Exists(filename))
                {
                    File.Create(filename).Close();
                }

                return true;
            }
            catch (Exception)
            {
                errorMessage = "The program does not have permission to create animals.txt.";
                MessageBox.Show(errorMessage);
                return false;
            }
        }

        public List<Animal> LoadAnimals(out int skippedLines, out string errorMessage)
        {
            List<Animal> animals = new List<Animal>();

            skippedLines = 0;
            errorMessage = string.Empty;

            if (!EnsureFileExists(out errorMessage))
            {
                return animals;
            }

            try
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        skippedLines++; // increments the total skipped fields
                        continue;
                    }

                    Animal? animal; //can be contents of the Animal object or Null

                    bool validRecord = TryParseAnimal(line, out animal); //Tries to convert to a valid record

                    if (validRecord && animal != null) //Checks if they are null
                    {
                        animals.Add(animal); //Successfully adds and animal
                    }
                    else
                    {
                        skippedLines++; //Unsuccessful increases skipped lines
                    }
                }
            }
            catch (UnauthorizedAccessException) //Check if the program has permission to create the file
            {
                errorMessage = "The program does not have permission to read animals.txt.";
            }
            catch (IOException) //Check with an I/O error if the file can be read
            {
                errorMessage = "animals.txt could not be read because it may be in use.";
            }

            return animals;
        }

        // Converts one valid file record into an Animal object or null if nothing is there, prevents errors.
        private bool TryParseAnimal(string line, out Animal? animal)
        {
            animal = null;
            string[] fields = line.Split('|'); //Find what splits the record into variables

            // A complete animal record must contain exactly seven fields.
            if (fields.Length != 7)
            {
                return false;
            }

            string animalID = fields[0].Trim().ToUpper();
            string name = fields[1].Trim();
            string species = fields[2].Trim();
            string ageText = fields[3].Trim();
            string scoreText = fields[4].Trim();
            string status = fields[5].Trim();
            string housingUnit = fields[6].Trim();

            if (!IsValidAnimalID(animalID) || !int.TryParse(ageText, out int age) || !int.TryParse(scoreText, out int recoveryScore) || age < 0 || recoveryScore < 0 ||recoveryScore > 100 ||
                string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species) || string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(housingUnit)) //Checks everything in one if statement rather than multiple
            {
                return false;
            }

            animal = new Animal(animalID, name, species, age, recoveryScore, status, housingUnit);

            return true;
        }

        // Checks for the animal ID WR- followed by exactly four numerical digits.
        private bool IsValidAnimalID(string animalID)
        {
            if (animalID.Length != 7) 
            {
                return false;
            }

            if (animalID[0] != 'W' || animalID[1] != 'R' || animalID[2] != '-') //Check the first three characters to make sure its a valid ID
            {
                return false;
            }

            for (int index = 3; index < animalID.Length; index++) //The loop checks characters at positions 3, 4, 5, and 6. All four characters must be digits for it to work.
            {
                if (!char.IsDigit(animalID[index]))
                {
                    return false;
                }
            }

            return true;

        }
    }
}

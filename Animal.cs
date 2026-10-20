using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem
{
    public class Animal
    {
        private string animalID;
        private string name;
        private string species;
        private int age;
        private int recoveryScore;
        private string status;
        private string housingUnit;

        public Animal() { }
        public Animal(string animalID, string name, string species, int age, int recoveryScore, string status, string housingunit)
        {
            this.AnimalID = animalID;
            this.Name = name;
            this.Species = species;
            this.Age = age;
            this.RecoveryScore = recoveryScore;
            this.Status = status;
            this.HousingUnit = housingunit;
        }

        public string AnimalID { get => animalID; set => animalID = value; } 
        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public int Age { get => age; set => age = value; }
        public int RecoveryScore { get => recoveryScore; set => recoveryScore = value; }
        public string Status { get => status; set => status = value; }
        public string HousingUnit { get => housingUnit; set => housingUnit = value; }

        public void Classification(int score)
        {
            switch (score)
            {
                case >= 0 and <= 19:
                    this.Status = "Critical";
                    this.HousingUnit = "Intensive Care Unit";
                    break;
                case >= 20 and <= 39:
                    this.Status = "Serious";
                    this.HousingUnit = "High-Dependency Ward ";
                    break;
                case >= 40 and <= 59:
                    this.Status = "Stable";
                    this.HousingUnit = "Recovery Ward";
                    break;
                case >= 60 and <= 79:
                    this.Status = "Recovering";
                    this.HousingUnit = "Outdoor Enclosure";
                    break;
                case >= 80 and <= 100:
                    this.Status = "Release-Ready";
                    this.HousingUnit = "Pre-Release Camp";
                    break;
                default:
                    this.Status = "N/A";
                    this.HousingUnit = "N/A";
                    break;
            }
        }
    }
}

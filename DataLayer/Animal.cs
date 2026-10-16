using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.DataLayer
{
    class Animal
    {
        private string animalID;
        private string name;
        private string species;
        private int age;
        private int recoveryScore;
        private string status;
        private string housingUnit;

        public string AnimalID { get => animalID; set => animalID = value; }
        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public int Age { get => age; set => age = value; }
        public int RecoveryScore { get => recoveryScore; set => recoveryScore = value; }
        public string Status { get => status; set => status = value; }
        public string HousingUnit { get => housingUnit; set => housingUnit = value; }

        public Animal(string animalID, string name, string species, int age, int recoveryScore, string status, string housingUnit)
        {
            this.AnimalID = animalID;
            this.Name = name;
            this.Species = species;
            this.Age = age;
            this.RecoveryScore = recoveryScore;
            this.Status = status;
            this.HousingUnit = housingUnit;
        }
    }
}

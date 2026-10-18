using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem.BusinessLayer
{
    public class Animal
    {
        private string animalID;
        private string name;
        private string species;
        private int age;
        private int recoveryScore;

        public Animal(string animalID, string name, string species, int age, int recoveryScore)
        {
            this.AnimalID = animalID;
            this.Name = name;
            this.Species = species;
            this.Age = age;
            this.RecoveryScore = recoveryScore;
        }

        public string AnimalID { get => animalID; set => animalID = value; }
        public string Name { get => name; set => name = value; }
        public string Species { get => species; set => species = value; }
        public int Age { get => age; set => age = value; }
        public int RecoveryScore { get => recoveryScore; set => recoveryScore = value; }
    }
}

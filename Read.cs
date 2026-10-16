using AnimalManagementSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalManagementSystem
{
    class Read
    {      
        public static List<Animal> ReadFromFile()
        {
            List<Animal> animals = new List<Animal>();

            animals.Clear();
            string[] lines = File.ReadAllLines("animals.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                string AnimalID = parts[0].Trim();
                string Name = parts[1].Trim();
                string Species = parts[2].Trim();
                int Age = int.Parse(parts[3].Trim());
                int Score = int.Parse(parts[4].Trim());
                string Status = parts[5].Trim();
                string HousingUnit = parts[6].Trim();

                Animal animal = new Animal(AnimalID, Name, Species, Age, Score, Status, HousingUnit);
                animals.Add(animal);
            }
            return animals;
        }
    }
}

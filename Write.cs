using AnimalManagementSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem
{
    class Write
    {
        public static void WriteToFile(string AnimalID, string Name, string Species, int Age, int RecoveryScore)
        {
            string file = "animals.txt";

            string Status;
            string HousingUnit;
            StatusAndHousingUnit.CalculateStatusAndHousingUnit(RecoveryScore, out Status, out HousingUnit);

            string line = $"{AnimalID}|{Name}|{Species}|{Age}|{RecoveryScore}|{Status}|{HousingUnit}";

            File.AppendAllText(file, line + Environment.NewLine, Encoding.UTF8);
        }
    }
}

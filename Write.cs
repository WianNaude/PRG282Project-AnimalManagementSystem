using AnimalManagementSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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

            try
            {
                File.AppendAllText(file, line + Environment.NewLine, Encoding.UTF8);
            }
            catch (UnauthorizedAccessException un)
            {
                MessageBox.Show($"Permission Denied. Cannot write to file: {un.Message}");
            }
            catch (IOException io)
            {
                MessageBox.Show($"The file is currently being used: {io.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occured: {e.Message}");
            }
            
        }
    }
}

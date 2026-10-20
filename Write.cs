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
        
        public static void WriteToFile(Animal a)
        {
            string file = "animals.txt";

            string line = $"{a.AnimalID}|{a.Name}|{a.Species}|{a.Age}|{a.RecoveryScore}|{a.Status}|{a.HousingUnit}";

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

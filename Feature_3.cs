using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AnimalManagementSystem
{
    class Feature_3
    {
        public Feature_3() { }

        string filepath = "animals.txt";
       
        //Update the data from the inputs to the text file
        public void UpdateData(Animal a)
        {
            try
            {
                string[] selectedRecord = { a.AnimalID, a.Name, a.Species, a.Age.ToString(), a.RecoveryScore.ToString(), a.Status, a.HousingUnit };
                string[] lines = File.ReadAllLines(filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("|");
                    if (parts[0] == a.AnimalID)
                    {
                        lines[i] = string.Join("|", selectedRecord);
                        File.WriteAllLines(filepath, lines);
                        MessageBox.Show("Data updated successfully");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        //Searches for the ID's exact match
        public DataTable SearchID(string ID) 
        {
            DataTable result = new DataTable();
            result.Columns.Add("ID", typeof(string));
            result.Columns.Add("Name", typeof(string));
            result.Columns.Add("Species", typeof(string));
            result.Columns.Add("Age", typeof(int));
            result.Columns.Add("Score", typeof(int));
            result.Columns.Add("Status", typeof(string));
            result.Columns.Add("Housing Unit", typeof(string));

            try
            {
                string[] lines = File.ReadAllLines(filepath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("|");
                    if (parts[0].ToUpper() == ID.ToUpper())
                    {
                        result.Rows.Add(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6]);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return result;// if the for looop does not find anything it will display an empty DataTable
        }
    }
}

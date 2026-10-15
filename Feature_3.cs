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



        string filepath = "Animals.txt";
        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Species", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Score", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Housing Unit", typeof(string));


            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                dt.Rows.Add(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6]);
            }

            return dt;
        }
        // Adds new data to next line
        public void AddData(Animals a)
        {
            string[] newRecord = { a.AnimalID, a.Name, a.Species, a.Age.ToString(), a.RecoveryScore.ToString(), a.Status, a.HousingUnit };
            string FormatedLine = Environment.NewLine + string.Join("|", newRecord) + Environment.NewLine;
            File.AppendAllText(filepath, FormatedLine);
        }
        //Update the data from the inputs to the text file
        public void UpdateData(Animals a)
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
                    return;
                }
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

            string[] lines = File.ReadAllLines(filepath);
            for(int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                if (parts[0].ToUpper() == ID.ToUpper())
                {
                    result.Rows.Add(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], parts[6]);
                    break;
                }
            }
            return result;// if the for looop does not find anything it will display an empty DataTable
        }
    }
}

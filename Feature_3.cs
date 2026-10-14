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
        public string ID { get; set; }
        public string Name { get; set; }
        public string species { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public string status { get; set; }
        public string housingunit { get; set; }

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

        public void AddData()
        {
            string[] newRecord = { this.ID, this.Name, this.species, this.Age.ToString(), this.Score.ToString(), this.status, this.housingunit };
            string FormatedLine = Environment.NewLine + string.Join("|", newRecord) + Environment.NewLine;
            File.AppendAllText(filepath, FormatedLine);
        }

        public void UpdateData()
        {
            string[] selectedRecord = { this.ID, this.Name, this.species, this.Age.ToString(), this.Score.ToString(), this.status, this.housingunit };
            string[] lines = File.ReadAllLines(filepath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                if (parts[0] == this.ID)
                {
                    lines[i] = string.Join("|", selectedRecord);
                    File.WriteAllLines(filepath, lines);
                    return;
                }
            }
        }
    }
}

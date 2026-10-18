using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem
{
    class Feature_5
    {
        public Feature_5() { }

        string filepath = "animals.txt";

        public void GenerateSummary()
        {
            string[] lines = File.ReadAllLines(filepath);

            int totalanimals = lines.Length;
            int totalYears = 0;
            int totalscore = 0;

            string avgYears;
            string avgScore;

            int critical = 0, serious = 0, stable = 0, recovering = 0, realese = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split("|");
                totalYears += int.Parse(parts[3]);
                totalscore += int.Parse(parts[4]);
                switch (parts[5])
                {
                    case "Critical":
                        critical++;
                        break;
                    case "Serious":
                        serious++;
                        break;
                    case "Stable":
                        stable++;
                        break;
                    case "Recovering":
                        recovering++;
                        break;
                    case "Release-Ready":
                        realese++;
                        break;

                    default:
                        break;
                }
            }

            if (totalanimals == 0)
            {
                avgYears = "N/A";
                avgScore = "N/A";
            }
            else
            {
                double avgY = Math.Round((Double)totalYears / totalanimals, 2);
                double avgS = Math.Round((Double)totalscore / totalanimals, 2);

                avgYears = avgY.ToString("F2");
                avgScore = avgS.ToString("F2");
            }

            string summary = $"BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE  \n" +
                             "ANIMAL SUMMARY REPORT \n" +
                             $"Generated: {DateTime.Now:yyyy-MM-dd HH:mm}\n" +
                             "--------------------------------------------\n" +
                             $"Total animals:               {totalanimals}\n" +
                             $"Average age (years):         {avgYears}\n" +
                             $"Average recovery score:      {avgScore}\n" +
                             "--------------------------------------------\n" +
                             "Animals per status:\n" +
                             $"Critical:                    {critical}\n" +
                             $"Serious:                     {serious}\n" +
                             $"Stable:                      {stable}\n" +
                             $"Recovering:                  {recovering}\n" +
                             $"Release-Ready:               {realese}";

            File.WriteAllText("summary.txt", summary);
        }

    }
}

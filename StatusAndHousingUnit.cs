using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalManagementSystem
{
    class StatusAndHousingUnit
    {
        public static void CalculateStatusAndHousingUnit(int RecoveryScore, out string Status,  out string HousingUnitName)
        {           
            if (RecoveryScore <= 19)
                {
                    Status = "Critical";
                    HousingUnitName = "Intensive Care Unit";
                }
                else if (RecoveryScore >= 20 && RecoveryScore <= 39)
                {
                    Status = "Serious";
                    HousingUnitName = "High-Dependency Ward";
                }
                else if (RecoveryScore >= 40 && RecoveryScore <= 59)
                {
                    Status = "Stable";
                    HousingUnitName = "Recovery Ward";
                }
                else if (RecoveryScore >= 60 && RecoveryScore <= 79)
                {
                    Status = "Recovering";
                    HousingUnitName = "Outdoor Enclosure";
                }
                else
                {
                    Status = "Release-Ready";
                    HousingUnitName = "Pre-Release Camp";
                }

        }
    }
}

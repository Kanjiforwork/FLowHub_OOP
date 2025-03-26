using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class FarNormalUrgent : IUpdateStatus
    {
        public string UpdateStatus(DateTime deadline)
        {
            DateTime now = DateTime.Now;
            if ((now - deadline).TotalDays > 30)
            {
                return "Far";

            }
            else if ((now - deadline).TotalDays <= 30 && (now - deadline).TotalDays > 5)
            {
                return "Normal";

            }
            else
            {
                return "Urgent";
            }
        }
    }
}

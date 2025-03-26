using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    internal class NotImportant : IUpdateStatus
    {
        public string UpdateStatus(DateTime deadline)
        {
            return "Not important";
        }
    }
}

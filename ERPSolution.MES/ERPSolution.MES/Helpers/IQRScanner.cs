using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ERPSolution.MES.Helpers
{
    public interface IQRScanner
    {
        Task<string> ScanAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public interface ICalculatorRepository
    {
        void LogCalculationAddress(string IpAddress);
        bool Save();
    }
}

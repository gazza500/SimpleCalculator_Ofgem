using SimpleCalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{
    public class CalculatorRepository : ICalculatorRepository
    {
        private CalculatorContext _context;

        public CalculatorRepository(CalculatorContext context)
        {
            _context = context;
        }

        public void LogCalculationAddress(string IpAddress)
        {
            Log newLog = new Log()
            {
                Id = new Guid(),
                DateTime = DateTime.Now,
                IPAddress = IpAddress
            };
            _context.Logs.Add(newLog);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}

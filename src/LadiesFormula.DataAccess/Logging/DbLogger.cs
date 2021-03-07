using System;
using LadiesFormula.DataAccess.Context;
using Microsoft.Extensions.Logging;

namespace LadiesFormula.DataAccess.Logging
{
    public class DbLogger : ILogger
    {
        private readonly AppDbContext _context;
        private readonly object _lock = new object();

        public DbLogger(AppDbContext context)
        {
            _context = context;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                lock (_lock)
                {

                }
            }
        }
    }
}

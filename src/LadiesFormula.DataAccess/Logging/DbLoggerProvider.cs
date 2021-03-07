using LadiesFormula.DataAccess.Context;
using Microsoft.Extensions.Logging;
using System.Collections.Concurrent;

namespace LadiesFormula.DataAccess.Logging
{
    public class DbLoggerProvider : ILoggerProvider
    {
        private readonly AppDbContext _context;
        private readonly ConcurrentDictionary<string, DbLogger> _loggers;

        public DbLoggerProvider(AppDbContext context)
        {
            _context = context;
            _loggers = new ConcurrentDictionary<string, DbLogger>();
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, new DbLogger(_context));
        }

        public void Dispose() { }
    }
}

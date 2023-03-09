using System;

namespace SalesWebMvc0.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {

        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}

using System;

namespace SalesWebMvc0.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {

        public NotFoundException(string message) : base(message)
        {

        }
    }
}

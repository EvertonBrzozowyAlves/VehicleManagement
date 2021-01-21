using System;

namespace VehicleManagement.Configuration.Exceptions
{
    public class EnvFileNotFoundException : ApplicationException
    {
        public EnvFileNotFoundException()
        {
        }

        public EnvFileNotFoundException(string message) : base(message)
        {
        }
    }
}
